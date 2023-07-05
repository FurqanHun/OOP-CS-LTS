namespace project_FYT_inv
{
    partial class DeleteItem
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
            this.pid_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Info_DBDataSet = new project_FYT_inv.Product_Info_DBDataSet();
            this.product_InfoTableAdapter = new project_FYT_inv.Product_Info_DBDataSetTableAdapters.Product_InfoTableAdapter();
            this.mm_delete_btn = new System.Windows.Forms.Button();
            this.delete_item_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Info_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pid_txt
            // 
            this.pid_txt.Location = new System.Drawing.Point(246, 94);
            this.pid_txt.Name = "pid_txt";
            this.pid_txt.Size = new System.Drawing.Size(175, 20);
            this.pid_txt.TabIndex = 1;
            this.pid_txt.TextChanged += new System.EventHandler(this.pid_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(124, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Product ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(201, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Delete an Item from Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pQtyDataGridViewTextBoxColumn,
            this.pPriceDataGridViewTextBoxColumn,
            this.pCodeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productInfoBindingSource;
            this.dataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView.Location = new System.Drawing.Point(58, 175);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(543, 150);
            this.dataGridView.TabIndex = 29;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "p_Id";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "p_Id";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "p_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "p_Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pQtyDataGridViewTextBoxColumn
            // 
            this.pQtyDataGridViewTextBoxColumn.DataPropertyName = "p_Qty";
            this.pQtyDataGridViewTextBoxColumn.HeaderText = "p_Qty";
            this.pQtyDataGridViewTextBoxColumn.Name = "pQtyDataGridViewTextBoxColumn";
            this.pQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPriceDataGridViewTextBoxColumn
            // 
            this.pPriceDataGridViewTextBoxColumn.DataPropertyName = "p_Price";
            this.pPriceDataGridViewTextBoxColumn.HeaderText = "p_Price";
            this.pPriceDataGridViewTextBoxColumn.Name = "pPriceDataGridViewTextBoxColumn";
            this.pPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pCodeDataGridViewTextBoxColumn
            // 
            this.pCodeDataGridViewTextBoxColumn.DataPropertyName = "p_Code";
            this.pCodeDataGridViewTextBoxColumn.HeaderText = "p_Code";
            this.pCodeDataGridViewTextBoxColumn.Name = "pCodeDataGridViewTextBoxColumn";
            this.pCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "Product_Info";
            this.productInfoBindingSource.DataSource = this.product_Info_DBDataSet;
            // 
            // product_Info_DBDataSet
            // 
            this.product_Info_DBDataSet.DataSetName = "Product_Info_DBDataSet";
            this.product_Info_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_InfoTableAdapter
            // 
            this.product_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // mm_delete_btn
            // 
            this.mm_delete_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm_delete_btn.Location = new System.Drawing.Point(503, 126);
            this.mm_delete_btn.Name = "mm_delete_btn";
            this.mm_delete_btn.Size = new System.Drawing.Size(107, 25);
            this.mm_delete_btn.TabIndex = 3;
            this.mm_delete_btn.TabStop = false;
            this.mm_delete_btn.Text = "Main Menu";
            this.mm_delete_btn.UseVisualStyleBackColor = true;
            this.mm_delete_btn.Click += new System.EventHandler(this.mm_delete_btn_Click);
            // 
            // delete_item_btn
            // 
            this.delete_item_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_item_btn.Location = new System.Drawing.Point(476, 74);
            this.delete_item_btn.Name = "delete_item_btn";
            this.delete_item_btn.Size = new System.Drawing.Size(134, 46);
            this.delete_item_btn.TabIndex = 2;
            this.delete_item_btn.Text = "Delete";
            this.delete_item_btn.UseVisualStyleBackColor = true;
            this.delete_item_btn.Click += new System.EventHandler(this.delete_item_btn_Click);
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 378);
            this.Controls.Add(this.mm_delete_btn);
            this.Controls.Add(this.delete_item_btn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pid_txt);
            this.Controls.Add(this.label5);
            this.Name = "DeleteItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 13 - Furqan";
            this.Load += new System.EventHandler(this.DeleteItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Info_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pid_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private Product_Info_DBDataSet product_Info_DBDataSet;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private Product_Info_DBDataSetTableAdapters.Product_InfoTableAdapter product_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button mm_delete_btn;
        private System.Windows.Forms.Button delete_item_btn;
    }
}