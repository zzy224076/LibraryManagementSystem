
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
            this.textBox_picUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_readingSummary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_words)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(716, 92);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 20);
            this.label.TabIndex = 0;
            this.label.Text = "图书编号";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // textBox_Book_ID
            // 
            this.textBox_Book_ID.Location = new System.Drawing.Point(851, 82);
            this.textBox_Book_ID.Name = "textBox_Book_ID";
            this.textBox_Book_ID.Size = new System.Drawing.Size(100, 25);
            this.textBox_Book_ID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(716, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "字数（千字）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(716, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "作者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(716, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "出版日期";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(716, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "书名";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(851, 274);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(100, 25);
            this.textBox_author.TabIndex = 17;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(851, 146);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(100, 25);
            this.textBox_Title.TabIndex = 19;
            // 
            // dateTimePicker_publish
            // 
            this.dateTimePicker_publish.Location = new System.Drawing.Point(851, 211);
            this.dateTimePicker_publish.Name = "dateTimePicker_publish";
            this.dateTimePicker_publish.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_publish.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(716, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "印刷册数";
            // 
            // numericUpDown_Number
            // 
            this.numericUpDown_Number.Location = new System.Drawing.Point(851, 370);
            this.numericUpDown_Number.Name = "numericUpDown_Number";
            this.numericUpDown_Number.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Number.TabIndex = 39;
            this.numericUpDown_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_words
            // 
            this.numericUpDown_words.Location = new System.Drawing.Point(851, 321);
            this.numericUpDown_words.Name = "numericUpDown_words";
            this.numericUpDown_words.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_words.TabIndex = 40;
            this.numericUpDown_words.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(762, 612);
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
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(716, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "价格";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(851, 418);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 25);
            this.textBox_price.TabIndex = 43;
            // 
            // textBox_picUrl
            // 
            this.textBox_picUrl.Location = new System.Drawing.Point(851, 472);
            this.textBox_picUrl.Name = "textBox_picUrl";
            this.textBox_picUrl.Size = new System.Drawing.Size(100, 25);
            this.textBox_picUrl.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(716, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "图片url";
            // 
            // textBox_readingSummary
            // 
            this.textBox_readingSummary.Location = new System.Drawing.Point(851, 530);
            this.textBox_readingSummary.Name = "textBox_readingSummary";
            this.textBox_readingSummary.Size = new System.Drawing.Size(100, 25);
            this.textBox_readingSummary.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(716, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "简介";
            // 
            // Form_addBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 706);
            this.Controls.Add(this.textBox_readingSummary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_picUrl);
            this.Controls.Add(this.label2);
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
        public System.Windows.Forms.TextBox textBox_picUrl;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_readingSummary;
        public System.Windows.Forms.Label label7;
    }
}