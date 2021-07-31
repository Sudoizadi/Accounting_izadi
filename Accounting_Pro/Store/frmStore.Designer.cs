
namespace Accounting_Pro
{
    partial class frmStore
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
            this.btn_AddProduct = new System.Windows.Forms.ToolStripButton();
            this.btn_edit = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_print = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.dg_Product = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddProduct,
            this.btn_edit,
            this.btn_delete,
            this.btn_print,
            this.btn_update});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(777, 62);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Image = global::Accounting_Pro.Properties.Resources._1371475930_filenew;
            this.btn_AddProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_AddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(87, 59);
            this.btn_AddProduct.Text = "افزودن محصول";
            this.btn_AddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
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
            // dg_Product
            // 
            this.dg_Product.AllowUserToAddRows = false;
            this.dg_Product.AllowUserToDeleteRows = false;
            this.dg_Product.AllowUserToResizeColumns = false;
            this.dg_Product.AllowUserToResizeRows = false;
            this.dg_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Amount,
            this.Column2});
            this.dg_Product.Location = new System.Drawing.Point(6, 40);
            this.dg_Product.Name = "dg_Product";
            this.dg_Product.ReadOnly = true;
            this.dg_Product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg_Product.RowHeadersVisible = false;
            this.dg_Product.Size = new System.Drawing.Size(741, 237);
            this.dg_Product.TabIndex = 4;
            this.dg_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Customer_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NameProducts";
            this.Column4.HeaderText = "نام کالا";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "AmountProducts";
            this.Amount.HeaderText = "قیمت کالا";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NumberProducts";
            this.Column2.HeaderText = "تعداد";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_Product);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(753, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست محصولا";
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_edit;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripButton btn_print;
        private System.Windows.Forms.ToolStripButton btn_update;
        private System.Windows.Forms.DataGridView dg_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btn_AddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}