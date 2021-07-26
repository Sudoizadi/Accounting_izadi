﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repository;
using Accounting.Utility;

namespace Accounting_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                lbl_date.Text = DateTime.Now.ToShamsi();
                lbl_timer.Text = DateTime.Now.ToString("HH:mm:ss");
                this.Show();
            }
            else
            {

                Application.Exit();
            }


        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            Frm_Customer frm = new Frm_Customer();
            frm.ShowDialog();
        }

        private void btn_new_transaction_Click(object sender, EventArgs e)
        {
            frm_transaction frm = new frm_transaction();
            frm.ShowDialog();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.TypeID = 2;
            frmReports.ShowDialog();
        }

        private void btn_recive_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.TypeID = 1;
            frmReports.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

       

        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_edit_login_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.edit = true;
            login.ShowDialog();
        }
    }
}
