namespace WarehouseManagement
{
    partial class RepositoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Name = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.field_sector = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.field_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_desc = new System.Windows.Forms.RichTextBox();
            this.field_price = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.field_volume = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Label1 = new DevComponents.DotNetBar.LabelX();
            this.field_staff = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dataGridView_Report = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_add = new DevComponents.DotNetBar.ButtonX();
            this.report_choice = new System.Windows.Forms.ComboBox();
            this.btn_add_maintain = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.totalCost = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            // 
            // 
            // 
            this.label_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(14, 16);
            this.label_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(87, 30);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(14, 69);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 30);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Description";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(334, 69);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 30);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Price";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(334, 16);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 30);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Sector";
            // 
            // field_sector
            // 
            this.field_sector.DisplayMember = "Text";
            this.field_sector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.field_sector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_sector.FormattingEnabled = true;
            this.field_sector.ItemHeight = 19;
            this.field_sector.Location = new System.Drawing.Point(391, 21);
            this.field_sector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_sector.Name = "field_sector";
            this.field_sector.Size = new System.Drawing.Size(163, 25);
            this.field_sector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.field_sector.TabIndex = 4;
            // 
            // field_name
            // 
            this.field_name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.field_name.Border.Class = "TextBoxBorder";
            this.field_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_name.ForeColor = System.Drawing.Color.Black;
            this.field_name.Location = new System.Drawing.Point(70, 21);
            this.field_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_name.Name = "field_name";
            this.field_name.PreventEnterBeep = true;
            this.field_name.Size = new System.Drawing.Size(242, 25);
            this.field_name.TabIndex = 5;
            // 
            // field_desc
            // 
            this.field_desc.Location = new System.Drawing.Point(14, 107);
            this.field_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_desc.Name = "field_desc";
            this.field_desc.Size = new System.Drawing.Size(298, 124);
            this.field_desc.TabIndex = 6;
            this.field_desc.Text = "";
            // 
            // field_price
            // 
            this.field_price.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.field_price.Border.Class = "TextBoxBorder";
            this.field_price.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_price.ForeColor = System.Drawing.Color.Black;
            this.field_price.Location = new System.Drawing.Point(391, 74);
            this.field_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_price.Name = "field_price";
            this.field_price.PreventEnterBeep = true;
            this.field_price.Size = new System.Drawing.Size(163, 25);
            this.field_price.TabIndex = 7;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(334, 121);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 30);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Volume";
            // 
            // field_volume
            // 
            this.field_volume.DisplayMember = "Text";
            this.field_volume.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.field_volume.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_volume.FormattingEnabled = true;
            this.field_volume.ItemHeight = 19;
            this.field_volume.Location = new System.Drawing.Point(391, 126);
            this.field_volume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_volume.Name = "field_volume";
            this.field_volume.Size = new System.Drawing.Size(163, 25);
            this.field_volume.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.field_volume.TabIndex = 9;
            // 
            // Label1
            // 
            // 
            // 
            // 
            this.Label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(334, 168);
            this.Label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 30);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Undertaking Staff";
            // 
            // field_staff
            // 
            this.field_staff.DisplayMember = "Text";
            this.field_staff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.field_staff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_staff.FormattingEnabled = true;
            this.field_staff.ItemHeight = 19;
            this.field_staff.Location = new System.Drawing.Point(334, 206);
            this.field_staff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_staff.Name = "field_staff";
            this.field_staff.Size = new System.Drawing.Size(220, 25);
            this.field_staff.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.field_staff.TabIndex = 11;
            // 
            // dataGridView_Report
            // 
            this.dataGridView_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Report.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Report.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView_Report.Location = new System.Drawing.Point(0, 275);
            this.dataGridView_Report.Name = "dataGridView_Report";
            this.dataGridView_Report.Size = new System.Drawing.Size(569, 202);
            this.dataGridView_Report.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(14, 238);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 25);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.UpdateRepo);
            // 
            // btn_add
            // 
            this.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add.Location = new System.Drawing.Point(479, 238);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.AddRepo);
            // 
            // report_choice
            // 
            this.report_choice.FormattingEnabled = true;
            this.report_choice.Location = new System.Drawing.Point(107, 238);
            this.report_choice.Name = "report_choice";
            this.report_choice.Size = new System.Drawing.Size(205, 25);
            this.report_choice.TabIndex = 15;
            // 
            // btn_add_maintain
            // 
            this.btn_add_maintain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add_maintain.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add_maintain.Location = new System.Drawing.Point(0, 492);
            this.btn_add_maintain.Name = "btn_add_maintain";
            this.btn_add_maintain.Size = new System.Drawing.Size(285, 23);
            this.btn_add_maintain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_add_maintain.TabIndex = 16;
            this.btn_add_maintain.Text = "Add new Maintainance for this Repository";
            this.btn_add_maintain.Click += new System.EventHandler(this.LoadSubForm);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(374, 492);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "Total Cost:";
            // 
            // totalCost
            // 
            this.totalCost.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.totalCost.Border.Class = "TextBoxBorder";
            this.totalCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.totalCost.ForeColor = System.Drawing.Color.Black;
            this.totalCost.Location = new System.Drawing.Point(466, 490);
            this.totalCost.Name = "totalCost";
            this.totalCost.PreventEnterBeep = true;
            this.totalCost.Size = new System.Drawing.Size(100, 25);
            this.totalCost.TabIndex = 18;
            // 
            // RepositoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 518);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btn_add_maintain);
            this.Controls.Add(this.report_choice);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView_Report);
            this.Controls.Add(this.field_staff);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.field_volume);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.field_price);
            this.Controls.Add(this.field_desc);
            this.Controls.Add(this.field_name);
            this.Controls.Add(this.field_sector);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.label_Name);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RepositoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repository";
            this.Load += new System.EventHandler(this.RepositoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX label_Name;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx field_sector;
        private DevComponents.DotNetBar.Controls.TextBoxX field_name;
        private System.Windows.Forms.RichTextBox field_desc;
        private DevComponents.DotNetBar.Controls.TextBoxX field_price;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx field_volume;
        private DevComponents.DotNetBar.LabelX Label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx field_staff;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_Report;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_add;
        private System.Windows.Forms.ComboBox report_choice;
        private DevComponents.DotNetBar.ButtonX btn_add_maintain;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX totalCost;

    }
}