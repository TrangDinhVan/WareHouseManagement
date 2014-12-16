using System;
using System.Data;
using System.Windows.Forms;
//
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class RepositoryForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm F { get; set; }
        public int RepoId { get; set; }
        public static string[] ReportChoiceSet = { "Maintainance Fact", "Order Fact" }; 
        public RepositoryForm()
        {
            InitializeComponent();
            report_choice.DataSource = ReportChoiceSet;
            btn_add.Hide();
            btn_save.Hide();
            DataTable dataSector = new SectorDAL().GetAllSector();
            field_sector.DataSource = dataSector.DefaultView;
            field_sector.DisplayMember = "Name";
            field_sector.ValueMember = dataSector.Columns["ID"].ToString();
            DataTable dataStaff = new StaffDAL().getAllStaff();
            field_staff.DataSource = dataStaff.DefaultView;
            field_staff.DisplayMember = "Name";
            field_staff.ValueMember = dataStaff.Columns["ID"].ToString();
            field_volume.DataSource = new Repository().VolumeSet;
        }

        private void RepositoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (RepoId != 0)
                {
                    ReportMaintaince();
                    btn_save.Show();
                    Text = "Repository ID: " + RepoId;
                    Repository repo = new RepositoryDAL().GetOneRepo(RepoId);
                    field_sector.SelectedValue = repo.Sector.Id.ToString();
                    field_staff.SelectedValue = repo.Staff.Id.ToString();
                    field_name.Text = repo.Name;
                    field_desc.Text = repo.Desc;
                    field_price.Text = repo.Price.ToString();
                    field_volume.Text = repo.Volume;
                }
                else
                {
                    Text = "Add new Repository";
                    btn_add.Show();
                    field_sector.Text = "";
                    field_staff.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddRepo(object sender, EventArgs e)
        {
            try
            {
                Repository repo = GetInfo();
                new RepositoryDAL().AddRepo(repo);
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex);
            }
        }
        public void UpdateRepo(object sender, EventArgs e)
        {
            try
            {
                Repository repo = GetInfo();
                new RepositoryDAL().UpdateRepo(repo);
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex);
            }
        }
        public Repository GetInfo()
        {
            Repository repo = new Repository
            {
                Id = RepoId,
                Name = field_name.Text,
                Desc = field_desc.Text,
                Volume = field_volume.Text,
                Price = double.Parse(field_price.Text),
                Sector = {Id = int.Parse(field_sector.SelectedValue.ToString())},
                Staff = {Id = int.Parse(field_staff.SelectedValue.ToString())}
            };
            new Validator().CheckValid(repo);
            return repo;
        }
        private void ReportMaintaince()
        {
            try
            {
                dataGridView_Report.DataSource = new MaintainanceDAL().GetSomeMaintain(string.Format("select * from [v_maintainance] where [Repo ID] = {0}", RepoId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex);
            }
            
        }

        private void ReportRenting()
        {
            try
            {
                dataGridView_Report.DataSource =
                    new OrderDAL().GetSomeOrder(
                        string.Format(
                            "select * from [v_order] where [ID] in (select order_id from [order_detail] where repo_id = {0})",
                            RepoId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex);
            }
        }

        private void FilterAvailableStaff()
        {
            throw new Exception("Not Implement");
        }

        private void AssignUndertakingStaff()
        {
            throw new Exception("Not Implement");
        }
        public void LoadSubForm(object sender, EventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            switch (ctrlName)
            {
                case "btn_add_maintain":
                    MaintainForm maintainForm = new MaintainForm {F1 = this};
                    maintainForm.Show();
                    break;
            }
        }

        private void ReportRepo(object sender, EventArgs e)
        {
            if (report_choice.SelectedIndex == 1)
            {
               ReportRenting();
            }
            else
            {
                ReportMaintaince();
            }
        }
        
    }
}