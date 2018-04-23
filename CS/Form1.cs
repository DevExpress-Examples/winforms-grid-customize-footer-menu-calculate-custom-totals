using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Design.XViewsPrinting v = new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
            gridView1.OptionsView.ShowFooter = true;
        }

        private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            if (e.MenuType != DevExpress.XtraGrid.Views.Grid.GridMenuType.Summary) return;
            DevExpress.XtraGrid.Menu.GridViewFooterMenu footerMenu = e.Menu as DevExpress.XtraGrid.Menu.GridViewFooterMenu;
            bool check = e.HitInfo.Column.SummaryItem.SummaryType == DevExpress.Data.SummaryItemType.Custom && Equals("Count", e.HitInfo.Column.SummaryItem.Tag);
            DevExpress.Utils.Menu.DXMenuItem menuItem = new DevExpress.Utils.Menu.DXMenuCheckItem("Active Count", check, null, new EventHandler(MyMenuItem));
            menuItem.Tag = e.HitInfo.Column;
            foreach (DevExpress.Utils.Menu.DXMenuItem item in footerMenu.Items)
                item.Enabled = true;
            footerMenu.Items.Add(menuItem);
        }

        private void MyMenuItem(Object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem Item = sender as DevExpress.Utils.Menu.DXMenuItem;
            GridColumn col = Item.Tag as GridColumn;
            col.SummaryItem.Tag = "Count";
            col.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, string.Empty);
        }

        int validRowCount = 0;

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            GridView view = sender as GridView;
            if (Equals("Count", item.Tag))
            {
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
                    validRowCount = 0;
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
                {
                    if (!Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "Discontinued"))) validRowCount++;
                }
                if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
                    e.TotalValue = validRowCount;
            }
        }


    }
}