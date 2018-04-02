namespace VersenyekSQL
{
    partial class AddNewDose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.persNameCB = new System.Windows.Forms.ComboBox();
            this.medNameCB = new System.Windows.Forms.ComboBox();
            this.numTB = new System.Windows.Forms.TextBox();
            this.partOfTheDayCB = new System.Windows.Forms.ComboBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.valtakozoLabel = new System.Windows.Forms.Label();
            this.yesterdayDGV = new System.Windows.Forms.DataGridView();
            this.reAddBTN = new System.Windows.Forms.Button();
            this.personTNameCB = new System.Windows.Forms.ComboBox();
            this.tegnapiNev = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label6 = new System.Windows.Forms.Label();
            this.dropRowBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.oldDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.newDatePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteRowBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yesterdayDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(560, 711);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:               ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gyógyszer:   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mennyiség(ml):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Napszakok:       ";
            // 
            // persNameCB
            // 
            this.persNameCB.FormattingEnabled = true;
            this.persNameCB.Location = new System.Drawing.Point(213, 270);
            this.persNameCB.Name = "persNameCB";
            this.persNameCB.Size = new System.Drawing.Size(257, 33);
            this.persNameCB.TabIndex = 5;
            this.persNameCB.MouseEnter += new System.EventHandler(this.szemelyNevCB_MouseEnter);
            // 
            // medNameCB
            // 
            this.medNameCB.FormattingEnabled = true;
            this.medNameCB.Location = new System.Drawing.Point(213, 319);
            this.medNameCB.Name = "medNameCB";
            this.medNameCB.Size = new System.Drawing.Size(257, 33);
            this.medNameCB.TabIndex = 6;
            this.medNameCB.TextChanged += new System.EventHandler(this.gyogyszerNevCB_TextChanged);
            this.medNameCB.MouseEnter += new System.EventHandler(this.gyogyszerNevCB_MouseEnter);
            // 
            // numTB
            // 
            this.numTB.Location = new System.Drawing.Point(215, 367);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(257, 31);
            this.numTB.TabIndex = 7;
            this.numTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // partOfTheDayCB
            // 
            this.partOfTheDayCB.FormattingEnabled = true;
            this.partOfTheDayCB.Location = new System.Drawing.Point(215, 417);
            this.partOfTheDayCB.Name = "partOfTheDayCB";
            this.partOfTheDayCB.Size = new System.Drawing.Size(257, 33);
            this.partOfTheDayCB.TabIndex = 8;
            this.partOfTheDayCB.MouseEnter += new System.EventHandler(this.napszakCB_MouseEnter);
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBTN.Location = new System.Drawing.Point(372, 508);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(100, 30);
            this.addBTN.TabIndex = 9;
            this.addBTN.Text = "Hozzáad";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.mehetBTN_Click);
            this.addBTN.MouseEnter += new System.EventHandler(this.mehetBTN_MouseEnter);
            this.addBTN.MouseLeave += new System.EventHandler(this.mehetBTN_MouseLeave);
            // 
            // valtakozoLabel
            // 
            this.valtakozoLabel.AutoSize = true;
            this.valtakozoLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.valtakozoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valtakozoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.valtakozoLabel.Location = new System.Drawing.Point(622, 89);
            this.valtakozoLabel.Name = "valtakozoLabel";
            this.valtakozoLabel.Size = new System.Drawing.Size(515, 39);
            this.valtakozoLabel.TabIndex = 10;
            this.valtakozoLabel.Text = "Korábbi adatok elrejtése(katt ide)";
            this.valtakozoLabel.Click += new System.EventHandler(this.valtakozoLabel_Click);
            // 
            // yesterdayDGV
            // 
            this.yesterdayDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yesterdayDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.yesterdayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yesterdayDGV.Location = new System.Drawing.Point(504, 315);
            this.yesterdayDGV.Name = "yesterdayDGV";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yesterdayDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yesterdayDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.yesterdayDGV.Size = new System.Drawing.Size(822, 286);
            this.yesterdayDGV.TabIndex = 11;
            // 
            // reAddBTN
            // 
            this.reAddBTN.Location = new System.Drawing.Point(786, 605);
            this.reAddBTN.Name = "reAddBTN";
            this.reAddBTN.Size = new System.Drawing.Size(271, 40);
            this.reAddBTN.TabIndex = 12;
            this.reAddBTN.Text = "Adatok újrabevitele";
            this.reAddBTN.UseVisualStyleBackColor = true;
            this.reAddBTN.Click += new System.EventHandler(this.tegnapiBTN_Click);
            this.reAddBTN.MouseEnter += new System.EventHandler(this.tegnapiBTN_MouseEnter);
            this.reAddBTN.MouseLeave += new System.EventHandler(this.tegnapiBTN_MouseLeave);
            // 
            // personTNameCB
            // 
            this.personTNameCB.FormattingEnabled = true;
            this.personTNameCB.Location = new System.Drawing.Point(900, 178);
            this.personTNameCB.Name = "personTNameCB";
            this.personTNameCB.Size = new System.Drawing.Size(239, 33);
            this.personTNameCB.TabIndex = 13;
            this.personTNameCB.TextChanged += new System.EventHandler(this.tegnapiCB_TextChanged);
            this.personTNameCB.MouseEnter += new System.EventHandler(this.tegnapiCB_MouseEnter);
            // 
            // tegnapiNev
            // 
            this.tegnapiNev.AutoSize = true;
            this.tegnapiNev.BackColor = System.Drawing.Color.LightGray;
            this.tegnapiNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tegnapiNev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tegnapiNev.Location = new System.Drawing.Point(682, 178);
            this.tegnapiNev.Name = "tegnapiNev";
            this.tegnapiNev.Size = new System.Drawing.Size(211, 33);
            this.tegnapiNev.TabIndex = 14;
            this.tegnapiNev.Text = "Név:                 ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 2);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1350, 729);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackgroundImage = global::VersenyekSQL.Properties.Resources.blackBGR;
            this.rectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape2.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape2.BorderWidth = 5;
            this.rectangleShape2.CornerRadius = 10;
            this.rectangleShape2.Location = new System.Drawing.Point(499, 140);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(827, 508);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::VersenyekSQL.Properties.Resources.blackBGR;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.CornerRadius = 20;
            this.rectangleShape1.Location = new System.Drawing.Point(17, 194);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(473, 361);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(127, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "Új adatok bevitele";
            // 
            // dropRowBTN
            // 
            this.dropRowBTN.Location = new System.Drawing.Point(505, 605);
            this.dropRowBTN.Name = "dropRowBTN";
            this.dropRowBTN.Size = new System.Drawing.Size(268, 40);
            this.dropRowBTN.TabIndex = 19;
            this.dropRowBTN.Text = "Kijelölt sor elvetése";
            this.dropRowBTN.UseVisualStyleBackColor = true;
            this.dropRowBTN.Click += new System.EventHandler(this.button1_Click);
            this.dropRowBTN.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.dropRowBTN.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(29, 467);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dátum:               ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(215, 469);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(257, 24);
            this.dateTimePicker.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(682, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 33);
            this.label7.TabIndex = 32;
            this.label7.Text = "Korábbi dátum:";
            // 
            // oldDatePicker
            // 
            this.oldDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldDatePicker.Location = new System.Drawing.Point(900, 232);
            this.oldDatePicker.Name = "oldDatePicker";
            this.oldDatePicker.Size = new System.Drawing.Size(239, 24);
            this.oldDatePicker.TabIndex = 33;
            this.oldDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(682, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 33);
            this.label8.TabIndex = 34;
            this.label8.Text = "Új dátum:         ";
            // 
            // newDatePicker
            // 
            this.newDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newDatePicker.Location = new System.Drawing.Point(900, 279);
            this.newDatePicker.Name = "newDatePicker";
            this.newDatePicker.Size = new System.Drawing.Size(239, 24);
            this.newDatePicker.TabIndex = 35;
            // 
            // deleteRowBTN
            // 
            this.deleteRowBTN.Location = new System.Drawing.Point(1069, 605);
            this.deleteRowBTN.Name = "deleteRowBTN";
            this.deleteRowBTN.Size = new System.Drawing.Size(256, 40);
            this.deleteRowBTN.TabIndex = 36;
            this.deleteRowBTN.Text = "Kijelölt sor törlése";
            this.deleteRowBTN.UseVisualStyleBackColor = true;
            this.deleteRowBTN.Click += new System.EventHandler(this.button2_Click);
            this.deleteRowBTN.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.deleteRowBTN.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // AddNewDose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.abstract_green_by_michalius89_d72jx3r;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.deleteRowBTN);
            this.Controls.Add(this.newDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oldDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropRowBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tegnapiNev);
            this.Controls.Add(this.personTNameCB);
            this.Controls.Add(this.reAddBTN);
            this.Controls.Add(this.yesterdayDGV);
            this.Controls.Add(this.valtakozoLabel);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.partOfTheDayCB);
            this.Controls.Add(this.numTB);
            this.Controls.Add(this.medNameCB);
            this.Controls.Add(this.persNameCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddNewDose";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "AddNewDose";
            ((System.ComponentModel.ISupportInitialize)(this.yesterdayDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox persNameCB;
        private System.Windows.Forms.ComboBox medNameCB;
        private System.Windows.Forms.TextBox numTB;
        private System.Windows.Forms.ComboBox partOfTheDayCB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Label valtakozoLabel;
        private System.Windows.Forms.DataGridView yesterdayDGV;
        private System.Windows.Forms.Button reAddBTN;
        private System.Windows.Forms.ComboBox personTNameCB;
        private System.Windows.Forms.Label tegnapiNev;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button dropRowBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker oldDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker newDatePicker;
        private System.Windows.Forms.Button deleteRowBTN;
    }
}