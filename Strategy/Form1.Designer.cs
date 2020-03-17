namespace Strategy
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBox_discount = new System.Windows.Forms.ComboBox();
            this.listBox_detail = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(110, 30);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 25);
            this.textBox_price.TabIndex = 3;
            this.textBox_price.Text = "0";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(110, 85);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 25);
            this.textBox_number.TabIndex = 4;
            this.textBox_number.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(246, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(246, 83);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBox_discount
            // 
            this.comboBox_discount.FormattingEnabled = true;
            this.comboBox_discount.Location = new System.Drawing.Point(110, 139);
            this.comboBox_discount.Name = "comboBox_discount";
            this.comboBox_discount.Size = new System.Drawing.Size(211, 23);
            this.comboBox_discount.TabIndex = 7;
            // 
            // listBox_detail
            // 
            this.listBox_detail.FormattingEnabled = true;
            this.listBox_detail.ItemHeight = 15;
            this.listBox_detail.Location = new System.Drawing.Point(39, 187);
            this.listBox_detail.Name = "listBox_detail";
            this.listBox_detail.Size = new System.Drawing.Size(539, 79);
            this.listBox_detail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(107, 285);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(14, 15);
            this.label_total.TabIndex = 10;
            this.label_total.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "策略模式結合簡單工廠模式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 317);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_detail);
            this.Controls.Add(this.comboBox_discount);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBox_discount;
        private System.Windows.Forms.ListBox listBox_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label5;
    }
}

