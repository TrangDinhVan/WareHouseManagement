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
    public partial class OrderForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int OrderId { get; set; }
        public MainForm F { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            field_volume.DataSource = new Repository().VolumeSet;
            dataGridView_Repo.DataSource = new RepositoryDAL().GetAllRepo();
        }
    }
}