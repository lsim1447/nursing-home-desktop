namespace VersenyekSQL
{
    partial class GeneralSummarization
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBTN = new System.Windows.Forms.Button();
            this.lastMonthRB = new System.Windows.Forms.RadioButton();
            this.intervalRB = new System.Windows.Forms.RadioButton();
            this.timeIntervalGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastDatePicker = new System.Windows.Forms.DateTimePicker();
            this.firstDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalizeDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.filenameTB = new System.Windows.Forms.TextBox();
            this.saveIntoFileBTN = new System.Windows.Forms.Button();
            this.loadFileLB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listAfterNameBTN = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.productGB = new System.Windows.Forms.GroupBox();
            this.nappyRB = new System.Windows.Forms.RadioButton();
            this.medicineRB = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.timeIntervalGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalizeDGV)).BeginInit();
            this.productGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBTN.Location = new System.Drawing.Point(554, 694);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(265, 44);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Vissza a főmenübe";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.visszaBTN_Click);
            this.backBTN.MouseEnter += new System.EventHandler(this.visszaBTN_MouseEnter);
            this.backBTN.MouseLeave += new System.EventHandler(this.visszaBTN_MouseLeave);
            // 
            // lastMonthRB
            // 
            this.lastMonthRB.AutoSize = true;
            this.lastMonthRB.Location = new System.Drawing.Point(37, 38);
            this.lastMonthRB.Name = "lastMonthRB";
            this.lastMonthRB.Size = new System.Drawing.Size(157, 30);
            this.lastMonthRB.TabIndex = 22;
            this.lastMonthRB.TabStop = true;
            this.lastMonthRB.Text = "múlt hónapra";
            this.lastMonthRB.UseVisualStyleBackColor = true;
            this.lastMonthRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // intervalRB
            // 
            this.intervalRB.AutoSize = true;
            this.intervalRB.Location = new System.Drawing.Point(37, 74);
            this.intervalRB.Name = "intervalRB";
            this.intervalRB.Size = new System.Drawing.Size(190, 30);
            this.intervalRB.TabIndex = 23;
            this.intervalRB.TabStop = true;
            this.intervalRB.Text = "két dátum között";
            this.intervalRB.UseVisualStyleBackColor = true;
            // 
            // timeIntervalGB
            // 
            this.timeIntervalGB.BackColor = System.Drawing.Color.White;
            this.timeIntervalGB.Controls.Add(this.lastMonthRB);
            this.timeIntervalGB.Controls.Add(this.intervalRB);
            this.timeIntervalGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeIntervalGB.Location = new System.Drawing.Point(39, 228);
            this.timeIntervalGB.Name = "timeIntervalGB";
            this.timeIntervalGB.Size = new System.Drawing.Size(336, 122);
            this.timeIntervalGB.TabIndex = 25;
            this.timeIntervalGB.TabStop = false;
            this.timeIntervalGB.Text = "Időpontok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 51);
            this.label2.TabIndex = 26;
            this.label2.Text = "Általános összesítések";
            // 
            // lastDatePicker
            // 
            this.lastDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastDatePicker.Location = new System.Drawing.Point(519, 299);
            this.lastDatePicker.Name = "lastDatePicker";
            this.lastDatePicker.Size = new System.Drawing.Size(200, 29);
            this.lastDatePicker.TabIndex = 31;
            this.lastDatePicker.ValueChanged += new System.EventHandler(this.vegsoPicker_ValueChanged);
            // 
            // firstDatePicker
            // 
            this.firstDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstDatePicker.Location = new System.Drawing.Point(519, 245);
            this.firstDatePicker.Name = "firstDatePicker";
            this.firstDatePicker.Size = new System.Drawing.Size(200, 29);
            this.firstDatePicker.TabIndex = 30;
            this.firstDatePicker.ValueChanged += new System.EventHandler(this.kezdetiPicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(401, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Meddig:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(401, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mettől:  ";
            // 
            // totalizeDGV
            // 
            this.totalizeDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalizeDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalizeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalizeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.totalizeDGV.ColumnHeadersHeight = 50;
            this.totalizeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.totalizeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalizeDGV.Location = new System.Drawing.Point(748, 84);
            this.totalizeDGV.Name = "totalizeDGV";
            this.totalizeDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalizeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalizeDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.totalizeDGV.Size = new System.Drawing.Size(601, 390);
            this.totalizeDGV.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(893, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kapott gyógyszerek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(897, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Végösszeg: ";
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalPriceTB.Location = new System.Drawing.Point(1056, 477);
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.ReadOnly = true;
            this.totalPriceTB.Size = new System.Drawing.Size(125, 29);
            this.totalPriceTB.TabIndex = 35;
            this.totalPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1180, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "  LEI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(896, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 36);
            this.label7.TabIndex = 37;
            this.label7.Text = "Adatok lementése fájlba";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(798, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Add meg a fájl nevét:";
            // 
            // filenameTB
            // 
            this.filenameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filenameTB.Location = new System.Drawing.Point(1057, 576);
            this.filenameTB.Name = "filenameTB";
            this.filenameTB.Size = new System.Drawing.Size(164, 29);
            this.filenameTB.TabIndex = 39;
            this.filenameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveIntoFileBTN
            // 
            this.saveIntoFileBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveIntoFileBTN.Location = new System.Drawing.Point(1227, 574);
            this.saveIntoFileBTN.Name = "saveIntoFileBTN";
            this.saveIntoFileBTN.Size = new System.Drawing.Size(75, 31);
            this.saveIntoFileBTN.TabIndex = 40;
            this.saveIntoFileBTN.Text = "Ment";
            this.saveIntoFileBTN.UseVisualStyleBackColor = true;
            this.saveIntoFileBTN.Click += new System.EventHandler(this.mentBTN_Click);
            this.saveIntoFileBTN.MouseEnter += new System.EventHandler(this.mentBTN_MouseEnter);
            this.saveIntoFileBTN.MouseLeave += new System.EventHandler(this.mentBTN_MouseLeave);
            // 
            // loadFileLB
            // 
            this.loadFileLB.AutoSize = true;
            this.loadFileLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadFileLB.Location = new System.Drawing.Point(942, 618);
            this.loadFileLB.Name = "loadFileLB";
            this.loadFileLB.Size = new System.Drawing.Size(239, 29);
            this.loadFileLB.TabIndex = 41;
            this.loadFileLB.Text = "Létező fájl betöltése";
            this.loadFileLB.Click += new System.EventHandler(this.label10_Click);
            this.loadFileLB.MouseEnter += new System.EventHandler(this.label10_MouseEnter);
            this.loadFileLB.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(33, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(632, 32);
            this.label9.TabIndex = 42;
            this.label9.Text = "Fizetendő összegek kilistázása nevekre lebontva";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(181, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(395, 26);
            this.label12.TabIndex = 44;
            this.label12.Text = "Válaszd ki az időintervallumokat            ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(154, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(154, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(181, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(395, 26);
            this.label14.TabIndex = 48;
            this.label14.Text = "Majd kattints az \"Megtekint\" gombra      ";
            // 
            // listAfterNameBTN
            // 
            this.listAfterNameBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listAfterNameBTN.Location = new System.Drawing.Point(554, 589);
            this.listAfterNameBTN.Name = "listAfterNameBTN";
            this.listAfterNameBTN.Size = new System.Drawing.Size(111, 37);
            this.listAfterNameBTN.TabIndex = 49;
            this.listAfterNameBTN.Text = "Megtekint";
            this.listAfterNameBTN.UseVisualStyleBackColor = true;
            this.listAfterNameBTN.Click += new System.EventHandler(this.button1_Click);
            this.listAfterNameBTN.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.listAfterNameBTN.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1354, 733);
            this.shapeContainer1.TabIndex = 50;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.White;
            this.rectangleShape3.BackgroundImage = global::VersenyekSQL.Properties.Resources.Frame;
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(377, 230);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(363, 117);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackgroundImage = global::VersenyekSQL.Properties.Resources.Frame;
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.BorderWidth = 5;
            this.rectangleShape2.Location = new System.Drawing.Point(758, 510);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(587, 162);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rectangleShape1.BackgroundImage = global::VersenyekSQL.Properties.Resources.Frame;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderWidth = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 369);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(673, 277);
            // 
            // productGB
            // 
            this.productGB.BackColor = System.Drawing.Color.White;
            this.productGB.Controls.Add(this.nappyRB);
            this.productGB.Controls.Add(this.medicineRB);
            this.productGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productGB.Location = new System.Drawing.Point(39, 122);
            this.productGB.Name = "productGB";
            this.productGB.Size = new System.Drawing.Size(200, 106);
            this.productGB.TabIndex = 51;
            this.productGB.TabStop = false;
            this.productGB.Text = "Termék:";
            // 
            // nappyRB
            // 
            this.nappyRB.AutoSize = true;
            this.nappyRB.Location = new System.Drawing.Point(37, 66);
            this.nappyRB.Name = "nappyRB";
            this.nappyRB.Size = new System.Drawing.Size(95, 28);
            this.nappyRB.TabIndex = 1;
            this.nappyRB.TabStop = true;
            this.nappyRB.Text = "pelenka";
            this.nappyRB.UseVisualStyleBackColor = true;
            // 
            // medicineRB
            // 
            this.medicineRB.AutoSize = true;
            this.medicineRB.Location = new System.Drawing.Point(37, 30);
            this.medicineRB.Name = "medicineRB";
            this.medicineRB.Size = new System.Drawing.Size(114, 28);
            this.medicineRB.TabIndex = 0;
            this.medicineRB.TabStop = true;
            this.medicineRB.Text = "gyógyszer";
            this.medicineRB.UseVisualStyleBackColor = true;
            this.medicineRB.CheckedChanged += new System.EventHandler(this.gyogyszerRadioButton_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(245, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(385, 32);
            this.label15.TabIndex = 52;
            this.label15.Text = "(Válaszd ki a kivánt terméket)";
            // 
            // GeneralSummarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.abstract_green_by_michalius89_d72jx3r;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.productGB);
            this.Controls.Add(this.listAfterNameBTN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loadFileLB);
            this.Controls.Add(this.saveIntoFileBTN);
            this.Controls.Add(this.filenameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalPriceTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalizeDGV);
            this.Controls.Add(this.lastDatePicker);
            this.Controls.Add(this.firstDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeIntervalGB);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "GeneralSummarization";
            this.Text = "GeneralSummarization";
            this.timeIntervalGB.ResumeLayout(false);
            this.timeIntervalGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalizeDGV)).EndInit();
            this.productGB.ResumeLayout(false);
            this.productGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.RadioButton lastMonthRB;
        private System.Windows.Forms.RadioButton intervalRB;
        private System.Windows.Forms.GroupBox timeIntervalGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker lastDatePicker;
        private System.Windows.Forms.DateTimePicker firstDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView totalizeDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPriceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox filenameTB;
        private System.Windows.Forms.Button saveIntoFileBTN;
        private System.Windows.Forms.Label loadFileLB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button listAfterNameBTN;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.GroupBox productGB;
        private System.Windows.Forms.RadioButton nappyRB;
        private System.Windows.Forms.RadioButton medicineRB;
        private System.Windows.Forms.Label label15;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;

    }
}