Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim v As New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
			gridView1.OptionsView.ShowFooter = True
		End Sub

		Private Sub gridView1_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs) Handles gridView1.ShowGridMenu
			If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Summary Then
				Return
			End If
			Dim footerMenu As DevExpress.XtraGrid.Menu.GridViewFooterMenu = TryCast(e.Menu, DevExpress.XtraGrid.Menu.GridViewFooterMenu)
			Dim check As Boolean = e.HitInfo.Column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom AndAlso Equals("Count", e.HitInfo.Column.SummaryItem.Tag)
			Dim menuItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuCheckItem("Active Count", check, Nothing, New EventHandler(AddressOf MyMenuItem))
			menuItem.Tag = e.HitInfo.Column
			For Each item As DevExpress.Utils.Menu.DXMenuItem In footerMenu.Items
				item.Enabled = True
			Next item
			footerMenu.Items.Add(menuItem)
		End Sub

		Private Sub MyMenuItem(ByVal sender As Object, ByVal e As EventArgs)
			Dim Item As DevExpress.Utils.Menu.DXMenuItem = TryCast(sender, DevExpress.Utils.Menu.DXMenuItem)
			Dim col As GridColumn = TryCast(Item.Tag, GridColumn)
			col.SummaryItem.Tag = "Count"
			col.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, String.Empty)
		End Sub

		Private validRowCount As Integer = 0

		Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView1.CustomSummaryCalculate
			Dim item As GridColumnSummaryItem = TryCast(e.Item, GridColumnSummaryItem)
			Dim view As GridView = TryCast(sender, GridView)
			If Equals("Count", item.Tag) Then
				If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
					validRowCount = 0
				End If
				If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
					If (Not Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "Discontinued"))) Then
						validRowCount += 1
					End If
				End If
				If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then
					e.TotalValue = validRowCount
				End If
			End If
		End Sub


	End Class
End Namespace