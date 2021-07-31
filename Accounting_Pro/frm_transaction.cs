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
        public int typeid = 0;
        public int ID = 0;
        public frm_transaction()
        {
            InitializeComponent();
            db = new CustomerRepository();
        }

        private void frm_transaction_Load(object sender, EventArgs e)
        {
            dg_product.Visible = false;
            txt_Description.Visible = false;
            lbl_Description.Visible = false;
            txt_product.Visible = false;
            dg_person.AutoGenerateColumns = false;
            dg_product.AutoGenerateColumns = false;
            dg_person.DataSource = db.Filters_Name();
            if (ID != 0)
            {
                if (typeid == 1)

                {
                    this.Text = "ویرایش اطلاعات دریافتی ها";
                    var res = db.GetById(ID);
                    rb_Received.Checked = true;
                    rb_pay.Visible = false;
                    btn_submit.Text = "ویرایش";
                    txt_person.Text = db.GetName_fromID(res[0].CustomerID);
                    txt_product.Text = res[0].Description;
                    txt_pay.Text = res[0].Amount.ToString();
                }
                if (typeid == 2)
                {
                    this.Text = "ویرایش اطلاعات  پرداختی ها";
                    var res = db.GetById(ID);
                    rb_pay.Checked = true;
                    rb_Received.Visible = false;
                    btn_submit.Text = "ویرایش";
                    txt_person.Text = db.GetName_fromID(res[0].CustomerID);
                    txt_Description.Text = res[0].Description;
                    txt_pay.Text = res[0].Amount.ToString();

                }
                //this.Text = "ویرایش اطلاعات";
                //var res = db.GetById(ID);
                //btn_submit.Text = "ویرایش";
                //txt_person.Text = db.GetName_fromID(res[0].CustomerID);
                //txt_Description.Text = res[0].Description;
                //txt_pay.Text = res[0].Amount.ToString();
                //if (res[0].TypeID == 1)
                //{
                //    rb_Received.Checked = true;
                //}
                //else
                //{
                //    rb_pay.Checked = true;

                //}


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
                    Time = DateTime.Now

                };
                if (ID == 0)
                {

                    if (rb_pay.Checked)
                    {
                        accounting.TypeID = 2;
                        accounting.Description = txt_Description.Text;
                        db.Insert(accounting);
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        accounting.TypeID = 1;
                        accounting.Description = txt_product.Text;
                        db.Insert(accounting);
                        DialogResult = DialogResult.OK;

                    }


                }
                else
                {

                    if (typeid == 1)
                    {
                        accounting.TypeID = 1;
                        accounting.ID = ID;
                        accounting.Description = txt_product.Text;
                        db.Update(accounting);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        accounting.TypeID = 2;
                        accounting.ID = ID;
                        accounting.Description = txt_Description.Text;
                        db.Update(accounting);
                        DialogResult = DialogResult.OK;
                    }


                }

                //if (ID != 0)
                //{
                //    accounting.ID = ID;
                //    db.Update(accounting);
                //   

                //}
                //else
                //{
                //    if (rb_pay.Checked || rb_Received.Checked)
                //    {


                //        db.Insert(accounting);
                //       
                //    }
                //    else
                //    {

                //        MessageBox.Show("لطفا نوع تراکنش را وارد کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void rb_Received_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Description.Visible = true;
            rvalid.ErrorMessage = "لطفا نام محصول را از لیست زیر وارد کنید";
            rvalid.ControlToValidate = txt_product;
            lbl_Description.Text = "عنوان کالا:";
            txt_product.Visible = true;
            dg_product.Visible = true;
            dg_product.DataSource = db.GetProducts("Filters_Name");
            //dg_product.AutoGenerateColumns = false;

            txt_Description.Visible = false;

        }

        private void rb_pay_CheckedChanged(object sender, EventArgs e)
        {
            rvalid.ErrorMessage = "لطفا شرح هزینه را وارد کنید";
            rvalid.ControlToValidate = txt_Description;
            lbl_Description.Visible = true;
            lbl_Description.Text = "شرح:";
            txt_product.Visible = false;
            dg_product.Visible = false;

            txt_Description.Visible = true;

        }



        private void dg_person_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_product.Text = dg_product.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
