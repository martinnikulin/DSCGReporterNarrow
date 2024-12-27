
namespace DSCGReporter
{
    partial class MainForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageView = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.startButton = new System.Windows.Forms.Button();
            this.projectsGrid = new DevExpress.XtraGrid.GridControl();
            this.projectsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.projectNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.databaseCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverCombo = new System.Windows.Forms.ComboBox();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.ReservesPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ReservesTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comOption = new System.Windows.Forms.RadioButton();
            this.balanceOption = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.reportTypeCombo = new System.Windows.Forms.ComboBox();
            this.variantsList = new System.Windows.Forms.ListView();
            this.variantNColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variantNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.seamsList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageView)).BeginInit();
            this.backstageView.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.ReservesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.backstageView;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ReservesPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.ribbonControl.Size = new System.Drawing.Size(786, 83);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            // 
            // backstageView
            // 
            this.backstageView.Controls.Add(this.backstageViewClientControl1);
            this.backstageView.Items.Add(this.backstageViewTabItem1);
            this.backstageView.Location = new System.Drawing.Point(237, 171);
            this.backstageView.Name = "backstageView";
            this.backstageView.OwnerControl = this.ribbonControl;
            this.backstageView.SelectedTab = this.backstageViewTabItem1;
            this.backstageView.SelectedTabIndex = 0;
            this.backstageView.Size = new System.Drawing.Size(919, 637);
            this.backstageView.TabIndex = 1;
            this.backstageView.Shown += new System.EventHandler(this.backstageView_Shown);
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.startButton);
            this.backstageViewClientControl1.Controls.Add(this.projectsGrid);
            this.backstageViewClientControl1.Controls.Add(this.label2);
            this.backstageViewClientControl1.Controls.Add(this.label1);
            this.backstageViewClientControl1.Controls.Add(this.serverCombo);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(137, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(781, 573);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 339);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "OK";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // projectsGrid
            // 
            this.projectsGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.projectsGrid.Location = new System.Drawing.Point(12, 116);
            this.projectsGrid.MainView = this.projectsGridView;
            this.projectsGrid.MenuManager = this.ribbonControl;
            this.projectsGrid.Name = "projectsGrid";
            this.projectsGrid.Size = new System.Drawing.Size(400, 200);
            this.projectsGrid.TabIndex = 5;
            this.projectsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.projectsGridView});
            // 
            // projectsGridView
            // 
            this.projectsGridView.Appearance.Empty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.projectsGridView.Appearance.Empty.Options.UseBackColor = true;
            this.projectsGridView.Appearance.OddRow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.projectsGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.projectsGridView.Appearance.Row.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.projectsGridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.projectsGridView.Appearance.Row.Options.UseBackColor = true;
            this.projectsGridView.Appearance.Row.Options.UseFont = true;
            this.projectsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.projectsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.projectNameCol,
            this.databaseCol});
            this.projectsGridView.GridControl = this.projectsGrid;
            this.projectsGridView.Name = "projectsGridView";
            this.projectsGridView.OptionsBehavior.Editable = false;
            this.projectsGridView.OptionsView.ShowColumnHeaders = false;
            this.projectsGridView.OptionsView.ShowGroupPanel = false;
            this.projectsGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.projectsGridView.OptionsView.ShowIndicator = false;
            // 
            // projectNameCol
            // 
            this.projectNameCol.Caption = "gridColumn1";
            this.projectNameCol.FieldName = "ProjectName";
            this.projectNameCol.Name = "projectNameCol";
            this.projectNameCol.Visible = true;
            this.projectNameCol.VisibleIndex = 0;
            // 
            // databaseCol
            // 
            this.databaseCol.Caption = "gridColumn1";
            this.databaseCol.FieldName = "Database";
            this.databaseCol.Name = "databaseCol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Проекты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сервер";
            // 
            // serverCombo
            // 
            this.serverCombo.DisplayMember = "ServerName";
            this.serverCombo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.serverCombo.FormattingEnabled = true;
            this.serverCombo.ItemHeight = 14;
            this.serverCombo.Location = new System.Drawing.Point(12, 33);
            this.serverCombo.Name = "serverCombo";
            this.serverCombo.Size = new System.Drawing.Size(215, 22);
            this.serverCombo.TabIndex = 0;
            this.serverCombo.DropDownClosed += new System.EventHandler(this.serverCombo_DropDownClosed);
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "Открыть";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
            // 
            // ReservesPage
            // 
            this.ReservesPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ReservesPage.Name = "ReservesPage";
            this.ReservesPage.Text = "Запасы";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 453);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(784, 27);
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 83);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.xtraTabPage2;
            this.TabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.TabControl.Size = new System.Drawing.Size(786, 482);
            this.TabControl.TabIndex = 3;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.ReservesTabPage,
            this.xtraTabPage2});
            this.TabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControl_SelectedPageChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.backstageView);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(784, 480);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // ReservesTabPage
            // 
            this.ReservesTabPage.Controls.Add(this.button1);
            this.ReservesTabPage.Controls.Add(this.comOption);
            this.ReservesTabPage.Controls.Add(this.balanceOption);
            this.ReservesTabPage.Controls.Add(this.label5);
            this.ReservesTabPage.Controls.Add(this.reportTypeCombo);
            this.ReservesTabPage.Controls.Add(this.variantsList);
            this.ReservesTabPage.Controls.Add(this.splitter1);
            this.ReservesTabPage.Controls.Add(this.seamsList);
            this.ReservesTabPage.Controls.Add(this.ribbonStatusBar1);
            this.ReservesTabPage.Name = "ReservesTabPage";
            this.ReservesTabPage.Size = new System.Drawing.Size(784, 480);
            this.ReservesTabPage.Text = "xtraTabPage1";
            this.ReservesTabPage.Enter += new System.EventHandler(this.xtraTabPage1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Создать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comOption
            // 
            this.comOption.AutoSize = true;
            this.comOption.Location = new System.Drawing.Point(622, 54);
            this.comOption.Name = "comOption";
            this.comOption.Size = new System.Drawing.Size(143, 17);
            this.comOption.TabIndex = 27;
            this.comOption.Text = "Промышленные запасы";
            this.comOption.UseVisualStyleBackColor = true;
            // 
            // balanceOption
            // 
            this.balanceOption.AutoSize = true;
            this.balanceOption.Checked = true;
            this.balanceOption.Location = new System.Drawing.Point(622, 21);
            this.balanceOption.Name = "balanceOption";
            this.balanceOption.Size = new System.Drawing.Size(125, 17);
            this.balanceOption.TabIndex = 26;
            this.balanceOption.TabStop = true;
            this.balanceOption.Text = "Балансовые запасы";
            this.balanceOption.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(619, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Тип отчета";
            // 
            // reportTypeCombo
            // 
            this.reportTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeCombo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportTypeCombo.FormattingEnabled = true;
            this.reportTypeCombo.Items.AddRange(new object[] {
            "Повариантный",
            "Нарастающим итогом"});
            this.reportTypeCombo.Location = new System.Drawing.Point(622, 116);
            this.reportTypeCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportTypeCombo.Name = "reportTypeCombo";
            this.reportTypeCombo.Size = new System.Drawing.Size(151, 22);
            this.reportTypeCombo.TabIndex = 22;
            this.reportTypeCombo.SelectedIndexChanged += new System.EventHandler(this.reportTypeCombo_SelectedIndexChanged);
            // 
            // variantsList
            // 
            this.variantsList.CheckBoxes = true;
            this.variantsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.variantNColumn,
            this.variantNameColumn});
            this.variantsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.variantsList.Font = new System.Drawing.Font("Tahoma", 9F);
            this.variantsList.FullRowSelect = true;
            this.variantsList.GridLines = true;
            this.variantsList.HideSelection = false;
            this.variantsList.Location = new System.Drawing.Point(303, 0);
            this.variantsList.Name = "variantsList";
            this.variantsList.Size = new System.Drawing.Size(300, 453);
            this.variantsList.TabIndex = 4;
            this.variantsList.UseCompatibleStateImageBehavior = false;
            this.variantsList.View = System.Windows.Forms.View.Details;
            // 
            // variantNColumn
            // 
            this.variantNColumn.Text = "N";
            this.variantNColumn.Width = 50;
            // 
            // variantNameColumn
            // 
            this.variantNameColumn.Text = "Кондиции";
            this.variantNameColumn.Width = 219;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(300, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 453);
            this.splitter1.TabIndex = 30;
            this.splitter1.TabStop = false;
            // 
            // seamsList
            // 
            this.seamsList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.seamsList.BackColor = System.Drawing.SystemColors.Window;
            this.seamsList.CheckBoxes = true;
            this.seamsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.idColumn});
            this.seamsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.seamsList.Font = new System.Drawing.Font("Tahoma", 9F);
            this.seamsList.FullRowSelect = true;
            this.seamsList.GridLines = true;
            this.seamsList.HideSelection = false;
            this.seamsList.Location = new System.Drawing.Point(0, 0);
            this.seamsList.Name = "seamsList";
            this.seamsList.Size = new System.Drawing.Size(300, 453);
            this.seamsList.TabIndex = 2;
            this.seamsList.UseCompatibleStateImageBehavior = false;
            this.seamsList.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Пласт";
            this.nameColumn.Width = 266;
            // 
            // idColumn
            // 
            this.idColumn.Width = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 565);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageView)).EndInit();
            this.backstageView.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            this.backstageViewClientControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ReservesTabPage.ResumeLayout(false);
            this.ReservesTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ReservesPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageView;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serverCombo;
        private System.Windows.Forms.Button startButton;
        private DevExpress.XtraGrid.GridControl projectsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView projectsGridView;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn projectNameCol;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage ReservesTabPage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ListView seamsList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ListView variantsList;
        private System.Windows.Forms.ColumnHeader variantNColumn;
        private System.Windows.Forms.ColumnHeader variantNameColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton comOption;
        private System.Windows.Forms.RadioButton balanceOption;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.Columns.GridColumn databaseCol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox reportTypeCombo;
    }
}

