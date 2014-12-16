using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
//
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class MainForm : Form
    {
        public Staff LogginedStaff { get; set; }
        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Equals("Admin Manager", LogginedStaff.Permission))
            {
                superTabItem_Staff.Enabled = false;
            }
            ReloadData();
        }

        public void ReloadData()
        {
            dataGridView_Sector.DataSource = new SectorDAL().GetAllSector();
            dataGridView_Repo.DataSource = new RepositoryDAL().GetAllRepo();
            dataGridView_Staff.DataSource = new StaffDAL().getAllStaff();
            dataGridView_Maintain.DataSource = new MaintainanceDAL().GetAllMaintain();
            dataGridView_Order.DataSource = new OrderDAL().GetAllOrder();
            dataGridView_Customer.DataSource = new CustomerDAL().GetAllCustomer();
        }
        public void LoadSubForm(object sender, EventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            switch (ctrlName)
            {
                case "btn_addStaff":
                    StaffForm staffForm = new StaffForm {F = this};
                    staffForm.Show();
                    break;
                case "btn_addSector":
                    SectorForm sectorForm = new SectorForm {f = this};
                    sectorForm.Show();
                    break;
                case "btn_addRepo":
                    RepositoryForm RepoForm = new RepositoryForm {F = this};
                    RepoForm.Show();
                    break;
                case "btn_addMaintain":
                    MaintainForm MaintainForm = new MaintainForm {F = this};
                    MaintainForm.Show();
                    break;
                case "btn_add_maintain":
                    MaintainForm maintainForm = new MaintainForm {F = this};
                    maintainForm.Show();
                    break;
                case "btn_addOrder":
                    OrderForm orderForm = new OrderForm {F = this};
                    orderForm.Show();
                    break;
            }
                
        }
        public void LoadSubForm(object sender, DataGridViewCellEventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            switch (ctrlName)
            {
                case "dataGridView_Staff":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int staffId = int.Parse(dataGridView_Staff.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        StaffForm staffForm = new StaffForm
                        {
                            F = this, 
                            StaffId = staffId
                        };
                        staffForm.Show();
                    }
                    break;
                case "dataGridView_Repo":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int repoId = int.Parse(dataGridView_Repo.Rows[e.RowIndex].Cells["Repository ID"].Value.ToString());
                        RepositoryForm repo = new RepositoryForm
                        {
                            F = this, 
                            RepoId = repoId
                        };
                        repo.Show();
                    }
                    break;
                case "dataGridView_Sector":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int sectorId = int.Parse(dataGridView_Sector.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        SectorForm sectorForm = new SectorForm
                        {
                            f = this, 
                            SectorId = sectorId
                        };
                        sectorForm.Show();

                    }
                    break;
                case "dataGridView_Customer":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int cusId = int.Parse(dataGridView_Customer.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        CustomerForm customerForm = new CustomerForm
                        {
                            F = this,
                            CustomerId = cusId
                        };
                        customerForm.Show();
                    }
                    break;
                case "dataGridView_Order":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int orderId = int.Parse(dataGridView_Order.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        OrderForm orderForm = new OrderForm
                        {
                            F = this,
                            OrderId = orderId
                        };
                        orderForm.Show();
                    }
                    break;
            }
        }
        public void DeleteRecorde(object sender, DataGridViewCellEventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            switch (ctrlName)
            {
                case "dataGridView_Repo":
                    if (e.ColumnIndex == 0 && e.RowIndex > -1)
                    {
                        int RepoID = int.Parse(dataGridView_Repo.Rows[e.RowIndex].Cells["Repository ID"].Value.ToString());
                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Repository " + RepoID, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            new RepositoryDAL().DeleteRepo(RepoID);
                            ReloadData();
                        }
                    }
                    break;
                case "dataGridView_Staff":
                    if (e.ColumnIndex == 0 && e.RowIndex > -1)
                    {
                        int staffId = int.Parse(dataGridView_Staff.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Staff " + staffId, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            new StaffDAL().DeleteStaff(staffId);
                            ReloadData();
                        }
                    }
                    break;
                case "dataGridView_Sector":
                    if (e.ColumnIndex == 0 && e.RowIndex > -1)
                    {
                        int sectorId = int.Parse(dataGridView_Sector.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Sector " + sectorId, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            new SectorDAL().DeleteSector(sectorId);
                            ReloadData();
                        }
                    }
                    break;
            }
        }

        private void DeleteBelongedRepo()
        {
            throw new Exception("Not Implemented");
        }
        private void FilterInUseRepo()
        {
            try
            {
                dataGridView_Repo.DataSource = new RepositoryDAL().GetInUseRepo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilterFreeRepo(object sender, EventArgs e)
        {
            throw new Exception("Not Implemented");
        }

        private void FilterInMaintainRepo()
        {
            try
            {
                dataGridView_Repo.DataSource = new RepositoryDAL().GetInMaintainRepo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetNearDuedateOrder()
        {
            throw new Exception("Not Implemented");
        }

        private void GetOverDuedateOrder()
        {
            throw new Exception("Not Implemented");
        }

        private void CancelOrder()
        {
            throw new Exception("Not Implemented");
        }

        private void CheckCancelCondition()
        {
            throw new Exception("Not Implemented");
        }
        private void Login()
        {
            throw new Exception("Not Implemented");
        }

        private void filterRepository(object sender, EventArgs e)
        {
            dataGridView_Repo.DataSource = new RepositoryDAL().GetAllRepo();
            if (combo_Filter.SelectedIndex == 1)
            {
                FilterInUseRepo();
            }
            if (combo_Filter.SelectedIndex == 2)
            {
                FilterInMaintainRepo();
            }
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        } 
    }
}
