
namespace Accounting_Pro.Store
{
    partial class frm_AddorEdit_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddorEdit_Products));
            this.txt_AmountProducts = new System.Windows.Forms.NumericUpDown();
            this.txt_numProducts = new System.Windows.Forms.NumericUpDown();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.NumericUpDown();
            this.txt_NameProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.rangeValidator2 = new ValidationComponents.RangeValidator(this.components);
            this.rangeValidator3 = new ValidationComponents.RangeValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_AmountProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AmountProducts
            // 
            this.txt_AmountProducts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AmountProducts.Location = new System.Drawing.Point(12, 71);
            this.txt_AmountProducts.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txt_AmountProducts.Name = "txt_AmountProducts";
            this.txt_AmountProducts.Size = new System.Drawing.Size(120, 22);
            this.txt_AmountProducts.TabIndex = 17;
            // 
            // txt_numProducts
            // 
            this.txt_numProducts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numProducts.Location = new System.Drawing.Point(12, 18);
            this.txt_numProducts.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txt_numProducts.Name = "txt_numProducts";
            this.txt_numProducts.Size = new System.Drawing.Size(120, 22);
            this.txt_numProducts.TabIndex = 16;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(12, 119);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(472, 23);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "ثبت";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 73);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "قیمت واحد محصول:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 21);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "تعداد محصول:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام محصول:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(286, 18);
            this.txt_ID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(120, 22);
            this.txt_ID.TabIndex = 11;
            // 
            // txt_NameProducts
            // 
            this.txt_NameProducts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameProducts.Location = new System.Drawing.Point(286, 70);
            this.txt_NameProducts.Name = "txt_NameProducts";
            this.txt_NameProducts.Size = new System.Drawing.Size(120, 22);
            this.txt_NameProducts.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "کد محصول:";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txt_NameProducts;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام محصول را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txt_ID;
            this.rangeValidator1.ErrorMessage = "لطفا کد محصول را وارد کنید(عددی بجز صفر)";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "10000";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // rangeValidator2
            // 
            this.rangeValidator2.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator2.ControlToValidate = this.txt_AmountProducts;
            this.rangeValidator2.ErrorMessage = "لطفا قیمت محصول را وارد کنید";
            this.rangeValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator2.Icon")));
            this.rangeValidator2.MaximumValue = "1000000000000";
            this.rangeValidator2.MinimumValue = "1";
            this.rangeValidator2.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // rangeValidator3
            // 
            this.rangeValidator3.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator3.ControlToValidate = this.txt_numProducts;
            this.rangeValidator3.ErrorMessage = "لطفا تعداد محصولات را وارد کنید";
            this.rangeValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator3.Icon")));
            this.rangeValidator3.MaximumValue = "100000000000";
            this.rangeValidator3.MinimumValue = "0";
            this.rangeValidator3.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // frm_AddorEdit_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 158);
            this.Controls.Add(this.txt_AmountProducts);
            this.Controls.Add(this.txt_numProducts);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_NameProducts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_AddorEdit_Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_AddorEdit_Products";
            this.Load += new System.EventHandler(this.frm_AddorEdit_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_AmountProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txt_AmountProducts;
        private System.Windows.Forms.NumericUpDown txt_numProducts;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_ID;
        private System.Windows.Forms.TextBox txt_NameProducts;
        private System.Windows.Forms.Label label1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RangeValidator rangeValidator2;
        private ValidationComponents.RangeValidator rangeValidator3;
    }
}