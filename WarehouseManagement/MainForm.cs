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
    }
}
