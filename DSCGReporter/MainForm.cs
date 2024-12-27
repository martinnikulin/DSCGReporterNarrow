using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSCGReporter
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            DSCGConnections.ConnectToHomeCatalog();
            serverCombo.DataSource = Data.GetServers();
            FillProjectsGrid();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ribbonControl.ShowApplicationButtonContentControl();
        }

        private void serverCombo_DropDownClosed(object sender, EventArgs e)
        {
            FillProjectsGrid();
        }

        private void FillProjectsGrid()
        {
            DataRowView vrow = (DataRowView)serverCombo.SelectedItem;
            DataRow row = vrow.Row;
            string server = row.Field<string>("RemoteServer");
            DSCGConnections.ConnectToRemoteCatalog(server);
            projectsGrid.DataSource = Data.GetProjects();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ribbonControl.HideApplicationButtonContentControl();
            string Database = projectsGridView.GetFocusedRowCellValue("Database").ToString();
            DSCGConnections.ConnectToGDB(Database);
            TabControl.SelectedTabPage = ReservesTabPage;
        }

        private void xtraTabPage1_Enter(object sender, EventArgs e)
        {
            
        }

        private void TabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (TabControl.SelectedTabPageIndex)
            {
                case 0: 
                    ActivateReservesPage();
                    break;
            }
        }

        private void ActivateReservesPage()
        {
            FillSeamsList(Data.GetSeams());
            reportTypeCombo.SelectedIndex = 0;
            FillVariantsList(Data.GetVariants(reportTypeCombo.SelectedIndex + 1));
        }

        private void FillSeamsList(DataTable seams)
        {
            seamsList.Items.Clear();
            foreach (var seam in seams.AsEnumerable())
            {
                ListViewItem seamItem = new ListViewItem(seam.Field<string>("SeamName"));
                seamItem.SubItems.Add(seam.Field<int>("SeamId").ToString());
                seamsList.Items.Add(seamItem);
            }
        }
        private void FillVariantsList(DataTable variants)
        {
            variantsList.Items.Clear();
            foreach (var variant in variants.AsEnumerable())
            {
                ListViewItem variantItem = new ListViewItem(variant.Field<int>("NVariant").ToString());
                variantItem.SubItems.Add(variant.Field<string>("VariantName"));
                variantsList.Items.Add(variantItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var report = new ReserveReports();
            if (balanceOption.Checked) { 
                report.ReportKind = "BalanceReserves"; 
            }
            else { 
                report.ReportKind = "ComReserves"; 
            };
            report.ReportType = reportTypeCombo.SelectedIndex + 1;
            report.CreateReport(variantsList.CheckedItems, seamsList.CheckedItems);
        }

        private void backstageView_Shown(object sender, EventArgs e)
        {
            TabControl.SelectedTabPage = xtraTabPage2;
        }

        private void reportTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillVariantsList(Data.GetVariants(reportTypeCombo.SelectedIndex + 1));
        }
    }
}
