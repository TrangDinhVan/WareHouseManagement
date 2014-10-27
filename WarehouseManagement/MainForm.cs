using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            reloadData();
        }

        public void reloadData()
        {
            dataGridView_Sector.DataSource = new SectorDAL().getAllSector();
            dataGridView_Repo.DataSource = new RepositoryDAL().getAllRepo();
            dataGridView_Staff.DataSource = new StaffDAL().getAllStaff();
        }
        public void loadSubForm(object sender, EventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            switch (ctrlName)
            {
                case "btn_addStaff":
                    StaffForm staff_Form = new StaffForm();
                    staff_Form.f = this;
                    staff_Form.Show();
                    break;
                case "btn_addSector":
                    SectorForm sectorForm = new SectorForm();
                    sectorForm.f = this;
                    sectorForm.Show();
                    break;
                case "btn_addRepo":
                    RepositoryForm RepoForm = new RepositoryForm();
                    RepoForm.f = this;
                    RepoForm.Show();
                    break;
                default:
                    break;
            }
                
        }
        public void loadSubForm(object sender, DataGridViewCellEventArgs e)
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
                        StaffForm.f = this;
                        StaffForm.StaffID = StaffID;
                        StaffForm.Show();
                    }
                    break;
                case "dataGridView_Repo":
                    if (e.ColumnIndex != 0 && e.RowIndex > -1)
                    {
                        int RepoID = int.Parse(this.dataGridView_Repo.Rows[e.RowIndex].Cells["Repository ID"].Value.ToString());
                        RepositoryForm repo = new RepositoryForm();
                        repo.f = this;
                        repo.RepoID = RepoID;
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
        public void deleteRecorde(object sender, DataGridViewCellEventArgs e)
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
                            new RepositoryDAL().deleteRepo(RepoID);
                            this.reloadData();
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
                            new StaffDAL().deleteStaff(StaffID);
                            this.reloadData();
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
                            new SectorDAL().deleteSector(SectorID);
                            this.reloadData();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
