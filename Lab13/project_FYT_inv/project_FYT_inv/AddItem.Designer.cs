namespace project_FYT_inv
{
    partial class AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p_code_label = new System.Windows.Forms.Label();
            this.pname_txt = new System.Windows.Forms.TextBox();
            this.pqty_txt = new System.Windows.Forms.TextBox();
            this.pprice_txt = new System.Windows.Forms.TextBox();
            this.pcode_txt = new System.Windows.Forms.TextBox();
            this.add_item_btn = new System.Windows.Forms.Button();
            this.mm_add_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Info_DBDataSet = new project_FYT_inv.Product_Info_DBDataSet();
            this.product_InfoTableAdapter = new project_FYT_inv.Product_Info_DBDataSetTableAdapters.Product_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Info_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add an Item in Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label4.Location = new System.Drawing.Point(385, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price";
            // 
            // p_code_label
            // 
            this.p_code_label.AutoSize = true;
            this.p_code_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.p_code_label.Location = new System.Drawing.Point(385, 133);
            this.p_code_label.Name = "p_code_label";
            this.p_code_label.Size = new System.Drawing.Size(94, 19);
            this.p_code_label.TabIndex = 4;
            this.p_code_label.Text = "Product Code";
            // 
            // pname_txt
            // 
            this.pname_txt.Location = new System.Drawing.Point(189, 99);
            this.pname_txt.Name = "pname_txt";
            this.pname_txt.Size = new System.Drawing.Size(175, 20);
            this.pname_txt.TabIndex = 1;
            // 
            // pqty_txt
            // 
            this.pqty_txt.Location = new System.Drawing.Point(189, 137);
            this.pqty_txt.Name = "pqty_txt";
            this.pqty_txt.Size = new System.Drawing.Size(175, 20);
            this.pqty_txt.TabIndex = 3;
            // 
            // pprice_txt
            // 
            this.pprice_txt.Location = new System.Drawing.Point(551, 97);
            this.pprice_txt.Name = "pprice_txt";
            this.pprice_txt.Size = new System.Drawing.Size(175, 20);
            this.pprice_txt.TabIndex = 2;
            // 
            // pcode_txt
            // 
            this.pcode_txt.Location = new System.Drawing.Point(551, 132);
            this.pcode_txt.Name = "pcode_txt";
            this.pcode_txt.Size = new System.Drawing.Size(175, 20);
            this.pcode_txt.TabIndex = 4;
            // 
            // add_item_btn
            // 
            this.add_item_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item_btn.Location = new System.Drawing.Point(247, 186);
            this.add_item_btn.Name = "add_item_btn";
            this.add_item_btn.Size = new System.Drawing.Size(117, 49);
            this.add_item_btn.TabIndex = 5;
            this.add_item_btn.Text = "Add";
            this.add_item_btn.UseVisualStyleBackColor = true;
            this.add_item_btn.Click += new System.EventHandler(this.add_item_btn_Click);
            // 
            // mm_add_btn
            // 
            this.mm_add_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm_add_btn.Location = new System.Drawing.Point(393, 197);
            this.mm_add_btn.Name = "mm_add_btn";
            this.mm_add_btn.Size = new System.Drawing.Size(86, 29);
            this.mm_add_btn.TabIndex = 12;
            this.mm_add_btn.TabStop = false;
            this.mm_add_btn.Text = "Main Menu";
            this.mm_add_btn.UseVisualStyleBackColor = true;
            this.mm_add_btn.Click += new System.EventHandler(this.mm_add_btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
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
            this.dataGridView.Location = new System.Drawing.Point(123, 285);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(543, 150);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.TabStop = false;
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
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 447);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mm_add_btn);
            this.Controls.Add(this.add_item_btn);
            this.Controls.Add(this.pcode_txt);
            this.Controls.Add(this.pprice_txt);
            this.Controls.Add(this.pqty_txt);
            this.Controls.Add(this.pname_txt);
            this.Controls.Add(this.p_code_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 13 - Furqan";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Info_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label p_code_label;
        private System.Windows.Forms.TextBox pname_txt;
        private System.Windows.Forms.TextBox pqty_txt;
        private System.Windows.Forms.TextBox pprice_txt;
        private System.Windows.Forms.TextBox pcode_txt;
        private System.Windows.Forms.Button add_item_btn;
        private System.Windows.Forms.Button mm_add_btn;
        private System.Windows.Forms.DataGridView dataGridView;
        private Product_Info_DBDataSet product_Info_DBDataSet;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private Product_Info_DBDataSetTableAdapters.Product_InfoTableAdapter product_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCodeDataGridViewTextBoxColumn;
    }
}