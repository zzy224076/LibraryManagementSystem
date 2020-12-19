
namespace LibraryManagementSystem
{
    partial class Form6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_xue_id = new System.Windows.Forms.RadioButton();
            this.radioButton_cert_id = new System.Windows.Forms.RadioButton();
            this.textBox_guaID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_xue_id);
            this.panel1.Controls.Add(this.radioButton_cert_id);
            this.panel1.Location = new System.Drawing.Point(452, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 92);
            this.panel1.TabIndex = 0;
            // 
            // radioButton_xue_id
            // 
            this.radioButton_xue_id.AutoSize = true;
            this.radioButton_xue_id.Location = new System.Drawing.Point(117, 32);
            this.radioButton_xue_id.Name = "radioButton_xue_id";
            this.radioButton_xue_id.Size = new System.Drawing.Size(58, 19);
            this.radioButton_xue_id.TabIndex = 1;
            this.radioButton_xue_id.TabStop = true;
            this.radioButton_xue_id.Text = "学号";
            this.radioButton_xue_id.UseVisualStyleBackColor = true;
            // 
            // radioButton_cert_id
            // 
            this.radioButton_cert_id.AutoSize = true;
            this.radioButton_cert_id.Location = new System.Drawing.Point(3, 32);
            this.radioButton_cert_id.Name = "radioButton_cert_id";
            this.radioButton_cert_id.Size = new System.Drawing.Size(89, 19);
            this.radioButton_cert_id.TabIndex = 0;
            this.radioButton_cert_id.TabStop = true;
            this.radioButton_cert_id.Text = "借阅证ID";
            this.radioButton_cert_id.UseVisualStyleBackColor = true;
            // 
            // textBox_guaID
            // 
            this.textBox_guaID.Location = new System.Drawing.Point(575, 276);
            this.textBox_guaID.Name = "textBox_guaID";
            this.textBox_guaID.Size = new System.Drawing.Size(131, 25);
            this.textBox_guaID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "挂失";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(452, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(452, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            // 
            // textBox2_name
            // 
            this.textBox2_name.Location = new System.Drawing.Point(575, 343);
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(131, 25);
            this.textBox2_name.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "补办";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 732);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_guaID);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_xue_id;
        private System.Windows.Forms.RadioButton radioButton_cert_id;
        private System.Windows.Forms.TextBox textBox_guaID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_name;
        private System.Windows.Forms.Button button2;
    }
}