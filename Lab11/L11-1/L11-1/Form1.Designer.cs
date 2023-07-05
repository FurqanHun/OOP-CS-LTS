namespace L11_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.int1_txtbox = new System.Windows.Forms.TextBox();
            this.int2_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.subtract_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.divide_btn = new System.Windows.Forms.Button();
            this.off_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a Number";
            // 
            // int1_txtbox
            // 
            this.int1_txtbox.Location = new System.Drawing.Point(128, 33);
            this.int1_txtbox.Name = "int1_txtbox";
            this.int1_txtbox.Size = new System.Drawing.Size(116, 20);
            this.int1_txtbox.TabIndex = 2;
            // 
            // int2_txtbox
            // 
            this.int2_txtbox.Location = new System.Drawing.Point(128, 70);
            this.int2_txtbox.Name = "int2_txtbox";
            this.int2_txtbox.Size = new System.Drawing.Size(116, 20);
            this.int2_txtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(317, 70);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(172, 20);
            this.result_textbox.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(34, 140);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(89, 70);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // subtract_btn
            // 
            this.subtract_btn.Location = new System.Drawing.Point(139, 140);
            this.subtract_btn.Name = "subtract_btn";
            this.subtract_btn.Size = new System.Drawing.Size(89, 70);
            this.subtract_btn.TabIndex = 7;
            this.subtract_btn.Text = "Subtract";
            this.subtract_btn.UseVisualStyleBackColor = true;
            this.subtract_btn.Click += new System.EventHandler(this.subtract_btn_Click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.Location = new System.Drawing.Point(34, 224);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(89, 70);
            this.multiply_btn.TabIndex = 8;
            this.multiply_btn.Text = "Multiply";
            this.multiply_btn.UseVisualStyleBackColor = true;
            this.multiply_btn.Click += new System.EventHandler(this.multiply_btn_Click);
            // 
            // divide_btn
            // 
            this.divide_btn.Location = new System.Drawing.Point(139, 224);
            this.divide_btn.Name = "divide_btn";
            this.divide_btn.Size = new System.Drawing.Size(89, 70);
            this.divide_btn.TabIndex = 9;
            this.divide_btn.Text = "Divide";
            this.divide_btn.UseVisualStyleBackColor = true;
            this.divide_btn.Click += new System.EventHandler(this.divide_btn_Click);
            // 
            // off_btn
            // 
            this.off_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.off_btn.Location = new System.Drawing.Point(317, 140);
            this.off_btn.Name = "off_btn";
            this.off_btn.Size = new System.Drawing.Size(172, 70);
            this.off_btn.TabIndex = 10;
            this.off_btn.Text = "OFF";
            this.off_btn.UseVisualStyleBackColor = true;
            this.off_btn.Click += new System.EventHandler(this.off_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_btn.Location = new System.Drawing.Point(317, 224);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(172, 70);
            this.clr_btn.TabIndex = 11;
            this.clr_btn.Text = "CE";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 349);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.off_btn);
            this.Controls.Add(this.divide_btn);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.subtract_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.int2_txtbox);
            this.Controls.Add(this.int1_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furqan Sasta Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox int1_txtbox;
        private System.Windows.Forms.TextBox int2_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result_textbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button subtract_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button divide_btn;
        private System.Windows.Forms.Button off_btn;
        private System.Windows.Forms.Button clr_btn;
    }
}

