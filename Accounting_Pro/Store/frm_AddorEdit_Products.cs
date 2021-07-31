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

namespace Accounting_Pro.Store
{
    public partial class frm_AddorEdit_Products : Form
    {
        public int id = 0;
        ICustomerRepository db;
        public frm_AddorEdit_Products()
        {
            InitializeComponent();
            db = new CustomerRepository();
        }

        private void frm_AddorEdit_Products_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.Text = "افزودن محصول";
            }
            else
            {
                this.Text = "ویرایش محصولات";
                this.btn_submit.Text = "ویرایش";
                var res =db.GetProductsByID("GetByID",id);
                txt_AmountProducts.Value = res[0].AmountProducts;
                txt_ID.Value = res[0].ID;
                txt_NameProducts.Text = res[0].NameProducts;
                txt_numProducts.Value = res[0].NumberProducts;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                Accounting.DataLayer.Repository.Products products = new Accounting.DataLayer.Repository.Products()
                {

                    ID = (int)txt_ID.Value,
                    AmountProducts = (int)txt_AmountProducts.Value,
                    NumberProducts = (int)txt_numProducts.Value,
                    NameProducts = txt_NameProducts.Text
                
                };
                if (id == 0)
                {
                    products.Command = "Insert";
                    db.In_ED_DE(products);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    products.Command = "Update";
                    db.In_ED_DE(products);
                    DialogResult = DialogResult.OK;
                }
            
            }
        }
    }
}
