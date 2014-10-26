using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
//
using WarehouseEntity;
using WarehouseDatabaseHelper;

namespace WarehouseManagement
{
    public partial class StaffForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int StaffID;
        public MainForm f { get; set; }
        public static string[] permission_set = { "Manager Admin", "Transactor and Accountant", "Protector and Technician Admin" };
        public StaffForm()
        {
            InitializeComponent();
            field_permission.DataSource = permission_set;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            btn_add.Hide();
            btn_save.Hide();
            dataGridView_repo.Hide();
            try
            {
                if (this.StaffID != 0)
                {
                    btn_save.Show();
                    dataGridView_repo.Show();
                    this.Text = "Staff ID: " + StaffID;
                    Staff staff = new StaffDAL().getOneStaff(this.StaffID);
                    field_name.Text = staff.Name;
                    field_address.Text = staff.Address;
                    field_mail.Text = staff.Mail;
                    field_phone.Text = staff.Phone;
                    field_permission.Text = staff.Permission;
                }
                else
                {
                    btn_add.Show();
                    this.Text = "Add new Staff";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Staff(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            try
            {
                staff.Name = field_name.Text;
                staff.Permission = field_permission.Text;
                staff.Address = field_address.Text;
                staff.Mail = field_mail.Text;
                staff.Phone = field_phone.Text;
                new StaffDAL().addStaff(staff);
                f.reloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void grant_Permission(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            try
            {
                staff.Id = this.StaffID;
                staff.Name = field_name.Text;
                staff.Permission = field_permission.Text;
                staff.Address = field_address.Text;
                staff.Mail = field_mail.Text;
                staff.Phone = field_phone.Text;
                new StaffDAL().updateStaff(staff);
                f.reloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}