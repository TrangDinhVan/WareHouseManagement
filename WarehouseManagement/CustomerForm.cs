using System;
using System.Windows.Forms;
//
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class CustomerForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm F { get; set; }
        public int CustomerId { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (CustomerId == 0) return;
                Text = "Customer ID: " + CustomerId;
                Customer customer = new CustomerDAL().GetOneCustomer(CustomerId);
                field_name.Text = customer.Name;
                field_address.Text = customer.Address;
                field_phone.Text = customer.Phone;
                field_fax.Text = customer.Fax;
                field_mail.Text = customer.Mail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_Customer(object sender, EventArgs e)
        {
            try
            {
                new CustomerDAL().UpdateCustomer(GetInfo());
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Customer GetInfo()
        {
            try
            {
                return new Customer()
                {
                    Id = CustomerId,
                    Name = field_name.Text,
                    Address = field_address.Text,
                    Phone = field_phone.Text,
                    Fax = field_fax.Text,
                    Mail = field_mail.Text
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ReportOrders()
        {
            throw new Exception("Not Implemented");
        }
    }
}