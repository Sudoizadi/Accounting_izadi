
namespace Accounting_Pro
{
    partial class frm_Add_and_edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_and_edit));
            this.مشخصات = new System.Windows.Forms.GroupBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_selectpic = new System.Windows.Forms.Button();
            this.pic_person = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.مشخصات.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_person)).BeginInit();
            this.SuspendLayout();
            // 
            // مشخصات
            // 
            this.مشخصات.Controls.Add(this.txt_fullname);
            this.مشخصات.Controls.Add(this.txt_mobile);
            this.مشخصات.Controls.Add(this.txt_email);
            this.مشخصات.Controls.Add(this.txt_address);
            this.مشخصات.Controls.Add(this.label4);
            this.مشخصات.Controls.Add(this.label3);
            this.مشخصات.Controls.Add(this.label2);
            this.مشخصات.Controls.Add(this.label1);
            this.مشخصات.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.مشخصات.Location = new System.Drawing.Point(315, 22);
            this.مشخصات.Name = "مشخصات";
            this.مشخصات.Size = new System.Drawing.Size(281, 287);
            this.مشخصات.TabIndex = 0;
            this.مشخصات.TabStop = false;
            this.مشخصات.Text = "مشخصات";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(18, 25);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_fullname.Size = new System.Drawing.Size(193, 26);
            this.txt_fullname.TabIndex = 8;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(18, 76);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mobile.Size = new System.Drawing.Size(193, 26);
            this.txt_mobile.TabIndex = 6;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_mobile_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(18, 128);
            this.txt_email.Name = "txt_email";
            this.txt_email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_email.Size = new System.Drawing.Size(193, 26);
            this.txt_email.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(18, 186);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_address.Size = new System.Drawing.Size(193, 85);
            this.txt_address.TabIndex = 4;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(238, 186);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ادرس:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ایمیل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "موبایل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_selectpic);
            this.groupBox2.Controls.Add(this.pic_person);
            this.groupBox2.Location = new System.Drawing.Point(109, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر";
            // 
            // btn_selectpic
            // 
            this.btn_selectpic.Location = new System.Drawing.Point(7, 187);
            this.btn_selectpic.Name = "btn_selectpic";
            this.btn_selectpic.Size = new System.Drawing.Size(187, 84);
            this.btn_selectpic.TabIndex = 1;
            this.btn_selectpic.Text = "افزودن تصویر";
            this.btn_selectpic.UseVisualStyleBackColor = true;
            this.btn_selectpic.Click += new System.EventHandler(this.btn_selectpic_Click);
            // 
            // pic_person
            // 
            this.pic_person.Image = global::Accounting_Pro.Properties.Resources.no_profile_image;
            this.pic_person.Location = new System.Drawing.Point(6, 22);
            this.pic_person.Name = "pic_person";
            this.pic_person.Size = new System.Drawing.Size(188, 159);
            this.pic_person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_person.TabIndex = 0;
            this.pic_person.TabStop = false;
            this.pic_person.Click += new System.EventHandler(this.pic_person_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_submit.Location = new System.Drawing.Point(12, 22);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_submit.Size = new System.Drawing.Size(91, 287);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "ثبت";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txt_fullname;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام و نام خانوادگی خود را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txt_mobile;
            this.requiredFieldValidator2.ErrorMessage = "لطفا شماره تماس را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // frm_Add_and_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(608, 337);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.مشخصات);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_Add_and_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_Add_and_edit_Load);
            this.مشخصات.ResumeLayout(false);
            this.مشخصات.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_person)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox مشخصات;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.PictureBox pic_person;
        private System.Windows.Forms.Button btn_selectpic;
        private System.Windows.Forms.TextBox txt_fullname;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
    }
}