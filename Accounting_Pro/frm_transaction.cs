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
using ValidationComponents;

namespace Accounting_Pro
{
    public partial class frm_transaction : Form
    {
        ICustomerRepository db;
        public int ID = 0;
        public frm_transaction()
        {
            InitializeComponent();
            db = new CustomerRepository();
        }

        private void frm_transaction_Load(object sender, EventArgs e)
        {
            dg_person.AutoGenerateColumns = false;
            dg_person.DataSource = db.Filters_Name();
            if (ID != 0)
            {

                this.Text = "ویرایش اطلاعات";
                var res = db.GetById(ID);
                btn_submit.Text = "ویرایش";
                txt_person.Text = db.GetName_fromID(res[0].CustomerID); 
                txt_Description.Text = res[0].Description; 
                txt_pay.Text = res[0].Amount.ToString();
                if (res[0].TypeID == 1)
                {
                    rb_Received.Checked = true;
                }
                else
                {
                    rb_pay.Checked = true;
                
                }
                
                
            }
            else
            {
                this.Text = "افزودن اطلاعات";

            }
        }

        private void txt_person_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_person_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_person.Text = dg_person.CurrentRow.Cells[0].Value.ToString();
        }

        private void txt_searcher_TextChanged(object sender, EventArgs e)
        {
            dg_person.AutoGenerateColumns = false;
            dg_person.DataSource = db.Filters_Name(txt_searcher.Text);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                Accounting.DataLayer.Repository.Accounting accounting = new Accounting.DataLayer.Repository.Accounting()
                {
                    Amount = int.Parse(txt_pay.Value.ToString()),
                    CustomerID = db.GetIDByName(txt_person.Text),
                    Description = txt_Description.Text,
                    Time = DateTime.Now,
                    TypeID = (rb_pay.Checked) ? 2 : 1
                };
                if (ID != 0)
                {
                    accounting.ID = ID;
                    db.Update(accounting);
                    DialogResult = DialogResult.OK;
                
                }
                else
                {
                    if (rb_pay.Checked || rb_Received.Checked)
                    {
                        

                        db.Insert(accounting);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        MessageBox.Show("لطفا نوع تراکنش را وارد کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }
        }
    }
}
