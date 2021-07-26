
namespace Accounting_Pro
{
    partial class frmReports
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_edit = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_print = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_todate = new System.Windows.Forms.MaskedTextBox();
            this.txt_fromdate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Customer = new System.Windows.Forms.ComboBox();
            this.btn_filters = new System.Windows.Forms.Button();
            this.dg_Customer = new System.Windows.Forms.DataGridView();
            this.print = new Stimulsoft.Report.StiReport();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit,
            this.btn_delete,
            this.btn_print,
            this.btn_update});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_edit
            // 
            this.btn_edit.Image = global::Accounting_Pro.Properties.Resources._1371475973_document_edit;
            this.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(47, 59);
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::Accounting_Pro.Properties.Resources._1371476007_Close_Box_Red;
            this.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(44, 59);
            this.btn_delete.Text = "حذف";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_print
            // 
            this.btn_print.Image = global::Accounting_Pro.Properties.Resources._1371476276_Print;
            this.btn_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(44, 59);
            this.btn_print.Text = "چاپ";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_todate);
            this.groupBox1.Controls.Add(this.txt_fromdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Customer);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(560, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // txt_todate
            // 
            this.txt_todate.Location = new System.Drawing.Point(6, 19);
            this.txt_todate.Mask = "0000/00/00";
            this.txt_todate.Name = "txt_todate";
            this.txt_todate.Size = new System.Drawing.Size(100, 20);
            this.txt_todate.TabIndex = 5;
            this.txt_todate.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fromdate
            // 
            this.txt_fromdate.Location = new System.Drawing.Point(182, 20);
            this.txt_fromdate.Mask = "0000/00/00";
            this.txt_fromdate.Name = "txt_fromdate";
            this.txt_fromdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_fromdate.Size = new System.Drawing.Size(100, 20);
            this.txt_fromdate.TabIndex = 4;
            this.txt_fromdate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "تا تاریخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب:";
            // 
            // cb_Customer
            // 
            this.cb_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Customer.FormattingEnabled = true;
            this.cb_Customer.Location = new System.Drawing.Point(346, 20);
            this.cb_Customer.Name = "cb_Customer";
            this.cb_Customer.Size = new System.Drawing.Size(121, 21);
            this.cb_Customer.TabIndex = 0;
            this.cb_Customer.SelectedIndexChanged += new System.EventHandler(this.cb_Customer_SelectedIndexChanged);
            // 
            // btn_filters
            // 
            this.btn_filters.Location = new System.Drawing.Point(12, 129);
            this.btn_filters.Name = "btn_filters";
            this.btn_filters.Size = new System.Drawing.Size(560, 23);
            this.btn_filters.TabIndex = 2;
            this.btn_filters.Text = "جستجو";
            this.btn_filters.UseVisualStyleBackColor = true;
            this.btn_filters.Click += new System.EventHandler(this.btn_filters_Click);
            // 
            // dg_Customer
            // 
            this.dg_Customer.AllowUserToAddRows = false;
            this.dg_Customer.AllowUserToDeleteRows = false;
            this.dg_Customer.AllowUserToResizeColumns = false;
            this.dg_Customer.AllowUserToResizeRows = false;
            this.dg_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Customer,
            this.Amount,
            this.Description,
            this.Time});
            this.dg_Customer.Location = new System.Drawing.Point(12, 158);
            this.dg_Customer.Name = "dg_Customer";
            this.dg_Customer.ReadOnly = true;
            this.dg_Customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg_Customer.RowHeadersVisible = false;
            this.dg_Customer.Size = new System.Drawing.Size(560, 191);
            this.dg_Customer.TabIndex = 3;
            // 
            // print
            // 
            this.print.CookieContainer = null;
            this.print.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.print.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.print.ReportAlias = "Report";
            this.print.ReportGuid = "391aa9d0e54d4716814e2b3043a42127";
            this.print.ReportName = "Report";
            this.print.ReportSource = null;
            this.print.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.print.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.print.UseProgressInThread = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "FULLNAME";
            this.Customer.HeaderText = "نام";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "شرح تراکنش";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "تاریخ";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dg_Customer);
            this.Controls.Add(this.btn_filters);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_edit;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripButton btn_print;
        private System.Windows.Forms.ToolStripButton btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_todate;
        private System.Windows.Forms.MaskedTextBox txt_fromdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Customer;
        private System.Windows.Forms.Button btn_filters;
        private System.Windows.Forms.DataGridView dg_Customer;
        private Stimulsoft.Report.StiReport print;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}