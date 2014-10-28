using System;
using System.Windows.Forms;
//
using WarehouseDatabaseHelper;

namespace WarehouseManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        public void ReloadData()
        {
            dataGridView_Sector.DataSource = new SectorDAL().GetAllSector();
            dataGridView_Repo.DataSource = new RepositoryDAL().GetAllRepo();
            dataGridView_Staff.DataSource = new StaffDAL().getAllStaff();
            dataGridView_Maintain.DataSource = new MaintainanceDAL().getAllMaintain();
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
                    RepositoryForm RepoForm = new RepositoryForm {f = this};
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
                default:
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
                        int StaffID = int.Parse(this.dataGridView_Staff.Rows[e.RowIndex].Cells["staff_id"].Value.ToString());
                        RepositoryForm repo = new RepositoryForm();
                        StaffForm StaffForm = new StaffForm();
                        StaffForm.F = this;
                        StaffForm.StaffId = StaffID;
                        StaffForm.Show();
                    }
                    break;
                case "dataGridView_Repo":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int RepoID = int.Parse(this.dataGridView_Repo.Rows[e.RowIndex].Cells["Repository ID"].Value.ToString());
                        RepositoryForm repo = new RepositoryForm();
                        repo.f = this;
                        repo.RepoId = RepoID;
                        repo.Show();
                    }
                    break;
                case "dataGridView_Sector":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int SectorID = int.Parse(this.dataGridView_Sector.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        SectorForm sectorForm = new SectorForm();
                        sectorForm.f = this;
                        sectorForm.SectorID = SectorID;
                        sectorForm.Show();

                    }
                    break;
                default:
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
                        int RepoID = int.Parse(this.dataGridView_Repo.Rows[e.RowIndex].Cells["Repository ID"].Value.ToString());
                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Repository " + RepoID, MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            new RepositoryDAL().DeleteRepo(RepoID);
                            this.ReloadData();
                        }
                    }
                    break;
                case "dataGridView_Staff":
                    if (e.ColumnIndex == 0 && e.RowIndex > -1)
                    {
                        int StaffID = int.Parse(this.dataGridView_Staff.Rows[e.RowIndex].Cells["staff_id"].Value.ToString());
                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Staff " + StaffID, MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            new StaffDAL().DeleteStaff(StaffID);
                            this.ReloadData();
                        }
                    }
                    break;
                case "dataGridView_Sector":
                    if (e.ColumnIndex == 0 && e.RowIndex > -1)
                    {
                        int SectorID = int.Parse(this.dataGridView_Sector.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Sector " + SectorID, MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            new SectorDAL().DeleteSector(SectorID);
                            this.ReloadData();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
