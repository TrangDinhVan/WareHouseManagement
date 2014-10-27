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
        public MainForm f { get; set; }
        public int RepoId { get; set; }
        public static string[] ReportChoiceSet = { "Maintainance Fact", "Order Fact" }; 
        public RepositoryForm()
        {
            InitializeComponent();
            report_choice.DataSource = ReportChoiceSet;
        }

        private void RepositoryForm_Load(object sender, EventArgs e)
        {
            btn_add.Hide();
            btn_save.Hide();
            DataTable dataSector = new SectorDAL().getAllSector();
            field_sector.DataSource = dataSector.DefaultView;
            field_sector.DisplayMember = "Name";
            field_sector.ValueMember = dataSector.Columns["ID"].ToString();
            DataTable dataStaff = new StaffDAL().getAllStaff();
            field_staff.DataSource = dataStaff.DefaultView;
            field_staff.DisplayMember = "staff_name";
            field_staff.ValueMember = dataStaff.Columns["staff_id"].ToString();
            field_volume.DataSource = new Repository().VolumeSet;
            try
            {
                if (RepoId != 0)
                {
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
                f.ReloadData();
                this.Close();
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
                f.ReloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.ToString());
            }
        }
        public Repository GetInfo()
        {
            Repository repo = new Repository();
            repo.Id = RepoId;
            repo.Name = field_name.Text;
            repo.Desc = field_desc.Text;
            repo.Volume = field_volume.Text;
            repo.Price = double.Parse(field_price.Text.ToString());
            repo.Sector.Id = int.Parse(field_sector.SelectedValue.ToString());
            repo.Staff.Id = int.Parse(field_staff.SelectedValue.ToString());
            return repo;
        }
        private void ReportMaintaince()
        {
            try
            {
                DataTable maintain_report = new MaintainanceDAL().getSomeMaintain(string.Format("select * from [maintainance] where repo_id = {0}", RepoId));
                this.dataGridView_Report.DataSource = maintain_report;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex);
            }
            
        }
        public void LoadSubForm(object sender, EventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            switch (ctrlName)
            {
                case "btn_add_maintain":
                    MaintainForm maintainForm = new MaintainForm();
                    maintainForm.f1 = this;
                    maintainForm.Show();
                    break;
            }
        }
        
    }
}