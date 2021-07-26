
namespace Accounting_Pro
{
    partial class Frm_Customer
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
            this.dg_list_person = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_ph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_add_person = new System.Windows.Forms.ToolStripButton();
            this.btn_edit_person = new System.Windows.Forms.ToolStripButton();
            this.btn_del_person = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_filters = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list_person)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_list_person
            // 
            this.dg_list_person.AllowUserToAddRows = false;
            this.dg_list_person.AllowUserToDeleteRows = false;
            this.dg_list_person.AllowUserToResizeColumns = false;
            this.dg_list_person.AllowUserToResizeRows = false;
            this.dg_list_person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_list_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_list_person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name_person,
            this.number_ph,
            this.email});
            this.dg_list_person.Location = new System.Drawing.Point(12, 81);
            this.dg_list_person.Name = "dg_list_person";
            this.dg_list_person.ReadOnly = true;
            this.dg_list_person.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg_list_person.RowHeadersVisible = false;
            this.dg_list_person.Size = new System.Drawing.Size(641, 318);
            this.dg_list_person.TabIndex = 0;
            // 
            // number
            // 
            this.number.DataPropertyName = "ID";
            this.number.HeaderText = "ردیف";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Visible = false;
            // 
            // name_person
            // 
            this.name_person.DataPropertyName = "FULLNAME";
            this.name_person.HeaderText = "نام شخص";
            this.name_person.Name = "name_person";
            this.name_person.ReadOnly = true;
            // 
            // number_ph
            // 
            this.number_ph.DataPropertyName = "MOBILE";
            this.number_ph.HeaderText = "شماره تماس";
            this.number_ph.Name = "number_ph";
            this.number_ph.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "EMAIL";
            this.email.HeaderText = "ایمیل";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_person,
            this.btn_edit_person,
            this.btn_del_person,
            this.btn_update,
            this.toolStripLabel1,
            this.txt_filters});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(665, 62);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_add_person
            // 
            this.btn_add_person.Image = global::Accounting_Pro.Properties.Resources._1371475930_filenew;
            this.btn_add_person.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_add_person.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add_person.Name = "btn_add_person";
            this.btn_add_person.Size = new System.Drawing.Size(106, 59);
            this.btn_add_person.Text = "افزودن شخص جدید";
            this.btn_add_person.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add_person.Click += new System.EventHandler(this.btn_add_person_Click);
            // 
            // btn_edit_person
            // 
            this.btn_edit_person.Image = global::Accounting_Pro.Properties.Resources._1371475973_document_edit;
            this.btn_edit_person.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_edit_person.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_edit_person.Name = "btn_edit_person";
            this.btn_edit_person.Size = new System.Drawing.Size(83, 59);
            this.btn_edit_person.Text = "ویرایش شخص";
            this.btn_edit_person.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_edit_person.Click += new System.EventHandler(this.btn_edit_person_Click);
            // 
            // btn_del_person
            // 
            this.btn_del_person.Image = global::Accounting_Pro.Properties.Resources._1371476007_Close_Box_Red;
            this.btn_del_person.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_del_person.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_del_person.Name = "btn_del_person";
            this.btn_del_person.Size = new System.Drawing.Size(72, 59);
            this.btn_del_person.Text = "حذف شخص";
            this.btn_del_person.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_del_person.Click += new System.EventHandler(this.btn_del_person_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = global::Accounting_Pro.Properties.Resources._1371476342_Refresh;
            this.btn_update.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 59);
            this.btn_update.Text = "بروزرسانی";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 59);
            this.toolStripLabel1.Text = "جستوجو:";
            // 
            // txt_filters
            // 
            this.txt_filters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_filters.Name = "txt_filters";
            this.txt_filters.Size = new System.Drawing.Size(100, 62);
            this.txt_filters.Click += new System.EventHandler(this.txt_filters_Click);
            this.txt_filters.TextChanged += new System.EventHandler(this.txt_filters_TextChanged);
            // 
            // Frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 403);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dg_list_person);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Frm_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Customer";
            this.Load += new System.EventHandler(this.Frm_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_list_person)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_edit_person;
        private System.Windows.Forms.ToolStripButton btn_del_person;
        private System.Windows.Forms.ToolStripButton btn_update;
        private System.Windows.Forms.DataGridView dg_list_person;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_filters;
        private System.Windows.Forms.ToolStripButton btn_add_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_ph;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}