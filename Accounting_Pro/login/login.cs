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
    public partial class login : Form
    {
        public bool edit = false;
        ICustomerRepository DB;
        public login()
        {
            InitializeComponent();
            DB = new CustomerRepository();
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                btn_submit.Text = "ذخیره اطلاعات";
                this.Text = "ویرایش اطلاعات ورود";
                var res = DB.GetAll();
                txt_pass.Text = res[0].Password;
                txt_username.Text = res[0].UserName;
            
            }
            else
            {
                this.Text = "ورود به برنامه";
                btn_submit.Text = "ورود";

            
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (edit)
                {
                    Accounting.DataLayer.Repository.Login login = new Login() { 
                    UserName = txt_username.Text,
                    Password=txt_pass.Text,
                    LoginID = 1
                    
                    };
                    DB.Update(login);
                    Application.Restart();
                }
                else
                {
                    if (DB.GetAll().Where(c => c.UserName == txt_username.Text && c.Password == txt_pass.Text).Any())
                    {

                        DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        MessageBox.Show("اطلاعات وارد شده صحیح نمیباشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

               
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_pass.Select();
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_submit_Click(sender,e);
            }
        }
    }
}
