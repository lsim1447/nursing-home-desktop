namespace VersenyekSQL
{
    partial class AddNewNappy
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
            this.label1 = new System.Windows.Forms.Label();
            this.pelenkaBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nappyNameTB = new System.Windows.Forms.TextBox();
            this.numTB = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.saveBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timerNappy = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(147, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új pelenkafajta regisztrálása";
            // 
            // pelenkaBox
            // 
            this.pelenkaBox.BackColor = System.Drawing.Color.Aqua;
            this.pelenkaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pelenkaBox.FormattingEnabled = true;
            this.pelenkaBox.ItemHeight = 29;
            this.pelenkaBox.Location = new System.Drawing.Point(952, 167);
            this.pelenkaBox.Margin = new System.Windows.Forms.Padding(4);
            this.pelenkaBox.Name = "pelenkaBox";
            this.pelenkaBox.Size = new System.Drawing.Size(350, 468);
            this.pelenkaBox.TabIndex = 10;
            this.pelenkaBox.DoubleClick += new System.EventHandler(this.pelenkaBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(189, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pelenka neve:  ";
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBTN.Location = new System.Drawing.Point(588, 706);
            this.backBTN.Margin = new System.Windows.Forms.Padding(6);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(265, 44);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Vissza a főmenübe";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.Vissza_Click);
            this.backBTN.MouseEnter += new System.EventHandler(this.Vissza_MouseEnter);
            this.backBTN.MouseLeave += new System.EventHandler(this.Vissza_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(193, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "Darab/csomag:";
            // 
            // nappyNameTB
            // 
            this.nappyNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nappyNameTB.Location = new System.Drawing.Point(427, 382);
            this.nappyNameTB.Name = "nappyNameTB";
            this.nappyNameTB.Size = new System.Drawing.Size(242, 35);
            this.nappyNameTB.TabIndex = 15;
            this.nappyNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numTB
            // 
            this.numTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numTB.Location = new System.Drawing.Point(427, 458);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(242, 35);
            this.numTB.TabIndex = 17;
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
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::VersenyekSQL.Properties.Resources.blackBGR;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.CornerRadius = 20;
            this.rectangleShape1.Location = new System.Drawing.Point(129, 227);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(605, 350);
            // 
            // saveBTN
            // 
            this.saveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBTN.Location = new System.Drawing.Point(558, 517);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(111, 38);
            this.saveBTN.TabIndex = 19;
            this.saveBTN.Text = "Mentés";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.mentBTN_Click);
            this.saveBTN.MouseEnter += new System.EventHandler(this.mentBTN_MouseEnter);
            this.saveBTN.MouseLeave += new System.EventHandler(this.mentBTN_MouseLeave);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBTN.Location = new System.Drawing.Point(1202, 642);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(100, 36);
            this.deleteBTN.TabIndex = 20;
            this.deleteBTN.Text = "Törlés";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.button1_Click);
            this.deleteBTN.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.deleteBTN.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(945, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pelenkatípúsok listája";
            // 
            // AddNewNappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.abstract_green_by_michalius89_d72jx3r;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.numTB);
            this.Controls.Add(this.nappyNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pelenkaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewNappy";
            this.Text = "AddNewNappy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox pelenkaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nappyNameTB;
        private System.Windows.Forms.TextBox numTB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerNappy;
    }
}