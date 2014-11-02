namespace WarehouseManagement
{
    partial class MaintainForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.field_repo = new System.Windows.Forms.ComboBox();
            this.field_start_date = new System.Windows.Forms.DateTimePicker();
            this.field_end_date = new System.Windows.Forms.DateTimePicker();
            this.field_duration = new System.Windows.Forms.TextBox();
            this.field_desc = new System.Windows.Forms.RichTextBox();
            this.field_price = new System.Windows.Forms.TextBox();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_add = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 13);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 30);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Repository";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 51);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 30);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Start Date";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 89);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 30);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "End Date";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 127);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 30);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Duration";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 165);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 30);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Description";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 222);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(87, 30);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Price";
            // 
            // field_repo
            // 
            this.field_repo.FormattingEnabled = true;
            this.field_repo.Location = new System.Drawing.Point(105, 18);
            this.field_repo.Name = "field_repo";
            this.field_repo.Size = new System.Drawing.Size(271, 25);
            this.field_repo.TabIndex = 6;
            // 
            // field_start_date
            // 
            this.field_start_date.Location = new System.Drawing.Point(105, 58);
            this.field_start_date.Name = "field_start_date";
            this.field_start_date.Size = new System.Drawing.Size(271, 25);
            this.field_start_date.TabIndex = 7;
            this.field_start_date.ValueChanged += new System.EventHandler(this.ValidRange);
            // 
            // field_end_date
            // 
            this.field_end_date.Location = new System.Drawing.Point(105, 94);
            this.field_end_date.Name = "field_end_date";
            this.field_end_date.Size = new System.Drawing.Size(271, 25);
            this.field_end_date.TabIndex = 8;
            this.field_end_date.ValueChanged += new System.EventHandler(this.ValidRange);
            // 
            // field_duration
            // 
            this.field_duration.Location = new System.Drawing.Point(105, 131);
            this.field_duration.Name = "field_duration";
            this.field_duration.Size = new System.Drawing.Size(91, 25);
            this.field_duration.TabIndex = 9;
            // 
            // field_desc
            // 
            this.field_desc.Location = new System.Drawing.Point(105, 165);
            this.field_desc.Name = "field_desc";
            this.field_desc.Size = new System.Drawing.Size(271, 50);
            this.field_desc.TabIndex = 10;
            this.field_desc.Text = "";
            // 
            // field_price
            // 
            this.field_price.Location = new System.Drawing.Point(105, 226);
            this.field_price.Name = "field_price";
            this.field_price.Size = new System.Drawing.Size(91, 25);
            this.field_price.TabIndex = 11;
            this.field_price.Text = "0";
            this.field_price.TextChanged += new System.EventHandler(this.ValidRange);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(12, 262);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            // 
            // btn_add
            // 
            this.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add.Location = new System.Drawing.Point(300, 261);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.add_Maintain);
            // 
            // MaintainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 285);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.field_price);
            this.Controls.Add(this.field_desc);
            this.Controls.Add(this.field_duration);
            this.Controls.Add(this.field_end_date);
            this.Controls.Add(this.field_start_date);
            this.Controls.Add(this.field_repo);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaintainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintainance";
            this.Load += new System.EventHandler(this.MaintainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.ComboBox field_repo;
        private System.Windows.Forms.DateTimePicker field_start_date;
        private System.Windows.Forms.DateTimePicker field_end_date;
        private System.Windows.Forms.TextBox field_duration;
        private System.Windows.Forms.RichTextBox field_desc;
        private System.Windows.Forms.TextBox field_price;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_add;
    }
}