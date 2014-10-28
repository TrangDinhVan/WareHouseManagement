using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using WarehouseEntity;
using WarehouseDatabaseHelper;

namespace WarehouseManagement
{
    public partial class SectorForm : Form
    {
        public int SectorID;
        public MainForm f { get; set; }
        public SectorForm()
        {
            InitializeComponent();
        }
        private void SectorForm_Load(object sender, EventArgs e)
        {
            btn_add.Hide();
            btn_save.Hide();
            try
            {
                if (this.SectorID != 0)
                {
                    btn_save.Show();
                    this.Text = "Section ID: " + SectorID;
                    Sector sector = new SectorDAL().GetOneSection(this.SectorID);
                    field_name.Text = sector.Name;
                    field_desc.Text = sector.Desc;
                    dataGridView_Repo.DataSource = sector.LstRepo;
                }
                else
                {
                    this.Text = "Add new Sector";
                    btn_add.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void add_Sector(object sender, EventArgs e)
        {
            try
            {
                Sector sector = getInfo();
                new SectorDAL().AddSector(sector);
                f.ReloadData();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_Sector(object sender, EventArgs e)
        {
            try
            {
                Sector sector = getInfo();
                new SectorDAL().UpdateSector(sector);
                f.ReloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private Sector getInfo()
        {
            Sector sector = new Sector();
            sector.Id = this.SectorID;
            sector.Name = field_name.Text;
            sector.Desc = field_desc.Text;
            return sector;
        }
    }
}
