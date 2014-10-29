using System;
using System.Data;
using System.Windows.Forms;
//
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class MaintainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm F { get; set; }
        public RepositoryForm F1 { get; set; }
        public int MaintainId { get; set; }
        public MaintainForm()
        {
            InitializeComponent();
            field_start_date.MinDate = DateTime.Today;
            field_end_date.MinDate = field_start_date.Value.AddDays(1);
        }

        private void MaintainForm_Load(object sender, EventArgs e)
        {
            btn_add.Hide();
            btn_save.Hide();
            DataTable dataRepo = new RepositoryDAL().GetAllRepo();
            field_repo.DataSource = dataRepo.DefaultView;
            field_repo.DisplayMember = "Repository Name";
            field_repo.ValueMember = dataRepo.Columns["Repository ID"].ToString();
            if (MaintainId != 0)
            {
                Text = "Maintainance: " + MaintainId;
                btn_save.Show();
            }
            else
            {
                Text = "Add new Maintainance Schedule";
                btn_add.Show();
            }
        }
        private void add_Maintain(object sender, EventArgs e)
        {
            try
            {
                Maintainance maintain = GetInfo();
                maintain.CheckValidRange();
                new MaintainanceDAL().CreateMaintain(maintain);
                F.ReloadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex);
            }
        }
        private Maintainance GetInfo()
        {
            Maintainance maintain = new Maintainance
            {
                Id = MaintainId,
                Repo = new RepositoryDAL().GetOneRepo(int.Parse(field_repo.SelectedValue.ToString())),
                StartDate = field_start_date.Value.Date,
                EndDate = field_end_date.Value.Date,
                Desc = field_desc.Text,
                Price = Convert.ToDouble(field_price.Text)
            };
            return maintain;
        }

        private void ValidRange(object sender, EventArgs e)
        {
            field_end_date.MinDate = field_start_date.Value.AddDays(1);
            var diff = field_end_date.Value - field_start_date.Value;
            field_duration.Text = diff.TotalDays.ToString();
        }
    }
}