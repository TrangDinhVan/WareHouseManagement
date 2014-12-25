using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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
            field_volume.DataSource = new Repository().VolumeSet;
            dataGridView_Repo.DataSource = new RepositoryDAL().GetAllRepo();
            field_start_date.MinDate = DateTime.Today.Date;
            field_end_date.MinDate = DateTime.Today.AddDays(1).Date;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            if (OrderId != 0)
            {
                btn_check_exist.Hide();
                btn_add.Hide();
                try
                {
                    Order order = new OrderDAL().GetOneOrder(OrderId);
                    //Customer Info
                    CheckUpdateCondition();

                    field_customer_id.SelectedValue = order.Customer.Id;
                    field_name.SelectedValue = order.Customer.Id;
                    field_address.Text = order.Customer.Address;
                    field_mail.Text = order.Customer.Mail;
                    field_phone.Text = order.Customer.Phone;
                    field_fax.Text = order.Customer.Fax;
                    field_date.Value = order.Date;
                    field_customer_id.Text = order.Customer.Id.ToString();
                    field_name.Text = order.Customer.Name;
                    //Order Info
                    field_date.Value = order.Date;
                    field_paid.Text = order.Paid.ToString();
                    //Order detail
                    dataGridView_Repo.DataSource = order.LstOrderDetail;
                    field_total.Text = CalculateBill(order).ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message+ex);
                }
            }
        }

        private void CheckExistedCustomer(object sender, EventArgs e)
        {
            if (btn_check_exist.Checked)
            {
                try
                {
                    field_date.MinDate = DateTime.Today.Date;
                    DataTable customerSet = new CustomerDAL().GetAllCustomer();
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
                    new RepositoryDAL().GetSomeRepo(string.Format("select * from [v_repository] where [Volume] = '{2}' and [Repository ID] not in (select repo_id from [maintainance] where (start_date between #{0}# and #{1}#) or (end_date between #{0}# and #{1}#) or (#{0}# between start_date and end_date) or (#{1}# between start_date and end_date) ) and [Repository ID] not in (select repo_id from [order_detail] where (start_date between #{0}# and #{1}#) or (end_date between #{0}# and #{1}#) or (end_date between #{0}# and #{1}#) or (#{0}# between start_date and end_date) or (#{1}# between start_date and end_date) )", field_start_date.Value.ToShortDateString(), field_end_date.Value.ToShortDateString(), field_volume.Text));
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
                Order order = new Order
                {
                    Id = OrderId,
                    Date = field_date.Value.Date,
                    Paid = Convert.ToDouble(field_paid.Text),
                    LstOrderDetail = (DataTable) dataGridView_Repo.DataSource,
                    Staff = F.LogginedStaff
                };
                if (btn_check_exist.Checked)
                {
                    order.Customer = new CustomerDAL().GetOneCustomer(Convert.ToInt32(field_customer_id.Text));
                }
                else
                {
                    var cusId = new CustomerDAL().GetScopeIdentity();
                    order.Customer = new CustomerDAL().GetOneCustomer(cusId);
                }
                return order;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message+ex);
            }
            
        }

        private Customer GetInfoCustomer()
        {
            try
            {
                return new Customer()
                {
                    Id = Convert.ToInt32(field_customer_id.Text),
                    Name = field_name.Text,
                    Address = field_address.Text,
                    Phone = field_phone.Text,
                    Mail = field_mail.Text,
                    Fax = field_fax.Text
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message+ex);
            }
        }

        private void CreateOrder(object sender, EventArgs e)
        {
            try
            {
                if (!btn_check_exist.Checked)
                {
                    new CustomerDAL().AddCustomer(GetInfoCustomer());
                }
                new OrderDAL().CreateOrder(GetInfo());
                CreateDetail();
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex);
            }
        }

        private void CreateDetail()
        {
            try
            {
                double sum = 0;
                foreach (DataGridViewRow r in dataGridView_Repo.Rows)
                {
                    if (Convert.ToBoolean(r.Cells["choose"].Value) != true) continue;
                    OrderDetail detail = new OrderDetail()
                    {
                        StartDate = field_start_date.Value.Date,
                        EndDate = field_end_date.Value.Date,
                        Repo = new RepositoryDAL().GetOneRepo(Convert.ToInt32(r.Cells["Repository ID"].Value)),
                        Order = new OrderDAL().GetOneOrder(new OrderDAL().GetScopeIdentity())
                    };
                    new OrderDetailDAL().CreateOrderDetail(detail);
                    sum += detail.GetPaidMoney();
                }
                SumaryOrder(sum);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message+ex);
            }
        }

        private void SumaryOrder(double sum)
        {
            MessageBox.Show("Total Cost:" + sum);
        }

        private double CalculateBill(Order order)
        {
            double sum = 0;
            foreach (DataRow r in order.LstOrderDetail.Rows)
            {
                sum += new OrderDetailDAL().GetOneOrderDetail(int.Parse(r[0].ToString())).GetPaidMoney();
            }
            return sum;
        }

        private void CheckUpdateCondition()
        {
            Order order = new OrderDAL().GetOneOrder(OrderId);
            if ((from DataRow r in order.LstOrderDetail.Rows select Convert.ToDateTime(r["start_date"].ToString()).Date).Any(startDate => startDate < DateTime.Today || startDate.Date == DateTime.Today.Date))
            {
//                btn_save.Hide();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                new OrderDAL().UpdateOrder(GetInfo());
                foreach (DataGridViewRow r in dataGridView_Repo.Rows)
                {
                    OrderDetail detail = new OrderDetail
                    {
                        Id = Convert.ToInt32(r.Cells["order_detail_id"].Value),
                        CheckedOut = Convert.ToBoolean(r.Cells["checked_out"].Value)
                    };
                    new OrderDetailDAL().UpdateOrderDetail(detail);
                }
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex);
            }
        }
    }
}