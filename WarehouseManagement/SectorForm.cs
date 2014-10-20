﻿using System;
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
            try
            {
                if (this.SectorID != 0)
                {
                    this.Text = "Section ID: " + SectorID;
                    Sector sector = new SectorDAL().getOneSection(this.SectorID);
                    textBox1.Text = sector.Name;
                    richTextBox1.Text = sector.Desc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button_addSector_Click(object sender, EventArgs e)
        {
            try
            {
                Sector sec = new Sector(textBox1.Text, richTextBox1.Text);
                new SectorDAL().insertSector(sec);
                f.reload();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_updateSector_Click(object sender, EventArgs e)
        {
            try
            {
                Sector sector = new Sector(this.SectorID, textBox1.Text, richTextBox1.Text);
                new SectorDAL().updateSector(sector);
                f.reload();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}