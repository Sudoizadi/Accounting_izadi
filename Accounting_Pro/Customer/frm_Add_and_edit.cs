using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting_Pro
{
    public partial class frm_Add_and_edit : Form
    {
        ICustomerRepository DB;
        public int IDCustomer = 0;
        public frm_Add_and_edit()
        {
            InitializeComponent();
            DB = new CustomerRepository();
        }

        private void btn_selectpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                pic_person.ImageLocation = openfile.FileName;

            }
        }

        private void pic_person_Click(object sender, EventArgs e)
        {

        }

       

        private void frm_Add_and_edit_Load(object sender, EventArgs e)
        {
            if (IDCustomer == 0)
                {
                    this.Text = "افزودن شخص";
                    
                }
                else
                {
                    this.Text = "ویرایش شخص";
                    this.btn_submit.Text = "ویرایش";
                var Customer_one = DB.GetById(IDCustomer,"Customer");
                txt_fullname.Text = Customer_one[0].FULLNAME;
                txt_mobile.Text = Customer_one[0].MOBILE;
                txt_email.Text = Customer_one[0].EMAIL;
                txt_address.Text = Customer_one[0].ADDRESS;
                pic_person.ImageLocation = Application.StartupPath+"/images/"+Customer_one[0].Image;
                
                }
        }

        

        private void btn_submit_Click(object sender, EventArgs e)
        {
            

            if (BaseValidator.IsFormValid(this.components))
            {
                string ImageName=Guid.NewGuid().ToString()+Path.GetExtension(pic_person.ImageLocation);
                string path = Application.StartupPath+"/images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                
                }
                pic_person.Image.Save(path+ImageName);
                Customer customer = new Customer()
                {
                    FULLNAME = txt_fullname.Text,
                    EMAIL = txt_email.Text,
                    MOBILE = txt_mobile.Text,
                    ADDRESS = txt_address.Text,
                    Image = ImageName
                };
                if (IDCustomer == 0)
                {
                    bool v = DB.Insert(customer);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    customer.ID = IDCustomer;
                    
                    DB.Update(customer);
                    DialogResult = DialogResult.OK;
                    
                }
               

            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
