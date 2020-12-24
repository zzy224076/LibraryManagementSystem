
namespace LibraryManagementSystem
{
    partial class Query
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_jianjie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_publish = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_words = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_book_name = new System.Windows.Forms.Label();
            this.pictureBox_book_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_query_bookName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_book_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.textBox_jianjie);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_author);
            this.groupBox1.Controls.Add(this.label_publish);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_words);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_book_name);
            this.groupBox1.Controls.Add(this.pictureBox_book_pic);
            this.groupBox1.Location = new System.Drawing.Point(493, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 617);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_jianjie
            // 
            this.textBox_jianjie.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_jianjie.Location = new System.Drawing.Point(296, 429);
            this.textBox_jianjie.Multiline = true;
            this.textBox_jianjie.Name = "textBox_jianjie";
            this.textBox_jianjie.Size = new System.Drawing.Size(531, 182);
            this.textBox_jianjie.TabIndex = 14;
            this.textBox_jianjie.Text = "简介";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(291, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "内容简介：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_price.Location = new System.Drawing.Point(477, 307);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(82, 28);
            this.label_price.TabIndex = 11;
            this.label_price.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(291, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "价格：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(291, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "出版日期：";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_author.Location = new System.Drawing.Point(477, 128);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(96, 28);
            this.label_author.TabIndex = 7;
            this.label_author.Text = "author";
            // 
            // label_publish
            // 
            this.label_publish.AutoSize = true;
            this.label_publish.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_publish.Location = new System.Drawing.Point(477, 194);
            this.label_publish.Name = "label_publish";
            this.label_publish.Size = new System.Drawing.Size(110, 28);
            this.label_publish.TabIndex = 6;
            this.label_publish.Text = "publish";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(291, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "字数（千）：";
            // 
            // label_words
            // 
            this.label_words.AutoSize = true;
            this.label_words.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_words.Location = new System.Drawing.Point(477, 252);
            this.label_words.Name = "label_words";
            this.label_words.Size = new System.Drawing.Size(82, 28);
            this.label_words.TabIndex = 4;
            this.label_words.Text = "words";
            this.label_words.Click += new System.EventHandler(this.label_words_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(291, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "作者：";
            // 
            // label_book_name
            // 
            this.label_book_name.AutoSize = true;
            this.label_book_name.Font = new System.Drawing.Font("华文中宋", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_book_name.Location = new System.Drawing.Point(23, 31);
            this.label_book_name.Name = "label_book_name";
            this.label_book_name.Size = new System.Drawing.Size(194, 49);
            this.label_book_name.TabIndex = 1;
            this.label_book_name.Text = "人间失格";
            // 
            // pictureBox_book_pic
            // 
            this.pictureBox_book_pic.Location = new System.Drawing.Point(15, 97);
            this.pictureBox_book_pic.Name = "pictureBox_book_pic";
            this.pictureBox_book_pic.Size = new System.Drawing.Size(270, 411);
            this.pictureBox_book_pic.TabIndex = 0;
            this.pictureBox_book_pic.TabStop = false;
            this.pictureBox_book_pic.Click += new System.EventHandler(this.pictureBox_book_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(488, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入图书名称";
            // 
            // textBox_query_bookName
            // 
            this.textBox_query_bookName.Location = new System.Drawing.Point(784, 60);
            this.textBox_query_bookName.Name = "textBox_query_bookName";
            this.textBox_query_bookName.Size = new System.Drawing.Size(208, 25);
            this.textBox_query_bookName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1118, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_query_bookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_book_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_query_bookName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_book_pic;
        private System.Windows.Forms.Label label_book_name;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_publish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_words;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_jianjie;
    }
}