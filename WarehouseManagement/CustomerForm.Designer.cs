namespace WarehouseManagement
{
    partial class CustomerForm
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
            this.tbn_save = new System.Windows.Forms.Button();
            this.field_mail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_fax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.field_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.field_address = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // tbn_save
            // 
            this.tbn_save.Location = new System.Drawing.Point(12, 286);
            this.tbn_save.Name = "tbn_save";
            this.tbn_save.Size = new System.Drawing.Size(75, 23);
            this.tbn_save.TabIndex = 21;
            this.tbn_save.Text = "Save";
            this.tbn_save.UseVisualStyleBackColor = true;
            this.tbn_save.Click += new System.EventHandler(this.update_Customer);
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
            this.field_mail.Location = new System.Drawing.Point(313, 195);
            this.field_mail.Name = "field_mail";
            this.field_mail.PreventEnterBeep = true;
            this.field_mail.Size = new System.Drawing.Size(257, 25);
            this.field_mail.TabIndex = 20;
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
            this.field_fax.Location = new System.Drawing.Point(313, 110);
            this.field_fax.Name = "field_fax";
            this.field_fax.PreventEnterBeep = true;
            this.field_fax.Size = new System.Drawing.Size(257, 25);
            this.field_fax.TabIndex = 19;
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
            this.field_phone.Location = new System.Drawing.Point(313, 45);
            this.field_phone.Name = "field_phone";
            this.field_phone.PreventEnterBeep = true;
            this.field_phone.Size = new System.Drawing.Size(257, 25);
            this.field_phone.TabIndex = 18;
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
            this.field_name.Location = new System.Drawing.Point(12, 45);
            this.field_name.Name = "field_name";
            this.field_name.PreventEnterBeep = true;
            this.field_name.Size = new System.Drawing.Size(272, 25);
            this.field_name.TabIndex = 17;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 16);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "Name";
            // 
            // field_address
            // 
            // 
            // 
            // 
            this.field_address.BackgroundStyle.Class = "RichTextBoxBorder";
            this.field_address.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.field_address.Location = new System.Drawing.Point(12, 120);
            this.field_address.Name = "field_address";
            this.field_address.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}" +
    "\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.field_address.Size = new System.Drawing.Size(272, 100);
            this.field_address.TabIndex = 15;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(313, 155);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "Email";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(317, 81);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Fax";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(317, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Phone";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 91);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Address";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 324);
            this.Controls.Add(this.tbn_save);
            this.Controls.Add(this.field_mail);
            this.Controls.Add(this.field_fax);
            this.Controls.Add(this.field_phone);
            this.Controls.Add(this.field_name);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.field_address);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbn_save;
        private DevComponents.DotNetBar.Controls.TextBoxX field_mail;
        private DevComponents.DotNetBar.Controls.TextBoxX field_fax;
        private DevComponents.DotNetBar.Controls.TextBoxX field_phone;
        private DevComponents.DotNetBar.Controls.TextBoxX field_name;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx field_address;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}