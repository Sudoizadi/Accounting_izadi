
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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_edit_login = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Customers = new System.Windows.Forms.ToolStripButton();
            this.btn_new_transaction = new System.Windows.Forms.ToolStripButton();
            this.btn_pay = new System.Windows.Forms.ToolStripButton();
            this.btn_recive = new System.Windows.Forms.ToolStripButton();
            this.btn_Store = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Remaining = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_recive = new System.Windows.Forms.Label();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btn_edit_login.Size = new System.Drawing.Size(178, 22);
            this.btn_edit_login.Text = "ویرایش اطلاعات ورود";
            this.btn_edit_login.Click += new System.EventHandler(this.btn_edit_login_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Customers,
            this.btn_new_transaction,
            this.btn_pay,
            this.btn_recive,
            this.btn_Store,
            this.btn_update});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(984, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
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
            this.btn_pay.Size = new System.Drawing.Size(53, 59);
            this.btn_pay.Text = "هزینه ها";
            this.btn_pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_recive
            // 
            this.btn_recive.Image = global::Accounting_Pro.Properties.Resources._1371476499_todo_list;
            this.btn_recive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_recive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_recive.Name = "btn_recive";
            this.btn_recive.Size = new System.Drawing.Size(51, 59);
            this.btn_recive.Text = "درامد ها";
            this.btn_recive.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_recive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recive.Click += new System.EventHandler(this.btn_recive_Click);
            // 
            // btn_Store
            // 
            this.btn_Store.Image = global::Accounting_Pro.Properties.Resources._1371476049_fork3;
            this.btn_Store.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Store.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(44, 59);
            this.btn_Store.Text = "انبار";
            this.btn_Store.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Store.Click += new System.EventHandler(this.btn_Store_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_date,
            this.lbl_timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Remaining);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbl_number);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_recive);
            this.groupBox2.Controls.Add(this.lbl_pay);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(698, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(274, 331);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "آمار  کل";
            // 
            // lbl_Remaining
            // 
            this.lbl_Remaining.AutoSize = true;
            this.lbl_Remaining.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining.Location = new System.Drawing.Point(67, 33);
            this.lbl_Remaining.Name = "lbl_Remaining";
            this.lbl_Remaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Remaining.Size = new System.Drawing.Size(0, 14);
            this.lbl_Remaining.TabIndex = 11;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(200, 33);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl.Size = new System.Drawing.Size(61, 14);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "مانده کل:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 83);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(127, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "تعداد اجناس در انبار:";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(67, 83);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_number.Size = new System.Drawing.Size(0, 14);
            this.lbl_number.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 178);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "خرید کل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 133);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "فروش کل:";
            // 
            // lbl_recive
            // 
            this.lbl_recive.AutoSize = true;
            this.lbl_recive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recive.Location = new System.Drawing.Point(67, 133);
            this.lbl_recive.Name = "lbl_recive";
            this.lbl_recive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_recive.Size = new System.Drawing.Size(0, 14);
            this.lbl_recive.TabIndex = 7;
            // 
            // lbl_pay
            // 
            this.lbl_pay.AutoSize = true;
            this.lbl_pay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pay.Location = new System.Drawing.Point(67, 178);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pay.Size = new System.Drawing.Size(0, 14);
            this.lbl_pay.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.Image = global::Accounting_Pro.Properties.Resources._1371476368_Synchronize;
            this.btn_update.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 59);
            this.btn_update.Text = "بروزرسانی";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 497);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_recive;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.Label lbl_Remaining;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ToolStripButton btn_Store;
        private System.Windows.Forms.ToolStripButton btn_update;
    }
}

