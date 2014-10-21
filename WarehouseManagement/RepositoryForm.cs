using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
//
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class RepositoryForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm f { get; set; }
        public int RepoID { get; set; }
        public RepositoryForm()
        {
            InitializeComponent();
            
        }

        private void RepositoryForm_Load(object sender, EventArgs e)
        {
            DataTable data = new SectorDAL().getAllSector();
            comboBox_Sector.DataSource = data.DefaultView;
            comboBox_Sector.DisplayMember = "Name";
            comboBox_Sector.ValueMember = data.Columns["ID"].ToString();
            try
            {
                if (this.RepoID != 0)
                {
                    this.Text = "Repository ID: " + RepoID;
                    Repository repo = new RepositoryDAL().getOneRepo(this.RepoID);
                    comboBox_Sector.SelectedValue = repo.Sector.Id.ToString();
                    textBoxX1.Text = repo.Name;
                    richTextBox1.Text = repo.Desc;
                    textBoxX2.Text = repo.Price.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}