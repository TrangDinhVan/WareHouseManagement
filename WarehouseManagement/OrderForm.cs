using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
//
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class OrderForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int OrderId { get; set; }
        public MainForm F { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            field_staff.DataSource = new StaffDAL().getAllStaff().DefaultView;
            field_staff.ValueMember = "ID";
            field_staff.DisplayMember = "Name";
            field_volume.DataSource = new Repository().VolumeSet;
            dataGridView_Repo.DataSource = new RepositoryDAL().GetAllRepo();
            field_date.MinDate = DateTime.Today.Date;
            field_start_date.MinDate = DateTime.Today.Date;
            field_end_date.MinDate = DateTime.Today.AddDays(1).Date;
        }

        private void CheckExistedCustomer(object sender, EventArgs e)
        {
            if (btn_check_exist.Checked)
            {
                try
                {
                    DataTable customerSet = new CustomerDAL().getAllCustomer();
                    field_name.DataSource = customerSet.DefaultView;
                    field_name.DisplayMember = "Name";
                    field_name.ValueMember = customerSet.Columns["ID"].ToString();
                    field_customer_id.Text = field_name.SelectedValue.ToString();
                    Customer cus = new CustomerDAL().GetOneCustomer(int.Parse(field_customer_id.Text));
                    field_address.Text = cus.Address;
                    field_mail.Text = cus.Mail;
                    field_phone.Text = cus.Phone;
                    field_fax.Text = cus.Fax;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                field_name.Text = "";
                field_customer_id.Text = "";
                field_fax.Text = "";
                field_phone.Text = "";
                field_mail.Text = "";
                field_address.Text = "";
            }
        }

        private void SwitchExisted(object sender, EventArgs e)
        {
            field_customer_id.Text = field_name.SelectedValue.ToString();
            try
            {
                Customer cus = new CustomerDAL().GetOneCustomer(Convert.ToInt32(field_customer_id.Text));
                field_address.Text = cus.Address;
                field_mail.Text = cus.Mail;
                field_phone.Text = cus.Phone;
                field_fax.Text = cus.Fax;
            }
            catch
            {
                
            }
        }

        private void FilterAvailableRepo(object sender, EventArgs e)
        {
            field_end_date.MinDate = field_start_date.Value.Date.AddDays(1);
            try
            {
                DataTable repoMaintain =
                    new RepositoryDAL().GetSomeRepo(string.Format("select * from [v_repository] where [Volume] = '{2}' and [Repository ID] not in (select repo_id from [maintainance] where (start_date between #{0}# and #{1}#) or (end_date between #{0}# and #{1}#) and [Repository ID] not in (select repo_id from [order_detail] where (start_date between #{0}# and #{1}#) or (end_date between #{0}# and #{1}#) ) )",field_start_date.Value.ToShortDateString(), field_end_date.Value.ToShortDateString(),field_volume.Text));
                dataGridView_Repo.DataSource = repoMaintain;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex);
            }
            
        }

        private Order GetInfo()
        {
            try
            {
                return new Order
                {
                    Id = OrderId,
                    Date = field_date.Value.Date,
                    Paid = Convert.ToDouble(field_paid.Text),
                    Staff = new StaffDAL().GetOneStaff(Convert.ToInt32(field_staff.ValueMember)),
                    Customer = new CustomerDAL().GetOneCustomer(Convert.ToInt32(field_customer_id.ValueMember)),
                    LstOrderDetail = (DataTable) dataGridView_Repo.DataSource
                };
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
            
        }
    }
}