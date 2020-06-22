namespace Number_DataBase
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Show_Bill = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NumberS = new System.Windows.Forms.TextBox();
            this.SurnameS = new System.Windows.Forms.TextBox();
            this.NameS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Debug_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.get_bill_login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(181)))), ((int)(((byte)(237)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.get_bill_login);
            this.panel2.Controls.Add(this.Show_Bill);
            this.panel2.Controls.Add(this.loginField);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.NumberS);
            this.panel2.Controls.Add(this.SurnameS);
            this.panel2.Controls.Add(this.NameS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Debug_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 265);
            this.panel2.TabIndex = 3;
            // 
            // Show_Bill
            // 
            this.Show_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Show_Bill.Location = new System.Drawing.Point(798, 96);
            this.Show_Bill.Name = "Show_Bill";
            this.Show_Bill.Size = new System.Drawing.Size(222, 54);
            this.Show_Bill.TabIndex = 12;
            this.Show_Bill.Text = "Показать список";
            this.Show_Bill.UseVisualStyleBackColor = true;
            this.Show_Bill.Click += new System.EventHandler(this.Show_Bill_Click);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(186, 157);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(373, 44);
            this.loginField.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ваш Логин";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(547, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberS
            // 
            this.NumberS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.NumberS.Location = new System.Drawing.Point(186, 106);
            this.NumberS.Name = "NumberS";
            this.NumberS.Size = new System.Drawing.Size(373, 44);
            this.NumberS.TabIndex = 8;
            // 
            // SurnameS
            // 
            this.SurnameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.SurnameS.Location = new System.Drawing.Point(186, 56);
            this.SurnameS.Name = "SurnameS";
            this.SurnameS.Size = new System.Drawing.Size(373, 44);
            this.SurnameS.TabIndex = 8;
            // 
            // NameS
            // 
            this.NameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.NameS.Location = new System.Drawing.Point(186, 6);
            this.NameS.Name = "NameS";
            this.NameS.Size = new System.Drawing.Size(373, 44);
            this.NameS.TabIndex = 8;
            this.NameS.TextChanged += new System.EventHandler(this.NameS_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(97, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // Debug_text
            // 
            this.Debug_text.Location = new System.Drawing.Point(565, 6);
            this.Debug_text.Multiline = true;
            this.Debug_text.Name = "Debug_text";
            this.Debug_text.ReadOnly = true;
            this.Debug_text.Size = new System.Drawing.Size(220, 256);
            this.Debug_text.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 62);
            this.panel1.TabIndex = 2;
            // 
            // get_bill_login
            // 
            this.get_bill_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.get_bill_login.Location = new System.Drawing.Point(798, 46);
            this.get_bill_login.Name = "get_bill_login";
            this.get_bill_login.Size = new System.Drawing.Size(222, 44);
            this.get_bill_login.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(791, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ваш Логин";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книга";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Debug_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumberS;
        private System.Windows.Forms.TextBox SurnameS;
        private System.Windows.Forms.TextBox NameS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Show_Bill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox get_bill_login;
    }
}