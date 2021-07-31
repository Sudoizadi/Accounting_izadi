using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using Accounting_Pro.Store;
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
    public partial class frmStore : Form
    {
        ICustomerRepository db;
        public frmStore()
        {
            InitializeComponent();
            db = new CustomerRepository();
        }

        private void dg_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            update();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update();
        }

        void update()
        {

            dg_Product.AutoGenerateColumns = false;
            dg_Product.DataSource = db.GetProducts("Select");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_Product.CurrentRow.Cells != null)
            {
                int id = int.Parse(dg_Product.CurrentRow.Cells[0].Value.ToString());
                Products products = new Products()
                {
                    ID = id,
                    Command = "Delete"

                };
                if (MessageBox.Show("ایا از حذف خود مطمعن هستید؟؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.In_ED_DE(products);
                    update();
                }



            }
            else
            {
                MessageBox.Show("لطفا محصول مورد نظر برای حذف را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddorEdit_Products frm = new frm_AddorEdit_Products();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                update();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dg_Product.CurrentRow != null)
            {


                frm_AddorEdit_Products frm = new frm_AddorEdit_Products();
                frm.id = int.Parse(dg_Product.CurrentRow.Cells[0].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    update();
                }
            }
            else
            {
                MessageBox.Show("لطفا مقدار مورد نظر برای ویرایش را انخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
