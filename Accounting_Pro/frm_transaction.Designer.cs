
namespace Accounting_Pro
{
    partial class frm_transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_transaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_searcher = new System.Windows.Forms.TextBox();
            this.dg_person = new System.Windows.Forms.DataGridView();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.rb_Received = new System.Windows.Forms.RadioButton();
            this.rb_pay = new System.Windows.Forms.RadioButton();
            this.txt_pay = new System.Windows.Forms.NumericUpDown();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_person = new System.Windows.Forms.TextBox();
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.rvalid = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_searcher);
            this.groupBox1.Controls.Add(this.dg_person);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "جستجو:";
            // 
            // txt_searcher
            // 
            this.txt_searcher.Location = new System.Drawing.Point(6, 20);
            this.txt_searcher.Name = "txt_searcher";
            this.txt_searcher.Size = new System.Drawing.Size(159, 20);
            this.txt_searcher.TabIndex = 10;
            this.txt_searcher.TextChanged += new System.EventHandler(this.txt_searcher_TextChanged);
            // 
            // dg_person
            // 
            this.dg_person.AllowUserToAddRows = false;
            this.dg_person.AllowUserToDeleteRows = false;
            this.dg_person.AllowUserToResizeColumns = false;
            this.dg_person.AllowUserToResizeRows = false;
            this.dg_person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_person.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_person.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullname});
            this.dg_person.GridColor = System.Drawing.Color.Black;
            this.dg_person.Location = new System.Drawing.Point(6, 46);
            this.dg_person.Name = "dg_person";
            this.dg_person.ReadOnly = true;
            this.dg_person.RowHeadersVisible = false;
            this.dg_person.Size = new System.Drawing.Size(223, 327);
            this.dg_person.TabIndex = 0;
            this.dg_person.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_person_CellClick);
            this.dg_person.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_person_CellContentClick);
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "FULLNAME";
            this.fullname.HeaderText = "نام";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "نوع تراکنش:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(601, 134);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(39, 16);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "شرح:";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Received
            // 
            this.rb_Received.AutoSize = true;
            this.rb_Received.Location = new System.Drawing.Point(504, 58);
            this.rb_Received.Name = "rb_Received";
            this.rb_Received.Size = new System.Drawing.Size(63, 17);
            this.rb_Received.TabIndex = 6;
            this.rb_Received.TabStop = true;
            this.rb_Received.Text = "دریافتی";
            this.rb_Received.UseVisualStyleBackColor = true;
            this.rb_Received.CheckedChanged += new System.EventHandler(this.rb_Received_CheckedChanged);
            // 
            // rb_pay
            // 
            this.rb_pay.AutoSize = true;
            this.rb_pay.Location = new System.Drawing.Point(422, 58);
            this.rb_pay.Name = "rb_pay";
            this.rb_pay.Size = new System.Drawing.Size(63, 17);
            this.rb_pay.TabIndex = 7;
            this.rb_pay.TabStop = true;
            this.rb_pay.Text = "پرداختی";
            this.rb_pay.UseVisualStyleBackColor = true;
            this.rb_pay.CheckedChanged += new System.EventHandler(this.rb_pay_CheckedChanged);
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(253, 97);
            this.txt_pay.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(314, 20);
            this.txt_pay.TabIndex = 8;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(253, 147);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(314, 212);
            this.txt_Description.TabIndex = 9;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(253, 366);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(314, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "ثبت";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_person
            // 
            this.txt_person.Location = new System.Drawing.Point(253, 17);
            this.txt_person.Name = "txt_person";
            this.txt_person.ReadOnly = true;
            this.txt_person.Size = new System.Drawing.Size(314, 20);
            this.txt_person.TabIndex = 11;
            // 
            // dg_product
            // 
            this.dg_product.AllowUserToAddRows = false;
            this.dg_product.AllowUserToDeleteRows = false;
            this.dg_product.AllowUserToResizeColumns = false;
            this.dg_product.AllowUserToResizeRows = false;
            this.dg_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dg_product.Location = new System.Drawing.Point(253, 208);
            this.dg_product.Name = "dg_product";
            this.dg_product.ReadOnly = true;
            this.dg_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_product.RowHeadersVisible = false;
            this.dg_product.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dg_product.Size = new System.Drawing.Size(314, 151);
            this.dg_product.TabIndex = 12;
            this.dg_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NameProducts";
            this.Column1.HeaderText = "نام محصول";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(253, 147);
            this.txt_product.Name = "txt_product";
            this.txt_product.ReadOnly = true;
            this.txt_product.Size = new System.Drawing.Size(314, 20);
            this.txt_product.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "مبلغ:";
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txt_pay;
            this.rangeValidator1.ErrorMessage = "لطفا مبلغ را وارد کنید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "99999999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // rvalid
            // 
            this.rvalid.CancelFocusChangeWhenInvalid = false;
            this.rvalid.ControlToValidate = this.txt_Description;
            this.rvalid.ErrorMessage = "لطفا شرح  دریافت | پرداخت را وارد کنید";
            this.rvalid.Icon = ((System.Drawing.Icon)(resources.GetObject("rvalid.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txt_person;
            this.requiredFieldValidator2.ErrorMessage = "لطفا از نام طرف حساب را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // frm_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.dg_product);
            this.Controls.Add(this.txt_person);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.rb_pay);
            this.Controls.Add(this.rb_Received);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_transaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_transaction";
            this.Load += new System.EventHandler(this.frm_transaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_searcher;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.RadioButton rb_Received;
        private System.Windows.Forms.RadioButton rb_pay;
        private System.Windows.Forms.NumericUpDown txt_pay;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_person;
        private System.Windows.Forms.Label label5;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator rvalid;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}