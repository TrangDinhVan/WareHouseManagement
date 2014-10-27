namespace WarehouseManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.superTabControl_Sector = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btn_addMaintain = new DevComponents.DotNetBar.ButtonX();
            this.statusBar_Repo = new System.Windows.Forms.StatusBar();
            this.btn_addRepo = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView_Repo = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.superTabItem_Repository = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.statusBar_Sector = new System.Windows.Forms.StatusBar();
            this.btn_addSector = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView_Sector = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.superTabItem_Sector = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btn_addStaff = new DevComponents.DotNetBar.ButtonX();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.dataGridView_Staff = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.superTabItem_Staff = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem_REPO = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem_Maintain = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btn_add_maintain = new DevComponents.DotNetBar.ButtonX();
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.dataGridView_Maintain = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl_Sector)).BeginInit();
            this.superTabControl_Sector.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repo)).BeginInit();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sector)).BeginInit();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Staff)).BeginInit();
            this.superTabControlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maintain)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl_Sector
            // 
            this.superTabControl_Sector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl_Sector.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl_Sector.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl_Sector.ControlBox.MenuBox.Name = "";
            this.superTabControl_Sector.ControlBox.Name = "";
            this.superTabControl_Sector.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl_Sector.ControlBox.MenuBox,
            this.superTabControl_Sector.ControlBox.CloseBox});
            this.superTabControl_Sector.Controls.Add(this.superTabControlPanel4);
            this.superTabControl_Sector.Controls.Add(this.superTabControlPanel3);
            this.superTabControl_Sector.Controls.Add(this.superTabControlPanel2);
            this.superTabControl_Sector.Controls.Add(this.superTabControlPanel1);
            this.superTabControl_Sector.ForeColor = System.Drawing.Color.Black;
            this.superTabControl_Sector.Location = new System.Drawing.Point(0, 2);
            this.superTabControl_Sector.Name = "superTabControl_Sector";
            this.superTabControl_Sector.ReorderTabsEnabled = true;
            this.superTabControl_Sector.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl_Sector.SelectedTabIndex = 1;
            this.superTabControl_Sector.Size = new System.Drawing.Size(785, 461);
            this.superTabControl_Sector.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl_Sector.TabIndex = 0;
            this.superTabControl_Sector.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem_Sector,
            this.superTabItem_Repository,
            this.superTabItem_Staff,
            this.superTabItem_Maintain});
            this.superTabControl_Sector.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl_Sector.Text = "superTabControl_Sector";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.btn_addMaintain);
            this.superTabControlPanel2.Controls.Add(this.statusBar_Repo);
            this.superTabControlPanel2.Controls.Add(this.btn_addRepo);
            this.superTabControlPanel2.Controls.Add(this.dataGridView_Repo);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(785, 415);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem_Repository;
            // 
            // btn_addMaintain
            // 
            this.btn_addMaintain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addMaintain.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addMaintain.Location = new System.Drawing.Point(634, 1);
            this.btn_addMaintain.Name = "btn_addMaintain";
            this.btn_addMaintain.Size = new System.Drawing.Size(149, 23);
            this.btn_addMaintain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addMaintain.TabIndex = 3;
            this.btn_addMaintain.Text = "Add new Maintainance";
            this.btn_addMaintain.Click += new System.EventHandler(this.LoadSubForm);
            // 
            // statusBar_Repo
            // 
            this.statusBar_Repo.Location = new System.Drawing.Point(0, 386);
            this.statusBar_Repo.Name = "statusBar_Repo";
            this.statusBar_Repo.Size = new System.Drawing.Size(785, 29);
            this.statusBar_Repo.TabIndex = 2;
            this.statusBar_Repo.Text = "Repository";
            // 
            // btn_addRepo
            // 
            this.btn_addRepo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addRepo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addRepo.Location = new System.Drawing.Point(2, 1);
            this.btn_addRepo.Name = "btn_addRepo";
            this.btn_addRepo.Size = new System.Drawing.Size(90, 23);
            this.btn_addRepo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addRepo.TabIndex = 1;
            this.btn_addRepo.Text = "Add New";
            this.btn_addRepo.Click += new System.EventHandler(this.LoadSubForm);
            // 
            // dataGridView_Repo
            // 
            this.dataGridView_Repo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Repo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Repo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Repo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Repo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Repo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dataGridView_Repo.Location = new System.Drawing.Point(2, 25);
            this.dataGridView_Repo.Name = "dataGridView_Repo";
            this.dataGridView_Repo.Size = new System.Drawing.Size(780, 363);
            this.dataGridView_Repo.TabIndex = 0;
            this.dataGridView_Repo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteRecorde);
            this.dataGridView_Repo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadSubForm);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Delete";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // superTabItem_Repository
            // 
            this.superTabItem_Repository.AttachedControl = this.superTabControlPanel2;
            this.superTabItem_Repository.GlobalItem = false;
            this.superTabItem_Repository.Icon = ((System.Drawing.Icon)(resources.GetObject("superTabItem_Repository.Icon")));
            this.superTabItem_Repository.Name = "superTabItem_Repository";
            this.superTabItem_Repository.Text = "REPOSITORY";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.superTabControlPanel1.Controls.Add(this.statusBar_Sector);
            this.superTabControlPanel1.Controls.Add(this.btn_addSector);
            this.superTabControlPanel1.Controls.Add(this.dataGridView_Sector);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(785, 415);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem_Sector;
            // 
            // statusBar_Sector
            // 
            this.statusBar_Sector.Location = new System.Drawing.Point(0, 386);
            this.statusBar_Sector.Name = "statusBar_Sector";
            this.statusBar_Sector.Size = new System.Drawing.Size(785, 29);
            this.statusBar_Sector.TabIndex = 2;
            this.statusBar_Sector.Text = "Sector";
            // 
            // btn_addSector
            // 
            this.btn_addSector.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addSector.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addSector.Location = new System.Drawing.Point(2, 1);
            this.btn_addSector.Name = "btn_addSector";
            this.btn_addSector.Size = new System.Drawing.Size(90, 23);
            this.btn_addSector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addSector.TabIndex = 1;
            this.btn_addSector.Text = "Add New";
            this.btn_addSector.Click += new System.EventHandler(this.LoadSubForm);
            // 
            // dataGridView_Sector
            // 
            this.dataGridView_Sector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Sector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sector.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Sector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Sector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dataGridView_Sector.Location = new System.Drawing.Point(2, 24);
            this.dataGridView_Sector.Name = "dataGridView_Sector";
            this.dataGridView_Sector.Size = new System.Drawing.Size(780, 363);
            this.dataGridView_Sector.TabIndex = 0;
            this.dataGridView_Sector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteRecorde);
            this.dataGridView_Sector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadSubForm);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Delete";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Delete";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // superTabItem_Sector
            // 
            this.superTabItem_Sector.AttachedControl = this.superTabControlPanel1;
            this.superTabItem_Sector.GlobalItem = false;
            this.superTabItem_Sector.Icon = ((System.Drawing.Icon)(resources.GetObject("superTabItem_Sector.Icon")));
            this.superTabItem_Sector.Name = "superTabItem_Sector";
            this.superTabItem_Sector.Text = "SECTOR";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.btn_addStaff);
            this.superTabControlPanel3.Controls.Add(this.statusBar1);
            this.superTabControlPanel3.Controls.Add(this.dataGridView_Staff);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(785, 415);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.superTabItem_Staff;
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addStaff.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addStaff.Location = new System.Drawing.Point(3, 1);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(90, 23);
            this.btn_addStaff.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addStaff.TabIndex = 4;
            this.btn_addStaff.Text = "Add New";
            this.btn_addStaff.Click += new System.EventHandler(this.LoadSubForm);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 386);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(785, 29);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "Repository";
            // 
            // dataGridView_Staff
            // 
            this.dataGridView_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Staff.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn2});
            this.dataGridView_Staff.Location = new System.Drawing.Point(2, 24);
            this.dataGridView_Staff.Name = "dataGridView_Staff";
            this.dataGridView_Staff.Size = new System.Drawing.Size(780, 363);
            this.dataGridView_Staff.TabIndex = 0;
            this.dataGridView_Staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteRecorde);
            this.dataGridView_Staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadSubForm);
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // superTabItem_Staff
            // 
            this.superTabItem_Staff.AttachedControl = this.superTabControlPanel3;
            this.superTabItem_Staff.GlobalItem = false;
            this.superTabItem_Staff.Icon = ((System.Drawing.Icon)(resources.GetObject("superTabItem_Staff.Icon")));
            this.superTabItem_Staff.Name = "superTabItem_Staff";
            this.superTabItem_Staff.Text = "STAFF";
            // 
            // superTabItem_REPO
            // 
            this.superTabItem_REPO.GlobalItem = false;
            this.superTabItem_REPO.Name = "superTabItem_REPO";
            this.superTabItem_REPO.Text = "REPOSITORY";
            // 
            // superTabItem1
            // 
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "REPOSITORY";
            // 
            // superTabItem_Maintain
            // 
            this.superTabItem_Maintain.AttachedControl = this.superTabControlPanel4;
            this.superTabItem_Maintain.GlobalItem = false;
            this.superTabItem_Maintain.Icon = ((System.Drawing.Icon)(resources.GetObject("superTabItem_Maintain.Icon")));
            this.superTabItem_Maintain.Name = "superTabItem_Maintain";
            this.superTabItem_Maintain.Text = "MAINTAIN";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.btn_add_maintain);
            this.superTabControlPanel4.Controls.Add(this.statusBar2);
            this.superTabControlPanel4.Controls.Add(this.dataGridView_Maintain);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(785, 415);
            this.superTabControlPanel4.TabIndex = 4;
            this.superTabControlPanel4.TabItem = this.superTabItem_Maintain;
            // 
            // btn_add_maintain
            // 
            this.btn_add_maintain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add_maintain.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add_maintain.Location = new System.Drawing.Point(3, 1);
            this.btn_add_maintain.Name = "btn_add_maintain";
            this.btn_add_maintain.Size = new System.Drawing.Size(90, 23);
            this.btn_add_maintain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_add_maintain.TabIndex = 4;
            this.btn_add_maintain.Text = "Add New";
            this.btn_add_maintain.Click += new System.EventHandler(this.LoadSubForm);
            // 
            // statusBar2
            // 
            this.statusBar2.Location = new System.Drawing.Point(0, 386);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(785, 29);
            this.statusBar2.TabIndex = 2;
            this.statusBar2.Text = "Repository";
            // 
            // dataGridView_Maintain
            // 
            this.dataGridView_Maintain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Maintain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Maintain.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Maintain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Maintain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Maintain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn3});
            this.dataGridView_Maintain.Location = new System.Drawing.Point(2, 24);
            this.dataGridView_Maintain.Name = "dataGridView_Maintain";
            this.dataGridView_Maintain.Size = new System.Drawing.Size(780, 363);
            this.dataGridView_Maintain.TabIndex = 0;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Delete";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.Text = "Delete";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.superTabControl_Sector);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl_Sector)).EndInit();
            this.superTabControl_Sector.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repo)).EndInit();
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sector)).EndInit();
            this.superTabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Staff)).EndInit();
            this.superTabControlPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maintain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl_Sector;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Sector;
        private DevComponents.DotNetBar.ButtonX btn_addSector;
        private System.Windows.Forms.DataGridView dataGridView_Sector;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_REPO;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.StatusBar statusBar_Sector;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private System.Windows.Forms.StatusBar statusBar_Repo;
        private DevComponents.DotNetBar.ButtonX btn_addRepo;
        private System.Windows.Forms.DataGridView dataGridView_Repo;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Repository;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.DataGridView dataGridView_Staff;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Staff;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DevComponents.DotNetBar.ButtonX btn_addStaff;
        private DevComponents.DotNetBar.ButtonX btn_addMaintain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.ButtonX btn_add_maintain;
        private System.Windows.Forms.StatusBar statusBar2;
        private System.Windows.Forms.DataGridView dataGridView_Maintain;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Maintain;
    }
}