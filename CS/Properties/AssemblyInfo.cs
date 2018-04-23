// Developer Express Code Central Example:
// How to add a custom summary item to the grid's footer menu
// 
// Sometimes it's necessary to specify a way of calculating summaries that is
// different from the default one. Assume you don't want to take into account cells
// with no data when calculating summaries. It's possible to accomplish this task
// using two events: use the GridView.CustomSummaryCalculate
// (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsGridGridView_CustomSummaryCalculatetopic.htm)
// event to provide a custom summary and the GridView.ShowGridMenu
// (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsGridGridView_ShowGridMenutopic.htm)
// event to add a corresponding item to the grid's footer menu.
// See also:
// Custom
// Aggregate Functions
// (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv7.3/DevExpress.XtraGrid/CustomDocument701.htm)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E496

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WindowsApplication3")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("-")]
[assembly: AssemblyProduct("WindowsApplication3")]
[assembly: AssemblyCopyright("Copyright © - 2007")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("09a4f065-3d73-4dd8-9c85-b4869dbb865d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
