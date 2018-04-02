namespace VersenyekSQL
{
    partial class AddNewPerson
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
            this.backBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personNameTB = new System.Windows.Forms.TextBox();
            this.cnpTB = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.personDGV = new System.Windows.Forms.DataGridView();
            this.timerPerson = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(580, 693);
            this.backBTN.Margin = new System.Windows.Forms.Padding(6);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(265, 44);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Vissza a főmenübe";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.Vissza_Click);
            this.backBTN.MouseEnter += new System.EventHandler(this.Vissza_MouseEnter);
            this.backBTN.MouseLeave += new System.EventHandler(this.Vissza_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(90, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teljes név:       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(90, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Személyi szám:";
            // 
            // personNameTB
            // 
            this.personNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personNameTB.Location = new System.Drawing.Point(380, 311);
            this.personNameTB.Name = "personNameTB";
            this.personNameTB.Size = new System.Drawing.Size(259, 35);
            this.personNameTB.TabIndex = 5;
            this.personNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnpTB
            // 
            this.cnpTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cnpTB.Location = new System.Drawing.Point(380, 387);
            this.cnpTB.Name = "cnpTB";
            this.cnpTB.Size = new System.Drawing.Size(259, 35);
            this.cnpTB.TabIndex = 7;
            this.cnpTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(522, 453);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(117, 38);
            this.addBTN.TabIndex = 8;
            this.addBTN.Text = "Hozzáad";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.Hozzaad_Click);
            this.addBTN.MouseEnter += new System.EventHandler(this.Hozzaad_MouseEnter);
            this.addBTN.MouseLeave += new System.EventHandler(this.Hozzaad_MouseLeave);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(1218, 626);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(108, 37);
            this.deleteBTN.TabIndex = 11;
            this.deleteBTN.Text = "Törlés";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.embertTorol_Click);
            this.deleteBTN.MouseEnter += new System.EventHandler(this.embertTorol_MouseEnter);
            this.deleteBTN.MouseLeave += new System.EventHandler(this.embertTorol_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(840, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(392, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Az otthon lakóinak listája";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1354, 727);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::VersenyekSQL.Properties.Resources.blackBGR1;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.CornerRadius = 20;
            this.rectangleShape1.Location = new System.Drawing.Point(56, 152);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(623, 378);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(174, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "Új lakó hozzáadása";
            // 
            // personDGV
            // 
            this.personDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personDGV.ColumnHeadersHeight = 60;
            this.personDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.personDGV.Location = new System.Drawing.Point(736, 74);
            this.personDGV.MultiSelect = false;
            this.personDGV.Name = "personDGV";
            this.personDGV.ReadOnly = true;
            this.personDGV.Size = new System.Drawing.Size(590, 546);
            this.personDGV.TabIndex = 14;
            this.personDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emberekDGV_CellDoubleClick);
            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.abstract_green_by_michalius89_d72jx3r;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 727);
            this.Controls.Add(this.personDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.cnpTB);
            this.Controls.Add(this.personNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddNewPerson";
            this.Text = "AddNewPerson";
            ((System.ComponentModel.ISupportInitialize)(this.personDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox personNameTB;
        private System.Windows.Forms.TextBox cnpTB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView personDGV;
        private System.Windows.Forms.Timer timerPerson;
    }
}