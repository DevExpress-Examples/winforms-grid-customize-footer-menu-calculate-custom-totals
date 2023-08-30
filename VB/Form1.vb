' Developer Express Code Central Example:
' How to add a custom summary item to the grid's footer menu
' 
' Sometimes it's necessary to specify a way of calculating summaries that is
' different from the default one. Assume you don't want to take into account cells
' with no data when calculating summaries. It's possible to accomplish this task
' using two events: use the GridView.CustomSummaryCalculate
' (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsGridGridView_CustomSummaryCalculatetopic.htm)
' event to provide a custom summary and the GridView.ShowGridMenu
' (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsGridGridView_ShowGridMenutopic.htm)
' event to add a corresponding item to the grid's footer menu.
' See also:
' Custom
' Aggregate Functions
' (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv7.3/DevExpress.XtraGrid/CustomDocument701.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E496
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication3

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim v As Design.XViewsPrinting = New Design.XViewsPrinting(gridControl1)
            gridView1.OptionsView.ShowFooter = True
            AddHandler gridView1.PopupMenuShowing, New PopupMenuShowingEventHandler(AddressOf gridView1_PopupMenuShowing)
        End Sub

        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.MenuType <> GridMenuType.Summary Then Return
            Dim footerMenu As DevExpress.XtraGrid.Menu.GridViewFooterMenu = TryCast(e.Menu, DevExpress.XtraGrid.Menu.GridViewFooterMenu)
            Dim check As Boolean = e.HitInfo.Column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom AndAlso Equals("Count", e.HitInfo.Column.SummaryItem.Tag)
            Dim menuItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuCheckItem("Active Count", check, Nothing, New EventHandler(AddressOf MyMenuItem))
            menuItem.Tag = e.HitInfo.Column
            For Each item As DevExpress.Utils.Menu.DXMenuItem In footerMenu.Items
                item.Enabled = True
            Next

            footerMenu.Items.Add(menuItem)
        End Sub

        Private Sub MyMenuItem(ByVal sender As Object, ByVal e As EventArgs)
            Dim Item As DevExpress.Utils.Menu.DXMenuItem = TryCast(sender, DevExpress.Utils.Menu.DXMenuItem)
            Dim col As GridColumn = TryCast(Item.Tag, GridColumn)
            col.SummaryItem.Tag = "Count"
            col.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, String.Empty)
        End Sub

        Private validRowCount As Integer = 0

        Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs)
            Dim item As GridColumnSummaryItem = TryCast(e.Item, GridColumnSummaryItem)
            Dim view As GridView = TryCast(sender, GridView)
            If Equals("Count", item.Tag) Then
                If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then validRowCount = 0
                If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
                    If Not Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "Discontinued")) Then validRowCount += 1
                End If

                If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then e.TotalValue = validRowCount
            End If
        End Sub
    End Class
End Namespace
