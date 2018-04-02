namespace VersenyekSQL
{
    partial class AddNewMedicine
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
            this.components = new System.ComponentModel.Container();
            this.Vissza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.medicineNameTB = new System.Windows.Forms.TextBox();
            this.unitCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.medicineBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewMedicineBTN = new System.Windows.Forms.Button();
            this.deleteMedBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numTB = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label6 = new System.Windows.Forms.Label();
            this.timerMedicine = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Vissza
            // 
            this.Vissza.Location = new System.Drawing.Point(1403, 966);
            this.Vissza.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Vissza.Name = "Vissza";
            this.Vissza.Size = new System.Drawing.Size(200, 55);
            this.Vissza.TabIndex = 0;
            this.Vissza.Text = "Vissza";
            this.Vissza.UseVisualStyleBackColor = true;
            this.Vissza.Click += new System.EventHandler(this.Vissza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(231, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gyógyszer neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(231, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mértékegység:    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(231, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipús:                  ";
            // 
            // medicineNameTB
            // 
            this.medicineNameTB.Location = new System.Drawing.Point(485, 273);
            this.medicineNameTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.medicineNameTB.Name = "medicineNameTB";
            this.medicineNameTB.Size = new System.Drawing.Size(260, 38);
            this.medicineNameTB.TabIndex = 5;
            this.medicineNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitCB
            // 
            this.unitCB.FormattingEnabled = true;
            this.unitCB.Location = new System.Drawing.Point(485, 343);
            this.unitCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.unitCB.Name = "unitCB";
            this.unitCB.Size = new System.Drawing.Size(260, 39);
            this.unitCB.TabIndex = 6;
            this.unitCB.TextChanged += new System.EventHandler(this.mertekegysegCB_TextChanged);
            this.unitCB.MouseEnter += new System.EventHandler(this.mertekegysegCB_MouseEnter);
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(485, 419);
            this.typeCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(260, 39);
            this.typeCB.TabIndex = 8;
            this.typeCB.MouseEnter += new System.EventHandler(this.tipusCB_MouseEnter);
            // 
            // medicineBox
            // 
            this.medicineBox.BackColor = System.Drawing.Color.Aqua;
            this.medicineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.medicineBox.FormattingEnabled = true;
            this.medicineBox.ItemHeight = 29;
            this.medicineBox.Location = new System.Drawing.Point(966, 90);
            this.medicineBox.Name = "medicineBox";
            this.medicineBox.Size = new System.Drawing.Size(367, 555);
            this.medicineBox.TabIndex = 9;
            this.medicineBox.DoubleClick += new System.EventHandler(this.gyogyszerBox_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(960, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gyógyszertípúsok listája";
            // 
            // addNewMedicineBTN
            // 
            this.addNewMedicineBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewMedicineBTN.Location = new System.Drawing.Point(611, 546);
            this.addNewMedicineBTN.Name = "addNewMedicineBTN";
            this.addNewMedicineBTN.Size = new System.Drawing.Size(134, 41);
            this.addNewMedicineBTN.TabIndex = 11;
            this.addNewMedicineBTN.Text = "Hozzáad";
            this.addNewMedicineBTN.UseVisualStyleBackColor = true;
            this.addNewMedicineBTN.Click += new System.EventHandler(this.button1_Click);
            this.addNewMedicineBTN.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.addNewMedicineBTN.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // deleteMedBTN
            // 
            this.deleteMedBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteMedBTN.Location = new System.Drawing.Point(1230, 651);
            this.deleteMedBTN.Name = "deleteMedBTN";
            this.deleteMedBTN.Size = new System.Drawing.Size(103, 38);
            this.deleteMedBTN.TabIndex = 12;
            this.deleteMedBTN.Text = "Törlés";
            this.deleteMedBTN.UseVisualStyleBackColor = true;
            this.deleteMedBTN.Click += new System.EventHandler(this.button2_Click);
            this.deleteMedBTN.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.deleteMedBTN.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBTN.Location = new System.Drawing.Point(586, 694);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(265, 44);
            this.backBTN.TabIndex = 13;
            this.backBTN.Text = "Vissza a főmenübe";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.button3_Click);
            this.backBTN.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.backBTN.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(230, 493);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Darab/doboz:      ";
            // 
            // numTB
            // 
            this.numTB.Location = new System.Drawing.Point(485, 493);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(260, 38);
            this.numTB.TabIndex = 15;
            this.numTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1354, 733);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::VersenyekSQL.Properties.Resources.blackBGR;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.CornerRadius = 20;
            this.rectangleShape1.Location = new System.Drawing.Point(192, 164);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(586, 445);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(255, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 44);
            this.label6.TabIndex = 17;
            this.label6.Text = "Új gyógyszer hozzáadása";
            // 
            // AddNewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.abstract_green_by_michalius89_d72jx3r;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.deleteMedBTN);
            this.Controls.Add(this.addNewMedicineBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medicineBox);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.unitCB);
            this.Controls.Add(this.medicineNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vissza);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddNewMedicine";
            this.Text = "AddNewMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vissza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medicineNameTB;
        private System.Windows.Forms.ComboBox unitCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.ListBox medicineBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addNewMedicineBTN;
        private System.Windows.Forms.Button deleteMedBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numTB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerMedicine;
    }
}