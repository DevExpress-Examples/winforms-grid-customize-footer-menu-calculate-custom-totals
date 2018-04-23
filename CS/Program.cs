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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApplication3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}