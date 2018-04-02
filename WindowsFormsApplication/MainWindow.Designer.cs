namespace VersenyekSQL
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newUserRegisterLB = new System.Windows.Forms.Label();
            this.addNewPersonLB = new System.Windows.Forms.Label();
            this.addNewMedicineLB = new System.Windows.Forms.Label();
            this.addNewNappyLB = new System.Windows.Forms.Label();
            this.addNewMedicineDoseLB = new System.Windows.Forms.Label();
            this.addNewNappyDoseLB = new System.Windows.Forms.Label();
            this.medicineOnStoorLB = new System.Windows.Forms.Label();
            this.nappyOnStoorLB = new System.Windows.Forms.Label();
            this.generalTotalizeLB = new System.Windows.Forms.Label();
            this.totalizeP = new System.Windows.Forms.Label();
            this.logOutLB = new System.Windows.Forms.Label();
            this.userNameLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(411, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Válaszd ki a kívánt opciót!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1054, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Felhasználónév:";
            // 
            // newUserRegisterLB
            // 
            this.newUserRegisterLB.AutoSize = true;
            this.newUserRegisterLB.BackColor = System.Drawing.Color.Transparent;
            this.newUserRegisterLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newUserRegisterLB.ForeColor = System.Drawing.Color.White;
            this.newUserRegisterLB.Location = new System.Drawing.Point(505, 140);
            this.newUserRegisterLB.Name = "newUserRegisterLB";
            this.newUserRegisterLB.Size = new System.Drawing.Size(333, 29);
            this.newUserRegisterLB.TabIndex = 21;
            this.newUserRegisterLB.Text = "Új felhasználó regisztrálása";
            this.newUserRegisterLB.Click += new System.EventHandler(this.label9_Click);
            this.newUserRegisterLB.MouseEnter += new System.EventHandler(this.label9_MouseEnter);
            this.newUserRegisterLB.MouseLeave += new System.EventHandler(this.label9_MouseLeave);
            // 
            // addNewPersonLB
            // 
            this.addNewPersonLB.AutoSize = true;
            this.addNewPersonLB.BackColor = System.Drawing.Color.Transparent;
            this.addNewPersonLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewPersonLB.ForeColor = System.Drawing.Color.White;
            this.addNewPersonLB.Location = new System.Drawing.Point(543, 194);
            this.addNewPersonLB.Name = "addNewPersonLB";
            this.addNewPersonLB.Size = new System.Drawing.Size(264, 29);
            this.addNewPersonLB.TabIndex = 22;
            this.addNewPersonLB.Text = "Új ember hozzáadása";
            this.addNewPersonLB.Click += new System.EventHandler(this.label3_Click);
            this.addNewPersonLB.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.addNewPersonLB.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // addNewMedicineLB
            // 
            this.addNewMedicineLB.AutoSize = true;
            this.addNewMedicineLB.BackColor = System.Drawing.Color.Transparent;
            this.addNewMedicineLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewMedicineLB.ForeColor = System.Drawing.Color.White;
            this.addNewMedicineLB.Location = new System.Drawing.Point(518, 248);
            this.addNewMedicineLB.Name = "addNewMedicineLB";
            this.addNewMedicineLB.Size = new System.Drawing.Size(307, 29);
            this.addNewMedicineLB.TabIndex = 23;
            this.addNewMedicineLB.Text = "Új gyógyszer hozzáadása";
            this.addNewMedicineLB.Click += new System.EventHandler(this.label4_Click);
            this.addNewMedicineLB.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.addNewMedicineLB.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // addNewNappyLB
            // 
            this.addNewNappyLB.AutoSize = true;
            this.addNewNappyLB.BackColor = System.Drawing.Color.Transparent;
            this.addNewNappyLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewNappyLB.ForeColor = System.Drawing.Color.White;
            this.addNewNappyLB.Location = new System.Drawing.Point(505, 302);
            this.addNewNappyLB.Name = "addNewNappyLB";
            this.addNewNappyLB.Size = new System.Drawing.Size(331, 29);
            this.addNewNappyLB.TabIndex = 24;
            this.addNewNappyLB.Text = "Új pelenkafajta hozzáadása";
            this.addNewNappyLB.Click += new System.EventHandler(this.label5_Click);
            this.addNewNappyLB.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.addNewNappyLB.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // addNewMedicineDoseLB
            // 
            this.addNewMedicineDoseLB.AutoSize = true;
            this.addNewMedicineDoseLB.BackColor = System.Drawing.Color.Transparent;
            this.addNewMedicineDoseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewMedicineDoseLB.ForeColor = System.Drawing.Color.White;
            this.addNewMedicineDoseLB.Location = new System.Drawing.Point(481, 352);
            this.addNewMedicineDoseLB.Name = "addNewMedicineDoseLB";
            this.addNewMedicineDoseLB.Size = new System.Drawing.Size(365, 29);
            this.addNewMedicineDoseLB.TabIndex = 25;
            this.addNewMedicineDoseLB.Text = "Új gyógyszeradag hozzáadása";
            this.addNewMedicineDoseLB.Click += new System.EventHandler(this.label6_Click);
            this.addNewMedicineDoseLB.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.addNewMedicineDoseLB.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // addNewNappyDoseLB
            // 
            this.addNewNappyDoseLB.AutoSize = true;
            this.addNewNappyDoseLB.BackColor = System.Drawing.Color.Transparent;
            this.addNewNappyDoseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewNappyDoseLB.ForeColor = System.Drawing.Color.White;
            this.addNewNappyDoseLB.Location = new System.Drawing.Point(496, 407);
            this.addNewNappyDoseLB.Name = "addNewNappyDoseLB";
            this.addNewNappyDoseLB.Size = new System.Drawing.Size(340, 29);
            this.addNewNappyDoseLB.TabIndex = 26;
            this.addNewNappyDoseLB.Text = "Új pelenkaadag hozzáadása";
            this.addNewNappyDoseLB.Click += new System.EventHandler(this.label7_Click);
            this.addNewNappyDoseLB.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
            this.addNewNappyDoseLB.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            // 
            // medicineOnStoorLB
            // 
            this.medicineOnStoorLB.AutoSize = true;
            this.medicineOnStoorLB.BackColor = System.Drawing.Color.Transparent;
            this.medicineOnStoorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.medicineOnStoorLB.ForeColor = System.Drawing.Color.White;
            this.medicineOnStoorLB.Location = new System.Drawing.Point(499, 461);
            this.medicineOnStoorLB.Name = "medicineOnStoorLB";
            this.medicineOnStoorLB.Size = new System.Drawing.Size(326, 29);
            this.medicineOnStoorLB.TabIndex = 27;
            this.medicineOnStoorLB.Text = "Raktáron lévő gyógyszerek";
            this.medicineOnStoorLB.Click += new System.EventHandler(this.label8_Click);
            this.medicineOnStoorLB.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.medicineOnStoorLB.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // nappyOnStoorLB
            // 
            this.nappyOnStoorLB.AutoSize = true;
            this.nappyOnStoorLB.BackColor = System.Drawing.Color.Transparent;
            this.nappyOnStoorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nappyOnStoorLB.ForeColor = System.Drawing.Color.White;
            this.nappyOnStoorLB.Location = new System.Drawing.Point(521, 513);
            this.nappyOnStoorLB.Name = "nappyOnStoorLB";
            this.nappyOnStoorLB.Size = new System.Drawing.Size(286, 29);
            this.nappyOnStoorLB.TabIndex = 28;
            this.nappyOnStoorLB.Text = "Raktáron lévő pelenkák";
            this.nappyOnStoorLB.Click += new System.EventHandler(this.label10_Click);
            this.nappyOnStoorLB.MouseEnter += new System.EventHandler(this.label10_MouseEnter);
            this.nappyOnStoorLB.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
            // 
            // generalTotalizeLB
            // 
            this.generalTotalizeLB.AutoSize = true;
            this.generalTotalizeLB.BackColor = System.Drawing.Color.Transparent;
            this.generalTotalizeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generalTotalizeLB.ForeColor = System.Drawing.Color.White;
            this.generalTotalizeLB.Location = new System.Drawing.Point(536, 566);
            this.generalTotalizeLB.Name = "generalTotalizeLB";
            this.generalTotalizeLB.Size = new System.Drawing.Size(250, 29);
            this.generalTotalizeLB.TabIndex = 29;
            this.generalTotalizeLB.Text = "Általános összesités";
            this.generalTotalizeLB.Click += new System.EventHandler(this.label11_Click);
            this.generalTotalizeLB.MouseEnter += new System.EventHandler(this.label11_MouseEnter);
            this.generalTotalizeLB.MouseLeave += new System.EventHandler(this.label11_MouseLeave);
            // 
            // totalizeP
            // 
            this.totalizeP.AutoSize = true;
            this.totalizeP.BackColor = System.Drawing.Color.Transparent;
            this.totalizeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalizeP.ForeColor = System.Drawing.Color.White;
            this.totalizeP.Location = new System.Drawing.Point(486, 619);
            this.totalizeP.Name = "totalizeP";
            this.totalizeP.Size = new System.Drawing.Size(355, 29);
            this.totalizeP.TabIndex = 30;
            this.totalizeP.Text = "Személyenkénti összesitések";
            this.totalizeP.Click += new System.EventHandler(this.label12_Click);
            this.totalizeP.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.totalizeP.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // logOutLB
            // 
            this.logOutLB.AutoSize = true;
            this.logOutLB.BackColor = System.Drawing.Color.Transparent;
            this.logOutLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutLB.ForeColor = System.Drawing.Color.White;
            this.logOutLB.Location = new System.Drawing.Point(1131, 69);
            this.logOutLB.Name = "logOutLB";
            this.logOutLB.Size = new System.Drawing.Size(170, 29);
            this.logOutLB.TabIndex = 31;
            this.logOutLB.Text = "Kijelentkezés";
            this.logOutLB.Click += new System.EventHandler(this.label13_Click);
            this.logOutLB.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.logOutLB.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // userNameLB
            // 
            this.userNameLB.AutoSize = true;
            this.userNameLB.BackColor = System.Drawing.Color.Transparent;
            this.userNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNameLB.ForeColor = System.Drawing.Color.White;
            this.userNameLB.Location = new System.Drawing.Point(1260, 22);
            this.userNameLB.Name = "userNameLB";
            this.userNameLB.Size = new System.Drawing.Size(87, 31);
            this.userNameLB.TabIndex = 32;
            this.userNameLB.Text = "admin";
            this.userNameLB.Click += new System.EventHandler(this.label14_Click);
            this.userNameLB.MouseEnter += new System.EventHandler(this.label14_MouseEnter);
            this.userNameLB.MouseLeave += new System.EventHandler(this.label14_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.line_shadow_background_dark_47497_3840x2400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.userNameLB);
            this.Controls.Add(this.logOutLB);
            this.Controls.Add(this.totalizeP);
            this.Controls.Add(this.generalTotalizeLB);
            this.Controls.Add(this.nappyOnStoorLB);
            this.Controls.Add(this.medicineOnStoorLB);
            this.Controls.Add(this.addNewNappyDoseLB);
            this.Controls.Add(this.addNewMedicineDoseLB);
            this.Controls.Add(this.addNewNappyLB);
            this.Controls.Add(this.addNewMedicineLB);
            this.Controls.Add(this.addNewPersonLB);
            this.Controls.Add(this.newUserRegisterLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.RightToLeftLayout = true;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newUserRegisterLB;
        private System.Windows.Forms.Label addNewPersonLB;
        private System.Windows.Forms.Label addNewMedicineLB;
        private System.Windows.Forms.Label addNewNappyLB;
        private System.Windows.Forms.Label addNewMedicineDoseLB;
        private System.Windows.Forms.Label addNewNappyDoseLB;
        private System.Windows.Forms.Label medicineOnStoorLB;
        private System.Windows.Forms.Label nappyOnStoorLB;
        private System.Windows.Forms.Label generalTotalizeLB;
        private System.Windows.Forms.Label totalizeP;
        private System.Windows.Forms.Label logOutLB;
        private System.Windows.Forms.Label userNameLB;
    }
}