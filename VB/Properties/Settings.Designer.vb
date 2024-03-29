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
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace WindowsApplication3.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As WindowsApplication3.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New WindowsApplication3.Properties.Settings())), WindowsApplication3.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return WindowsApplication3.Properties.Settings.defaultInstance
            End Get
        End Property
    End Class
End Namespace
