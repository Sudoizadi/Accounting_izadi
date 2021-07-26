using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using Accounting.Utility;
using Accounting.ViewModels;
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
    public partial class frmReports : Form
    {
        ICustomerRepository db;
        public int TypeID = 0;
        public frmReports()
        {
            InitializeComponent();
            db = new CustomerRepository();
        }

        private void btn_filters_Click(object sender, EventArgs e)
        {
            filters();
        }

        void filters()
        {
            List<Accounting.DataLayer.Repository.Accounting> res = new List<Accounting.DataLayer.Repository.Accounting>();
            DateTime? startdate;
            DateTime? enddate;
            

            if ((int)cb_Customer.SelectedValue != 0)
            {

                int Customerid = int.Parse(cb_Customer.SelectedValue.ToString());
                res.AddRange(db.GetAccounting(TypeID).Where(c => c.CustomerID == Customerid));
            }
            else
            {
                res.AddRange(db.GetAccounting(TypeID));

            }
            if (txt_fromdate.Text != "    /  /")
            {
                startdate = Convert.ToDateTime(txt_fromdate.Text.ToString());
                startdate = Convertor.ToMiladi(startdate.Value);
                res = res.Where(C => C.Time >= startdate.Value).ToList();
            }
            if (txt_todate.Text != "    /  /")
            {
                enddate = Convert.ToDateTime(txt_todate.Text);
                enddate = Convertor.ToMiladi(enddate.Value);
                res = res.Where(C => C.Time <= enddate.Value).ToList();

            }

            dg_Customer.AutoGenerateColumns = false;
            dg_Customer.Rows.Clear();
            foreach (var accounting in res)
            {
                string customerName = db.GetName_fromID(accounting.CustomerID);
                dg_Customer.Rows.Add(accounting.ID, customerName, accounting.Amount,accounting.Time.ToShamsi(),accounting.Description);
            }
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            List<ViewModel_GetName> list = new List<ViewModel_GetName>();
            list.Add(new ViewModel_GetName()
            {
                ID = 0,
                FULLNAME = "انتخاب کنید"

            });
            list.AddRange(db.Filters_Name());
            cb_Customer.DataSource = list;
            cb_Customer.DisplayMember = "FULLNAME";
            cb_Customer.ValueMember = "ID";

            if (TypeID == 1)
            {
                this.Text = "دریافتی ها";
            }
            else
            {

                this.Text = "پرداختی ها";

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_Customer.CurrentRow != null)
            {

                int id = int.Parse(dg_Customer.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("ایا از حذف خود مطمعن هستید؟؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Delete(id, "Accounting");
                    filters();
                }
            }
            else
            {


                MessageBox.Show("لطفا مشتری مورد نظر برای حذف کردن را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            filters();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dg_Customer.CurrentRow != null)
            {

                int id = int.Parse(dg_Customer.CurrentRow.Cells[0].Value.ToString());
                frm_transaction frm_Transaction = new frm_transaction();
                frm_Transaction.ID = id;
                if (frm_Transaction.ShowDialog() == DialogResult.OK)
                {
                    filters();

                }

            }
            else
            {
                MessageBox.Show("لطفا مقدار مورد نظر برای ویرایش را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cb_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Description");
            dt.Columns.Add("Time");
            foreach (DataGridViewRow add in dg_Customer.Rows)
            {

                dt.Rows.Add(
                    add.Cells[1].Value.ToString(),
                    add.Cells[2].Value.ToString(),
                    add.Cells[4].Value.ToString(),
                    add.Cells[3].Value.ToString()
                    );
            
            }
            print.Load(Application.StartupPath+"/Report.mrt");
            print.RegData("DT", dt);

            print.Print();
            
        }
    }
}
