
namespace src
{
    partial class frmManageProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateRemoveProduct = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(17, 452);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(251, 81);
            this.btn_AddProduct.TabIndex = 1;
            this.btn_AddProduct.Text = "Add product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_UpdateRemoveProduct
            // 
            this.btn_UpdateRemoveProduct.Location = new System.Drawing.Point(452, 452);
            this.btn_UpdateRemoveProduct.Name = "btn_UpdateRemoveProduct";
            this.btn_UpdateRemoveProduct.Size = new System.Drawing.Size(251, 81);
            this.btn_UpdateRemoveProduct.TabIndex = 2;
            this.btn_UpdateRemoveProduct.Text = "Update / Remove product";
            this.btn_UpdateRemoveProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateRemoveProduct.Click += new System.EventHandler(this.btn_UpdateRemoveProduct_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(854, 452);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(251, 81);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 556);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_UpdateRemoveProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmManageProducts";
            this.Text = "frmManageProducts";
            this.Load += new System.EventHandler(this.frmManageGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_UpdateRemoveProduct;
        private System.Windows.Forms.Button btn_Close;
    }
}