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
            reload();
        }

        public void reload()
        {
            dataGridView_Sectors.DataSource = new SectorDAL().getAllSector();
            dataGridView_Repo.DataSource = new RepositoryDAL().getAllRepo();
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            SectorForm sectorForm = new SectorForm();
            sectorForm.f = this;
            sectorForm.Show();
        }

        private void dataGridView_Sectors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            
            if (e.ColumnIndex != 0 && e.RowIndex > -1)
            {
                int SectorID = int.Parse(this.dataGridView_Sectors.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                SectorForm sectorForm = new SectorForm();
                sectorForm.f = this;
                sectorForm.SectorID = SectorID;
                sectorForm.Show();

            }
        }

        private void dataGridView_Sectors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                int SectorID = int.Parse(this.dataGridView_Sectors.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Section " + SectorID, MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new SectorDAL().deleteSector(SectorID);
                    this.reload();
                }
            }
        }

        private void button_add_Repo_Click(object sender, EventArgs e)
        {
            RepositoryForm repo = new RepositoryForm();
            repo.Show();
        }

        private void dataGridView_Repo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Repo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.RowIndex > -1)
            {
                int RepoID = int.Parse(this.dataGridView_Repo.Rows[e.RowIndex].Cells["Repository ID"].Value.ToString());
                RepositoryForm repo = new RepositoryForm();
                repo.f = this;
                repo.RepoID = RepoID;
                repo.Show();
            }
        }
    }
}
