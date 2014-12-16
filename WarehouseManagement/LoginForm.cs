using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WarehouseDatabaseHelper;
using WarehouseEntity;

namespace WarehouseManagement
{
    public partial class LoginForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm F;
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = Convert.ToChar("\u25CF");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            F = new MainForm();
        }

        private void Login(object sender, EventArgs e)
        {
            bool success = false;
            Staff s = new Staff
            {
                Name = textBox1.Text,
                Pass = textBox2.Text
            };
            DataTable staff_set = new StaffDAL().GetSomeStaff("select * from staff");
            foreach (DataRow r in staff_set.Rows)
            {
                if (Equals(r["staff_name"], s.Name) && Equals(r["staff_pass"], s.Pass))
                {
                    success = true;
                    s.Permission = r["staff_permission"].ToString();
                    F.LogginedStaff = s;
                    MessageBox.Show("Success!");
                    F.Show();
                    Hide();
                    break;
                }
            }
            if(!success)
                MessageBox.Show("Account or password is not correct!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}