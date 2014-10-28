using System;
using System.Windows.Forms;
//
using WarehouseEntity;
using WarehouseDatabaseHelper;

namespace WarehouseManagement
{
    public partial class SectorForm : Form
    {
        public int SectorId;
        public MainForm f { get; set; }
        public SectorForm()
        {
            InitializeComponent();
            btn_add.Hide();
            btn_save.Hide();
        }
        private void SectorForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (SectorId != 0)
                {
                    btn_save.Show();
                    Text = "Section ID: " + SectorId;
                    Sector sector = new SectorDAL().GetOneSection(this.SectorId);
                    field_name.Text = sector.Name;
                    field_desc.Text = sector.Desc;
                    dataGridView_Repo.DataSource = sector.LstRepo;
                }
                else
                {
                    Text = "Add new Sector";
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
                Sector sector = GetInfo();
                new SectorDAL().AddSector(sector);
                f.ReloadData();
                Close();
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
                Sector sector = GetInfo();
                new SectorDAL().UpdateSector(sector);
                f.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private Sector GetInfo()
        {
            Sector sector = new Sector {Id = SectorId, Name = field_name.Text, Desc = field_desc.Text};
            new Validator().CheckValid(sector);
            return sector;
        }
    }
}
