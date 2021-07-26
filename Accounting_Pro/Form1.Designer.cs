
namespace Accounting_Pro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Customers = new System.Windows.Forms.ToolStripButton();
            this.btn_new_transaction = new System.Windows.Forms.ToolStripButton();
            this.btn_pay = new System.Windows.Forms.ToolStripButton();
            this.btn_recive = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_edit_login = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Customers,
            this.btn_new_transaction,
            this.btn_pay,
            this.btn_recive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(840, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_date,
            this.lbl_timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting_Pro.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Customers
            // 
            this.btn_Customers.Image = global::Accounting_Pro.Properties.Resources._1371476468_preferences_contact_list;
            this.btn_Customers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Customers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.Size = new System.Drawing.Size(85, 59);
            this.btn_Customers.Text = "طرف حساب ها";
            this.btn_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // btn_new_transaction
            // 
            this.btn_new_transaction.Image = global::Accounting_Pro.Properties.Resources._1370791030_credit_card;
            this.btn_new_transaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_new_transaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_new_transaction.Name = "btn_new_transaction";
            this.btn_new_transaction.Size = new System.Drawing.Size(72, 59);
            this.btn_new_transaction.Text = "تراکنش جدید";
            this.btn_new_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_new_transaction.Click += new System.EventHandler(this.btn_new_transaction_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Image = global::Accounting_Pro.Properties.Resources.servicesCosts;
            this.btn_pay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_pay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(60, 59);
            this.btn_pay.Text = "پرداخت ها";
            this.btn_pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_recive
            // 
            this.btn_recive.Image = global::Accounting_Pro.Properties.Resources._1371476499_todo_list;
            this.btn_recive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_recive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_recive.Name = "btn_recive";
            this.btn_recive.Size = new System.Drawing.Size(64, 59);
            this.btn_recive.Text = "دریافتی ها";
            this.btn_recive.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_recive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recive.Click += new System.EventHandler(this.btn_recive_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit_login});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click_1);
            // 
            // btn_edit_login
            // 
            this.btn_edit_login.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_login.Image = global::Accounting_Pro.Properties.Resources._1371475973_document_edit;
            this.btn_edit_login.Name = "btn_edit_login";
            this.btn_edit_login.Size = new System.Drawing.Size(180, 22);
            this.btn_edit_login.Text = "ویرایش اطلاعات ورود";
            this.btn_edit_login.Click += new System.EventHandler(this.btn_edit_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 446);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حساب داری زنبورستان ایزدی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Customers;
        private System.Windows.Forms.ToolStripButton btn_new_transaction;
        private System.Windows.Forms.ToolStripButton btn_pay;
        private System.Windows.Forms.ToolStripButton btn_recive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_date;
        private System.Windows.Forms.ToolStripStatusLabel lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_login;
    }
}

