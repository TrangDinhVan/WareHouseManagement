using System;
using System.Windows.Forms;
//
using WarehouseEntity;
using WarehouseDatabaseHelper;

namespace WarehouseManagement
{
    public partial class StaffForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int StaffId { get; set; }
        public MainForm F { get; set; }
        public static string[] PermissionSet = { "Manager Admin", "Transactor and Accountant", "Protector and Technician Admin" };
        public StaffForm()
        {
            InitializeComponent();
            field_permission.DataSource = new Staff().PermissionSet;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            btn_add.Hide();
            btn_save.Hide();
            dataGridView_repo.Hide();
            try
            {
                if (StaffId != 0)
                {
                    btn_save.Show();
                    dataGridView_repo.Show();
                    Text = "Staff ID: " + StaffId;
                    Staff staff = new StaffDAL().GetOneStaff(StaffId);
                    field_name.Text = staff.Name;
                    field_pass.Text = staff.Pass;
                    field_address.Text = staff.Address;
                    field_mail.Text = staff.Mail;
                    field_phone.Text = staff.Phone;
                    field_permission.Text = staff.Permission;
                }
                else
                {
                    btn_add.Show();
                    Text = "Add new Staff";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Staff(object sender, EventArgs e)
        {
            try
            {
                Staff staff = GetInfo();
                new StaffDAL().AddStaff(staff);
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void grant_Permission(object sender, EventArgs e)
        {
            try
            {
                Staff staff = GetInfo();
                new StaffDAL().UpdateStaff(staff);
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Staff GetInfo()
        {
            Staff staff = new Staff
            {
                Id = StaffId,
                Name = field_name.Text,
                Pass = field_pass.Text,
                Permission = field_permission.Text,
                Address = field_address.Text,
                Mail = field_mail.Text,
                Phone = field_phone.Text
            };
            return staff;
        }
    }
}