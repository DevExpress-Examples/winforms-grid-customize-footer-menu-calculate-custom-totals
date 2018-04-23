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

namespace WindowsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(508, 291);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridView1_CustomSummaryCalculate);
            
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(508, 291);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Right-click the grid summary footer to see the \"Active Count\" item.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

