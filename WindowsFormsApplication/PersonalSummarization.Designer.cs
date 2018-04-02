namespace VersenyekSQL
{
    partial class PersonalSummarization
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lastDatePicker = new System.Windows.Forms.DateTimePicker();
            this.totalizeDGV = new System.Windows.Forms.DataGridView();
            this.lastMonthRB = new System.Windows.Forms.RadioButton();
            this.intervalRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filenameTB = new System.Windows.Forms.TextBox();
            this.saveIntoFileBTN = new System.Windows.Forms.Button();
            this.loadFromFileLB = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label11 = new System.Windows.Forms.Label();
            this.totalizeBTN = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.productGB = new System.Windows.Forms.GroupBox();
            this.nappyRB = new System.Windows.Forms.RadioButton();
            this.medicineRB = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalizeDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.productGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBTN.Location = new System.Drawing.Point(547, 694);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(265, 44);
            this.backBTN.TabIndex = 11;
            this.backBTN.Text = "Vissza a főmenübe";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.visszaBTN_Click);
            this.backBTN.MouseEnter += new System.EventHandler(this.visszaBTN_MouseEnter);
            this.backBTN.MouseLeave += new System.EventHandler(this.visszaBTN_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Név:";
            // 
            // nameCB
            // 
            this.nameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameCB.FormattingEnabled = true;
            this.nameCB.Location = new System.Drawing.Point(154, 128);
            this.nameCB.Name = "nameCB";
            this.nameCB.Size = new System.Drawing.Size(238, 37);
            this.nameCB.TabIndex = 13;
            this.nameCB.TextChanged += new System.EventHandler(this.nevCB_TextChanged);
            this.nameCB.MouseEnter += new System.EventHandler(this.nevCB_MouseEnter);
            this.nameCB.MouseLeave += new System.EventHandler(this.nevCB_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 51);
            this.label2.TabIndex = 14;
            this.label2.Text = "Személyenkénti összesítések";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(385, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mettől:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(385, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Meddig:";
            // 
            // firstDatePicker
            // 
            this.firstDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstDatePicker.Location = new System.Drawing.Point(495, 355);
            this.firstDatePicker.Name = "firstDatePicker";
            this.firstDatePicker.Size = new System.Drawing.Size(200, 29);
            this.firstDatePicker.TabIndex = 19;
            this.firstDatePicker.ValueChanged += new System.EventHandler(this.kezdetiPicker_ValueChanged);
            // 
            // lastDatePicker
            // 
            this.lastDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastDatePicker.Location = new System.Drawing.Point(495, 401);
            this.lastDatePicker.Name = "lastDatePicker";
            this.lastDatePicker.Size = new System.Drawing.Size(200, 29);
            this.lastDatePicker.TabIndex = 20;
            this.lastDatePicker.ValueChanged += new System.EventHandler(this.vegsoPicker_ValueChanged);
            // 
            // totalizeDGV
            // 
            this.totalizeDGV.BackgroundColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalizeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.totalizeDGV.ColumnHeadersHeight = 40;
            this.totalizeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.totalizeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalizeDGV.Location = new System.Drawing.Point(712, 54);
            this.totalizeDGV.Name = "totalizeDGV";
            this.totalizeDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalizeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalizeDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.totalizeDGV.Size = new System.Drawing.Size(646, 477);
            this.totalizeDGV.TabIndex = 21;
            // 
            // lastMonthRB
            // 
            this.lastMonthRB.AutoSize = true;
            this.lastMonthRB.Location = new System.Drawing.Point(37, 38);
            this.lastMonthRB.Name = "lastMonthRB";
            this.lastMonthRB.Size = new System.Drawing.Size(174, 30);
            this.lastMonthRB.TabIndex = 22;
            this.lastMonthRB.TabStop = true;
            this.lastMonthRB.Text = "múlt hónapban";
            this.lastMonthRB.UseVisualStyleBackColor = true;
            // 
            // intervalRB
            // 
            this.intervalRB.AutoSize = true;
            this.intervalRB.Location = new System.Drawing.Point(37, 74);
            this.intervalRB.Name = "intervalRB";
            this.intervalRB.Size = new System.Drawing.Size(260, 30);
            this.intervalRB.TabIndex = 23;
            this.intervalRB.TabStop = true;
            this.intervalRB.Text = "egy intervallumra nézve";
            this.intervalRB.UseVisualStyleBackColor = true;
            this.intervalRB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastMonthRB);
            this.groupBox1.Controls.Add(this.intervalRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(69, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 122);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válaszd ki az egyiket:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(899, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Összköltség:";
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalPriceTB.Location = new System.Drawing.Point(1041, 536);
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.ReadOnly = true;
            this.totalPriceTB.Size = new System.Drawing.Size(137, 25);
            this.totalPriceTB.TabIndex = 26;
            this.totalPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(69, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(589, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "(tekintsd meg egy bizonyos személy gyógyszer/pelenka adagjait napról napra)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(870, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 38);
            this.label7.TabIndex = 28;
            this.label7.Text = "A kapott gyógyszeradagok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(920, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Eredmény lementése fájlba";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(833, 629);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Add meg a fájl nevét:";
            // 
            // filenameTB
            // 
            this.filenameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filenameTB.Location = new System.Drawing.Point(1036, 629);
            this.filenameTB.Name = "filenameTB";
            this.filenameTB.Size = new System.Drawing.Size(177, 24);
            this.filenameTB.TabIndex = 32;
            this.filenameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveIntoFileBTN
            // 
            this.saveIntoFileBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveIntoFileBTN.Location = new System.Drawing.Point(1234, 626);
            this.saveIntoFileBTN.Name = "saveIntoFileBTN";
            this.saveIntoFileBTN.Size = new System.Drawing.Size(77, 30);
            this.saveIntoFileBTN.TabIndex = 33;
            this.saveIntoFileBTN.Text = "Ment";
            this.saveIntoFileBTN.UseVisualStyleBackColor = true;
            this.saveIntoFileBTN.Click += new System.EventHandler(this.kiirBTN_Click);
            this.saveIntoFileBTN.MouseEnter += new System.EventHandler(this.kiirBTN_MouseEnter);
            this.saveIntoFileBTN.MouseLeave += new System.EventHandler(this.kiirBTN_MouseLeave);
            // 
            // loadFromFileLB
            // 
            this.loadFromFileLB.AutoSize = true;
            this.loadFromFileLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadFromFileLB.Location = new System.Drawing.Point(973, 672);
            this.loadFromFileLB.Name = "loadFromFileLB";
            this.loadFromFileLB.Size = new System.Drawing.Size(205, 25);
            this.loadFromFileLB.TabIndex = 35;
            this.loadFromFileLB.Text = "Létező fájl betöltése";
            this.loadFromFileLB.Click += new System.EventHandler(this.label10_Click);
            this.loadFromFileLB.MouseEnter += new System.EventHandler(this.label10_MouseEnter);
            this.loadFromFileLB.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
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
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackgroundImage = global::VersenyekSQL.Properties.Resources.Frame;
            this.rectangleShape3.BorderColor = System.Drawing.Color.White;
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(823, 572);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(499, 133);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackgroundImage = global::VersenyekSQL.Properties.Resources.Frame;
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.BorderWidth = 5;
            this.rectangleShape2.Location = new System.Drawing.Point(71, 465);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(515, 209);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::VersenyekSQL.Properties.Resources.Frame;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(370, 329);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(337, 117);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(91, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(478, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "Tekintsd meg az összesített fogyasztását";
            // 
            // totalizeBTN
            // 
            this.totalizeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalizeBTN.Location = new System.Drawing.Point(471, 632);
            this.totalizeBTN.Name = "totalizeBTN";
            this.totalizeBTN.Size = new System.Drawing.Size(98, 33);
            this.totalizeBTN.TabIndex = 38;
            this.totalizeBTN.Text = "Megtekint";
            this.totalizeBTN.UseVisualStyleBackColor = true;
            this.totalizeBTN.Click += new System.EventHandler(this.button1_Click);
            this.totalizeBTN.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.totalizeBTN.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(154, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(347, 24);
            this.label12.TabIndex = 39;
            this.label12.Text = "állítsd be a fenti időintervallumokat           ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(156, 594);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(342, 24);
            this.label13.TabIndex = 40;
            this.label13.Text = "majd kattints a Megtekint gombra            ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(155, 559);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(343, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "válassz ki egy nevet  és egy terméket     ";
            // 
            // productGB
            // 
            this.productGB.Controls.Add(this.nappyRB);
            this.productGB.Controls.Add(this.medicineRB);
            this.productGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productGB.Location = new System.Drawing.Point(69, 166);
            this.productGB.Name = "productGB";
            this.productGB.Size = new System.Drawing.Size(200, 100);
            this.productGB.TabIndex = 42;
            this.productGB.TabStop = false;
            this.productGB.Text = "Termék:";
            // 
            // nappyRB
            // 
            this.nappyRB.AutoSize = true;
            this.nappyRB.Location = new System.Drawing.Point(37, 59);
            this.nappyRB.Name = "nappyRB";
            this.nappyRB.Size = new System.Drawing.Size(91, 26);
            this.nappyRB.TabIndex = 1;
            this.nappyRB.TabStop = true;
            this.nappyRB.Text = "pelenka";
            this.nappyRB.UseVisualStyleBackColor = true;
            // 
            // medicineRB
            // 
            this.medicineRB.AutoSize = true;
            this.medicineRB.Location = new System.Drawing.Point(37, 27);
            this.medicineRB.Name = "medicineRB";
            this.medicineRB.Size = new System.Drawing.Size(109, 26);
            this.medicineRB.TabIndex = 0;
            this.medicineRB.TabStop = true;
            this.medicineRB.Text = "gyógyszer";
            this.medicineRB.UseVisualStyleBackColor = true;
            this.medicineRB.CheckedChanged += new System.EventHandler(this.gyogyszerRadioButton_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(275, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(385, 32);
            this.label16.TabIndex = 53;
            this.label16.Text = "(Válaszd ki a kivánt terméket)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(1165, 536);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 25);
            this.label15.TabIndex = 54;
            this.label15.Text = "   LEI";
            // 
            // PersonalSummarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VersenyekSQL.Properties.Resources.abstract_green_by_michalius89_d72jx3r;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.productGB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.totalizeBTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.loadFromFileLB);
            this.Controls.Add(this.saveIntoFileBTN);
            this.Controls.Add(this.filenameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalPriceTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalizeDGV);
            this.Controls.Add(this.lastDatePicker);
            this.Controls.Add(this.firstDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PersonalSummarization";
            this.Text = "PersonalSummarization";
            this.Load += new System.EventHandler(this.Osszesitesek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalizeDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.productGB.ResumeLayout(false);
            this.productGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker firstDatePicker;
        private System.Windows.Forms.DateTimePicker lastDatePicker;
        private System.Windows.Forms.DataGridView totalizeDGV;
        private System.Windows.Forms.RadioButton lastMonthRB;
        private System.Windows.Forms.RadioButton intervalRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPriceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox filenameTB;
        private System.Windows.Forms.Button saveIntoFileBTN;
        private System.Windows.Forms.Label loadFromFileLB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button totalizeBTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox productGB;
        private System.Windows.Forms.RadioButton nappyRB;
        private System.Windows.Forms.RadioButton medicineRB;
        private System.Windows.Forms.Label label16;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label15;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
    }
}