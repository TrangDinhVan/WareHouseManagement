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
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.statusBar_Sector = new System.Windows.Forms.StatusBar();
            this.button_addSector = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView_Sectors = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.superTabItem_Sector = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem_REPO = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem_Repository = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.statusBar_Repo = new System.Windows.Forms.StatusBar();
            this.button_add_Repo = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView_Repo = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl_Sector)).BeginInit();
            this.superTabControl_Sector.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sectors)).BeginInit();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repo)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl_Sector
            // 
            this.superTabControl_Sector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.superTabControl_Sector.Controls.Add(this.superTabControlPanel2);
            this.superTabControl_Sector.Controls.Add(this.superTabControlPanel1);
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
            this.superTabItem_Repository});
            this.superTabControl_Sector.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl_Sector.Text = "superTabControl_Sector";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.superTabControlPanel1.Controls.Add(this.statusBar_Sector);
            this.superTabControlPanel1.Controls.Add(this.button_addSector);
            this.superTabControlPanel1.Controls.Add(this.dataGridView_Sectors);
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
            // button_addSector
            // 
            this.button_addSector.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_addSector.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_addSector.Location = new System.Drawing.Point(2, 1);
            this.button_addSector.Name = "button_addSector";
            this.button_addSector.Size = new System.Drawing.Size(90, 23);
            this.button_addSector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_addSector.TabIndex = 1;
            this.button_addSector.Text = "Add New";
            this.button_addSector.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dataGridView_Sectors
            // 
            this.dataGridView_Sectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Sectors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sectors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Sectors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Sectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dataGridView_Sectors.Location = new System.Drawing.Point(2, 24);
            this.dataGridView_Sectors.Name = "dataGridView_Sectors";
            this.dataGridView_Sectors.Size = new System.Drawing.Size(780, 363);
            this.dataGridView_Sectors.TabIndex = 0;
            this.dataGridView_Sectors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sectors_CellClick);
            this.dataGridView_Sectors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sectors_CellDoubleClick);
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
            // superTabItem_Repository
            // 
            this.superTabItem_Repository.AttachedControl = this.superTabControlPanel2;
            this.superTabItem_Repository.GlobalItem = false;
            this.superTabItem_Repository.Icon = ((System.Drawing.Icon)(resources.GetObject("superTabItem_Repository.Icon")));
            this.superTabItem_Repository.Name = "superTabItem_Repository";
            this.superTabItem_Repository.Text = "REPOSITORY";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.statusBar_Repo);
            this.superTabControlPanel2.Controls.Add(this.button_add_Repo);
            this.superTabControlPanel2.Controls.Add(this.dataGridView_Repo);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(785, 415);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem_Repository;
            // 
            // statusBar_Repo
            // 
            this.statusBar_Repo.Location = new System.Drawing.Point(0, 386);
            this.statusBar_Repo.Name = "statusBar_Repo";
            this.statusBar_Repo.Size = new System.Drawing.Size(785, 29);
            this.statusBar_Repo.TabIndex = 2;
            this.statusBar_Repo.Text = "Repository";
            // 
            // button_add_Repo
            // 
            this.button_add_Repo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_add_Repo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_add_Repo.Location = new System.Drawing.Point(2, 1);
            this.button_add_Repo.Name = "button_add_Repo";
            this.button_add_Repo.Size = new System.Drawing.Size(90, 23);
            this.button_add_Repo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_add_Repo.TabIndex = 1;
            this.button_add_Repo.Text = "Add New";
            this.button_add_Repo.Click += new System.EventHandler(this.button_add_Repo_Click);
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
            this.dataGridView_Repo.Location = new System.Drawing.Point(2, 24);
            this.dataGridView_Repo.Name = "dataGridView_Repo";
            this.dataGridView_Repo.Size = new System.Drawing.Size(780, 363);
            this.dataGridView_Repo.TabIndex = 0;
            this.dataGridView_Repo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Repo_CellClick);
            this.dataGridView_Repo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Repo_CellDoubleClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Delete";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
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
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sectors)).EndInit();
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl_Sector;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Sector;
        private DevComponents.DotNetBar.ButtonX button_addSector;
        private System.Windows.Forms.DataGridView dataGridView_Sectors;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_REPO;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.StatusBar statusBar_Sector;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private System.Windows.Forms.StatusBar statusBar_Repo;
        private DevComponents.DotNetBar.ButtonX button_add_Repo;
        private System.Windows.Forms.DataGridView dataGridView_Repo;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Repository;
    }
}