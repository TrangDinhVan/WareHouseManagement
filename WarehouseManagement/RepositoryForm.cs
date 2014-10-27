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
            btn_add.Hide();
            btn_save.Hide();
            DataTable data_sector = new SectorDAL().getAllSector();
            field_sector.DataSource = data_sector.DefaultView;
            field_sector.DisplayMember = "Name";
            field_sector.ValueMember = data_sector.Columns["ID"].ToString();
            DataTable data_staff = new StaffDAL().getAllStaff();
            field_staff.DataSource = data_staff.DefaultView;
            field_staff.DisplayMember = "staff_name";
            field_staff.ValueMember = data_staff.Columns["staff_id"].ToString();
            field_volume.DataSource = new Repository().Volume_set;
            try
            {
                if (this.RepoID != 0)
                {
                    btn_save.Show();
                    this.Text = "Repository ID: " + RepoID;
                    Repository repo = new RepositoryDAL().getOneRepo(this.RepoID);
                    field_sector.SelectedValue = repo.Sector.Id.ToString();
                    field_staff.SelectedValue = repo.Staff.Id.ToString();
                    field_name.Text = repo.Name;
                    field_desc.Text = repo.Desc;
                    field_price.Text = repo.Price.ToString();
                    field_volume.Text = repo.Volume;
                }
                else
                {
                    this.Text = "Add new Repository";
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

        private void addRepo(object sender, EventArgs e)
        {
            try
            {
                Repository repo = getInfo();
                new RepositoryDAL().addRepo(repo);
                f.reloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.ToString());
            }
        }
        public void updateRepo(object sender, EventArgs e)
        {
            try
            {
                Repository repo = getInfo();
                new RepositoryDAL().updateRepo(repo);
                f.reloadData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.ToString());
            }
        }
        public Repository getInfo()
        {
            Repository repo = new Repository();
            repo.Id = RepoID;
            repo.Name = field_name.Text;
            repo.Desc = field_desc.Text;
            repo.Volume = field_volume.Text;
            repo.Price = double.Parse(field_price.Text.ToString());
            repo.Sector.Id = int.Parse(field_sector.SelectedValue.ToString());
            repo.Staff.Id = int.Parse(field_staff.SelectedValue.ToString());
            return repo;
        }
        
    }
}