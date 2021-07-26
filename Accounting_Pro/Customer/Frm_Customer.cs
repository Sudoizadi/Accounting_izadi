using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Pro
{
    public partial class Frm_Customer : Form
    {
        ICustomerRepository DB;
        public Frm_Customer()
        {
            InitializeComponent();
            DB = new CustomerRepository();

        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            Update_sql();
        }
        public void Update_sql()
        {


            dg_list_person.AutoGenerateColumns = false;
            dg_list_person.DataSource = DB.GetAll("Customer");



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_sql();

        }

        private void btn_add_person_Click(object sender, EventArgs e)
        {
            frm_Add_and_edit frm = new frm_Add_and_edit();
            
            if (frm.ShowDialog() == DialogResult.OK)
            {

                Update_sql();
            }
        }

        private void btn_edit_person_Click(object sender, EventArgs e)
        {
            if (dg_list_person.CurrentRow != null)
            {
                int ID = int.Parse(dg_list_person.CurrentRow.Cells[0].Value.ToString());

                frm_Add_and_edit frm = new frm_Add_and_edit();
                frm.IDCustomer = ID;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Update_sql();

                }
            }
        }

        private void btn_del_person_Click(object sender, EventArgs e)
        {
            if (dg_list_person.CurrentRow != null)

            {

                if (MessageBox.Show("ایا از حذف مطمعن هستید", "توجه ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

                {
                    int ID = int.Parse(dg_list_person.CurrentRow.Cells[0].Value.ToString());
                    DB.Delete(ID, "Customer");
                    Update_sql();

                }
                

            }
            else
            {
                MessageBox.Show("لطفا ردیف مورد نظر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_filters_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_filters_TextChanged(object sender, EventArgs e)
        {
            dg_list_person.AutoGenerateColumns = false;
            dg_list_person.DataSource = DB.Filters_Customer(txt_filters.Text);
        }
    }
}
