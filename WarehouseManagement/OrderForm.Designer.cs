namespace WarehouseManagement
{
    partial class OrderForm
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.field_mail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_fax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_address = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.label7 = new System.Windows.Forms.Label();
            this.field_date = new System.Windows.Forms.DateTimePicker();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.field_volume = new System.Windows.Forms.ComboBox();
            this.field_start_date = new System.Windows.Forms.DateTimePicker();
            this.field_end_date = new System.Windows.Forms.DateTimePicker();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_Repo = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewButtonColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.field_customer_id = new System.Windows.Forms.ComboBox();
            this.field_name = new System.Windows.Forms.ComboBox();
            this.btn_check_exist = new System.Windows.Forms.CheckBox();
            this.field_paid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.field_staff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(4, 543);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(692, 543);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(-5, 24);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(778, 10);
            this.line1.TabIndex = 2;
            this.line1.Text = "line1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fax";
            // 
            // field_mail
            // 
            this.field_mail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.field_mail.Border.Class = "TextBoxBorder";
            this.field_mail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_mail.ForeColor = System.Drawing.Color.Black;
            this.field_mail.Location = new System.Drawing.Point(347, 57);
            this.field_mail.Name = "field_mail";
            this.field_mail.PreventEnterBeep = true;
            this.field_mail.Size = new System.Drawing.Size(273, 25);
            this.field_mail.TabIndex = 10;
            // 
            // field_phone
            // 
            this.field_phone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.field_phone.Border.Class = "TextBoxBorder";
            this.field_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_phone.ForeColor = System.Drawing.Color.Black;
            this.field_phone.Location = new System.Drawing.Point(347, 130);
            this.field_phone.Name = "field_phone";
            this.field_phone.PreventEnterBeep = true;
            this.field_phone.Size = new System.Drawing.Size(225, 25);
            this.field_phone.TabIndex = 11;
            // 
            // field_fax
            // 
            this.field_fax.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.field_fax.Border.Class = "TextBoxBorder";
            this.field_fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_fax.ForeColor = System.Drawing.Color.Black;
            this.field_fax.Location = new System.Drawing.Point(347, 188);
            this.field_fax.Name = "field_fax";
            this.field_fax.PreventEnterBeep = true;
            this.field_fax.Size = new System.Drawing.Size(225, 25);
            this.field_fax.TabIndex = 12;
            // 
            // field_address
            // 
            // 
            // 
            // 
            this.field_address.BackgroundStyle.Class = "RichTextBoxBorder";
            this.field_address.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_address.Location = new System.Drawing.Point(12, 118);
            this.field_address.Name = "field_address";
            this.field_address.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}" +
    "\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.field_address.Size = new System.Drawing.Size(273, 100);
            this.field_address.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // field_date
            // 
            this.field_date.Location = new System.Drawing.Point(398, 1);
            this.field_date.Name = "field_date";
            this.field_date.Size = new System.Drawing.Size(222, 25);
            this.field_date.TabIndex = 15;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(-5, 229);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(778, 14);
            this.line2.TabIndex = 16;
            this.line2.Text = "line2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Volume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "End Date";
            // 
            // field_volume
            // 
            this.field_volume.FormattingEnabled = true;
            this.field_volume.Location = new System.Drawing.Point(4, 277);
            this.field_volume.Name = "field_volume";
            this.field_volume.Size = new System.Drawing.Size(121, 25);
            this.field_volume.TabIndex = 21;
            this.field_volume.SelectedIndexChanged += new System.EventHandler(this.FilterAvailableRepo);
            // 
            // field_start_date
            // 
            this.field_start_date.Location = new System.Drawing.Point(158, 277);
            this.field_start_date.Name = "field_start_date";
            this.field_start_date.Size = new System.Drawing.Size(222, 25);
            this.field_start_date.TabIndex = 22;
            this.field_start_date.ValueChanged += new System.EventHandler(this.FilterAvailableRepo);
            // 
            // field_end_date
            // 
            this.field_end_date.Location = new System.Drawing.Point(401, 277);
            this.field_end_date.Name = "field_end_date";
            this.field_end_date.Size = new System.Drawing.Size(222, 25);
            this.field_end_date.TabIndex = 23;
            this.field_end_date.ValueChanged += new System.EventHandler(this.FilterAvailableRepo);
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(-5, 319);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(778, 20);
            this.line3.TabIndex = 24;
            this.line3.Text = "line3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Available Repository";
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
            this.dataGridView_Repo.Location = new System.Drawing.Point(4, 367);
            this.dataGridView_Repo.Name = "dataGridView_Repo";
            this.dataGridView_Repo.Size = new System.Drawing.Size(763, 170);
            this.dataGridView_Repo.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(642, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Paid";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.Checked = true;
            this.dataGridViewButtonColumn1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.dataGridViewButtonColumn1.CheckValue = null;
            this.dataGridViewButtonColumn1.HeaderText = "Choose";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // field_customer_id
            // 
            this.field_customer_id.FormattingEnabled = true;
            this.field_customer_id.Location = new System.Drawing.Point(79, 1);
            this.field_customer_id.Name = "field_customer_id";
            this.field_customer_id.Size = new System.Drawing.Size(121, 25);
            this.field_customer_id.TabIndex = 28;
            // 
            // field_name
            // 
            this.field_name.FormattingEnabled = true;
            this.field_name.Location = new System.Drawing.Point(12, 70);
            this.field_name.Name = "field_name";
            this.field_name.Size = new System.Drawing.Size(273, 25);
            this.field_name.TabIndex = 29;
            this.field_name.SelectedIndexChanged += new System.EventHandler(this.SwitchExisted);
            // 
            // btn_check_exist
            // 
            this.btn_check_exist.AutoSize = true;
            this.btn_check_exist.Location = new System.Drawing.Point(645, 3);
            this.btn_check_exist.Name = "btn_check_exist";
            this.btn_check_exist.Size = new System.Drawing.Size(128, 21);
            this.btn_check_exist.TabIndex = 31;
            this.btn_check_exist.Text = "Existed Customer";
            this.btn_check_exist.UseVisualStyleBackColor = true;
            this.btn_check_exist.CheckedChanged += new System.EventHandler(this.CheckExistedCustomer);
            // 
            // field_paid
            // 
            this.field_paid.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.field_paid.Border.Class = "TextBoxBorder";
            this.field_paid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_paid.ForeColor = System.Drawing.Color.Black;
            this.field_paid.Location = new System.Drawing.Point(645, 277);
            this.field_paid.Name = "field_paid";
            this.field_paid.PreventEnterBeep = true;
            this.field_paid.Size = new System.Drawing.Size(122, 25);
            this.field_paid.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(697, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Transactor";
            // 
            // field_staff
            // 
            this.field_staff.FormattingEnabled = true;
            this.field_staff.Location = new System.Drawing.Point(594, 130);
            this.field_staff.Name = "field_staff";
            this.field_staff.Size = new System.Drawing.Size(172, 25);
            this.field_staff.TabIndex = 36;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 567);
            this.Controls.Add(this.field_staff);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.field_paid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_check_exist);
            this.Controls.Add(this.field_name);
            this.Controls.Add(this.field_customer_id);
            this.Controls.Add(this.dataGridView_Repo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.field_end_date);
            this.Controls.Add(this.field_start_date);
            this.Controls.Add(this.field_volume);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.field_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.field_address);
            this.Controls.Add(this.field_fax);
            this.Controls.Add(this.field_phone);
            this.Controls.Add(this.field_mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.Text = "Create an new Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX field_mail;
        private DevComponents.DotNetBar.Controls.TextBoxX field_phone;
        private DevComponents.DotNetBar.Controls.TextBoxX field_fax;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx field_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker field_date;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox field_volume;
        private System.Windows.Forms.DateTimePicker field_start_date;
        private System.Windows.Forms.DateTimePicker field_end_date;
        private DevComponents.DotNetBar.Controls.Line line3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_Repo;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.ComboBox field_customer_id;
        private System.Windows.Forms.ComboBox field_name;
        private System.Windows.Forms.CheckBox btn_check_exist;
        private DevComponents.DotNetBar.Controls.TextBoxX field_paid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox field_staff;

    }
}