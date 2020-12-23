
namespace LibraryManagementSystem
{
    partial class Form_addBooks
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
            this.label = new System.Windows.Forms.Label();
            this.textBox_Book_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.dateTimePicker_publish = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown_Number = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_words = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_words)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(411, 76);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 15);
            this.label.TabIndex = 0;
            this.label.Text = "图书编号";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // textBox_Book_ID
            // 
            this.textBox_Book_ID.Location = new System.Drawing.Point(546, 66);
            this.textBox_Book_ID.Name = "textBox_Book_ID";
            this.textBox_Book_ID.Size = new System.Drawing.Size(100, 25);
            this.textBox_Book_ID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "字数（千字）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "作者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "出版日期";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "书名";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(546, 258);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(100, 25);
            this.textBox_author.TabIndex = 17;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(546, 130);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(100, 25);
            this.textBox_Title.TabIndex = 19;
            // 
            // dateTimePicker_publish
            // 
            this.dateTimePicker_publish.Location = new System.Drawing.Point(546, 195);
            this.dateTimePicker_publish.Name = "dateTimePicker_publish";
            this.dateTimePicker_publish.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_publish.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(411, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "印刷册数";
            // 
            // numericUpDown_Number
            // 
            this.numericUpDown_Number.Location = new System.Drawing.Point(546, 354);
            this.numericUpDown_Number.Name = "numericUpDown_Number";
            this.numericUpDown_Number.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Number.TabIndex = 39;
            this.numericUpDown_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_words
            // 
            this.numericUpDown_words.Location = new System.Drawing.Point(546, 305);
            this.numericUpDown_words.Name = "numericUpDown_words";
            this.numericUpDown_words.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_words.TabIndex = 40;
            this.numericUpDown_words.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 55);
            this.button1.TabIndex = 41;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "价格";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(546, 402);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 25);
            this.textBox_price.TabIndex = 43;
            // 
            // Form_addBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 572);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_words);
            this.Controls.Add(this.numericUpDown_Number);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker_publish);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Book_ID);
            this.Controls.Add(this.label);
            this.Name = "Form_addBooks";
            this.Text = "录入图书";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_words)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_Book_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.DateTimePicker dateTimePicker_publish;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown_Number;
        private System.Windows.Forms.NumericUpDown numericUpDown_words;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price;
    }
}