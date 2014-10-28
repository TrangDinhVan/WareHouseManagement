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
                        RepositoryForm repo = new RepositoryForm();
                        repo.f = this;
                        repo.RepoId = repoId;
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
    }
}
