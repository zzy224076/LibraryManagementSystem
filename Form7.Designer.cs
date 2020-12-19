
namespace LibraryManagementSystem
{
    partial class Form7
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_guaID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_xue_id);
            this.panel1.Controls.Add(this.radioButton_cert_id);
            this.panel1.Location = new System.Drawing.Point(576, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 92);
            this.panel1.TabIndex = 7;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "注销";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2_name
            // 
            this.textBox2_name.Location = new System.Drawing.Point(662, 365);
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(131, 25);
            this.textBox2_name.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(572, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(572, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // textBox_guaID
            // 
            this.textBox_guaID.Location = new System.Drawing.Point(662, 292);
            this.textBox_guaID.Name = "textBox_guaID";
            this.textBox_guaID.Size = new System.Drawing.Size(131, 25);
            this.textBox_guaID.TabIndex = 8;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_guaID);
            this.Name = "Form7";
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_xue_id;
        private System.Windows.Forms.RadioButton radioButton_cert_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_guaID;
    }
}