namespace L11_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotal_textbox = new System.Windows.Forms.TextBox();
            this.discountpercent_textbox = new System.Windows.Forms.TextBox();
            this.discount_textbox = new System.Windows.Forms.TextBox();
            this.total_textbox = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dear Customer, You have to pay";
            // 
            // result_textbox
            // 
            this.result_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_textbox.Location = new System.Drawing.Point(248, 21);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(113, 20);
            this.result_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // subtotal_textbox
            // 
            this.subtotal_textbox.Location = new System.Drawing.Point(209, 67);
            this.subtotal_textbox.Name = "subtotal_textbox";
            this.subtotal_textbox.Size = new System.Drawing.Size(152, 20);
            this.subtotal_textbox.TabIndex = 1;
            // 
            // discountpercent_textbox
            // 
            this.discountpercent_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.discountpercent_textbox.Enabled = false;
            this.discountpercent_textbox.Location = new System.Drawing.Point(209, 105);
            this.discountpercent_textbox.Name = "discountpercent_textbox";
            this.discountpercent_textbox.ReadOnly = true;
            this.discountpercent_textbox.ShortcutsEnabled = false;
            this.discountpercent_textbox.Size = new System.Drawing.Size(152, 20);
            this.discountpercent_textbox.TabIndex = 7;
            // 
            // discount_textbox
            // 
            this.discount_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.discount_textbox.Enabled = false;
            this.discount_textbox.Location = new System.Drawing.Point(209, 145);
            this.discount_textbox.Name = "discount_textbox";
            this.discount_textbox.ReadOnly = true;
            this.discount_textbox.ShortcutsEnabled = false;
            this.discount_textbox.Size = new System.Drawing.Size(152, 20);
            this.discount_textbox.TabIndex = 8;
            // 
            // total_textbox
            // 
            this.total_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.total_textbox.Enabled = false;
            this.total_textbox.HideSelection = false;
            this.total_textbox.Location = new System.Drawing.Point(209, 180);
            this.total_textbox.Name = "total_textbox";
            this.total_textbox.ReadOnly = true;
            this.total_textbox.ShortcutsEnabled = false;
            this.total_textbox.Size = new System.Drawing.Size(152, 20);
            this.total_textbox.TabIndex = 9;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(209, 231);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(152, 66);
            this.calculate_btn.TabIndex = 2;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(248, 312);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.TabStop = false;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 371);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.total_textbox);
            this.Controls.Add(this.discount_textbox);
            this.Controls.Add(this.discountpercent_textbox);
            this.Controls.Add(this.subtotal_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sasta Discounted Payment Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subtotal_textbox;
        private System.Windows.Forms.TextBox discountpercent_textbox;
        private System.Windows.Forms.TextBox discount_textbox;
        private System.Windows.Forms.TextBox total_textbox;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

