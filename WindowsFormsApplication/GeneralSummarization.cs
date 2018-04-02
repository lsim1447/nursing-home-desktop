using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VersenyekSQL
{
    public partial class GeneralSummarization : Form
    {
        private string userName;
        private bool ok = true;
        private DoseClass m_dose = new DoseClass();
        private OpenFileDialog ofd = new OpenFileDialog();
        private CheckClass check = new CheckClass();

        public GeneralSummarization(string par)
        {
            userName = par;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            lastMonthRB.Checked = true;
            label3.Visible = false;
            label4.Visible = false;
            firstDatePicker.Visible = false;
            lastDatePicker.Visible = false;
            rectangleShape3.Visible = false;
            ok = false;
            totalPriceTB.Text = "-";
            medicineRB.Checked = true;
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }

        private void visszaBTN_Click(object sender, EventArgs e)
        {
            Payoff();
            MainWindow fo = new MainWindow(userName);
            fo.Show();
            this.Close();
        }

        private void TotalizeAndUpdateWithMedicineDgv(string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetTeljesOsszesites(firstDate, secondDate);
            totalizeDGV.ColumnCount = 3;
            totalizeDGV.Columns[0].Name = "Gyógyszer neve";
            totalizeDGV.Columns[0].Width = 277;
            totalizeDGV.Columns[1].Name  = "Összmennyiség";
            totalizeDGV.Columns[1].Width = 140;
            totalizeDGV.Columns[2].Name = "Összár";
            totalizeDGV.Columns[2].Width = 140;

            foreach (DoseStruct item in doseList)
            {
                string unit = m_dose.taroltEljaras("select Gyogyszerek.Mertekegyseg from Gyogyszerek where Nev = '" + item.GyogyszerNev + "'");
                totalizeDGV.Rows.Add(item.GyogyszerNev, item.OsszMennyisegF + " " + unit, check.PriceWithTwoPrecision(item.Osszertek.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }

        private void TotalizeAndUpdateWithNappyDgv(string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetTeljesOsszesitesPelenka(firstDate, secondDate);
            totalizeDGV.ColumnCount = 3;
            totalizeDGV.Columns[0].Name = "Pelenka";
            totalizeDGV.Columns[0].Width = 277;
            totalizeDGV.Columns[1].Name = "Összmennyiség";
            totalizeDGV.Columns[1].Width = 140;
            totalizeDGV.Columns[2].Name = "Összár";
            totalizeDGV.Columns[2].Width = 140;

            foreach (DoseStruct item in doseList)
            {
                totalizeDGV.Rows.Add(item.GyogyszerNev, item.OsszMennyiseg, check.PriceWithTwoPrecision(item.Osszertek.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }
        
        private void TotalizeMedicinesPerName(string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetNevreszoloOsszesites(firstDate, secondDate);
            totalizeDGV.ColumnCount = 2;
            totalizeDGV.Columns[0].Name = "Személy neve";
            totalizeDGV.Columns[0].Width = 292;
            totalizeDGV.Columns[1].Name = "Végső összeg (LEI)";
            totalizeDGV.Columns[1].Width = 265;

            foreach (DoseStruct item in doseList)
            {
                totalizeDGV.Rows.Add(item.SzemelyNev, check.PriceWithTwoPrecision(item.Osszertek.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }

        private void TotalizeNappiesPerName(string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetNevreszoloOsszesitesPelenka(firstDate, secondDate);
            totalizeDGV.ColumnCount = 2;
            totalizeDGV.Columns[0].Name = "Személy neve";
            totalizeDGV.Columns[0].Width = 292;
            totalizeDGV.Columns[1].Name = "Végső összeg (LEI)";
            totalizeDGV.Columns[1].Width = 265;

            foreach (DoseStruct item in doseList)
            {
                totalizeDGV.Rows.Add(item.SzemelyNev, check.PriceWithTwoPrecision(item.Osszertek.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }
        
        private void UpdateDatagridview()
        {
            if (!ok)
            {
                if (medicineRB.Checked)
                {
                    var today = DateTime.Today;
                    var month = new DateTime(today.Year, today.Month, 1);
                    var first = month.AddMonths(-1);
                    var last = month.AddDays(-1);
                    if (lastMonthRB.Checked)
                    {
                        TotalizeAndUpdateWithMedicineDgv(first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok where Adagok.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                    else
                    {
                        TotalizeAndUpdateWithMedicineDgv(firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok where Adagok.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                }
                else
                {
                    var today = DateTime.Today;
                    var month = new DateTime(today.Year, today.Month, 1);
                    var first = month.AddMonths(-1);
                    var last = month.AddDays(-1);
                    if (lastMonthRB.Checked)
                    {
                        TotalizeAndUpdateWithNappyDgv(first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka where AdagokPelenka.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                    else
                    {
                        TotalizeAndUpdateWithNappyDgv(firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka where AdagokPelenka.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
            if (lastMonthRB.Checked)
            {
                label3.Visible = false;
                label4.Visible = false;
                firstDatePicker.Visible = false;
                lastDatePicker.Visible = false;
                rectangleShape3.Visible = false;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
                firstDatePicker.Visible = true;
                lastDatePicker.Visible = true;
                rectangleShape3.Visible = true;
            }
        }

        private void kezdetiPicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
        }

        private void vegsoPicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
        }

        private void visszaBTN_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void visszaBTN_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        public void Payoff()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1).ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-");
            var last = month.AddDays(-1).ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-");
            List<string> medicineNames;
            if (lastMonthRB.Checked){
                medicineNames = m_dose.GetGyogyszerNevLista(first, last);
            }
            else
            {
                medicineNames = m_dose.GetGyogyszerNevLista(firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
            }
            Dictionary<string, Object> dictionary = new Dictionary<string,Object>();
            foreach (string nevek in medicineNames){
                dictionary.Add(nevek, new Dictionary<string, Object>());
            }
        }

        private void mentBTN_Click(object sender, EventArgs e)
        {
            if (totalizeDGV.ColumnCount == 3)
            {
                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                var last = month.AddDays(-1);
                if (filenameTB.Text.Replace(" ", "") != "")
                {
                    string filePath = System.IO.Directory.GetCurrentDirectory();
                    string dbFile = filePath.Substring(0, filePath.Length - 9) + "FilesToPrint" + @"\" + filenameTB.Text.Replace(" ", "") + ".txt";
                    if (File.Exists(dbFile))
                    {
                        MessageBox.Show(" Ez a fájlnév már létezik! ", " Figyelem! ");
                        filenameTB.Text = "";
                    }
                    else
                    {
                        using (StreamWriter file = new StreamWriter(dbFile, false))
                        {
                            if (lastMonthRB.Checked)
                            {
                                file.WriteLine("\t\t\t  Dátum: " + first.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + last.ToShortDateString().Replace(" ", "").Substring(0, 10));
                            }
                            else
                            {
                                file.WriteLine("\t\t\t\t  Dátum: " + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10));
                            }



                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            if (medicineRB.Checked) file.WriteLine("\t\t" + "Gyógyszer neve" + "\t\t" + " Összmennyiség" + "\t\t" + " Összár(LEI) ");
                            else file.WriteLine("\t\t" + "Pelenka neve" + "\t\t" + " Összmennyiség" + "\t\t" + " Összár(LEI) ");
                            file.WriteLine("\n");
                            foreach (DataGridViewRow row in totalizeDGV.Rows)
                            {
                                if (row.Index < totalizeDGV.RowCount - 1)
                                {
                                    if (row.Cells[0].Value.ToString().Length < 8)
                                    {
                                        file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t\t" + row.Cells[1].Value.ToString() + "\t\t" + row.Cells[2].Value.ToString());
                                    }
                                    else
                                    {
                                        if (row.Cells[0].Value.ToString().Length < 16) file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t" + row.Cells[1].Value.ToString() + "\t\t" + row.Cells[2].Value.ToString());
                                        else file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t" + row.Cells[1].Value.ToString() + "\t\t" + row.Cells[2].Value.ToString());
                                    }
                                }
                            }
                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            file.WriteLine("\t\t\t\t" + " Végösszeg: " + totalPriceTB.Text + " LEI");
                        }
                        MessageBox.Show("Az adatok fájlba irása sikeresen megtörtént! ", " Figyelem! ");
                        filenameTB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show(" Töltsd ki a file nevét tartalmazó mezőt! ", " Figyelem! ");
                }
            }
            else
            {
                //MessageBox.Show("burgonya");
                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                var last = month.AddDays(-1);
                if (filenameTB.Text.Replace(" ", "") != "")
                {
                    string filePath = System.IO.Directory.GetCurrentDirectory();
                    string dbFile = filePath.Substring(0, filePath.Length - 9) + "FilesToPrint" + @"\" + filenameTB.Text.Replace(" ", "") + ".txt";
                    if (File.Exists(dbFile))
                    {
                        MessageBox.Show(" Ez a fájlnév már létezik! ", " Figyelem! ");
                        filenameTB.Text = "";
                    }
                    else
                    {
                        using (StreamWriter file = new StreamWriter(dbFile, false))
                        {
                            if (lastMonthRB.Checked)
                            {
                                file.WriteLine("\t\t\t\t  Dátum: " + first.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + last.ToShortDateString().Replace(" ", "").Substring(0, 10));
                            }
                            else
                            {
                                file.WriteLine("\t\t\t\t  Dátum: " + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10));
                            }



                            file.WriteLine("\n");
                            if (medicineRB.Checked) file.WriteLine("\t\t\t\t\t   Gyógyszerek");
                            else file.WriteLine("\t\t\t\t\t   Pelenkák");
                            file.WriteLine("\n");
                            file.WriteLine("\t\t\t" + "Személy neve" + "\t\t\t" + " Összár(LEI) ");
                            file.WriteLine("\n");
                            foreach (DataGridViewRow row in totalizeDGV.Rows)
                            {
                                if (row.Index < totalizeDGV.RowCount - 1)
                                {
                                    if (row.Cells[0].Value.ToString().Length < 8)
                                    {
                                        file.WriteLine("\t\t\t" + row.Cells[0].Value.ToString() + "\t\t\t\t" + row.Cells[1].Value.ToString());
                                    }
                                    else
                                    {
                                        if (row.Cells[0].Value.ToString().Length < 16) file.WriteLine("\t\t\t" + row.Cells[0].Value.ToString() + "\t\t\t" + row.Cells[1].Value.ToString());
                                        else file.WriteLine("\t\t\t" + row.Cells[0].Value.ToString() + "\t\t" + row.Cells[1].Value.ToString());
                                    }
                                }
                            }
                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            file.WriteLine("\t\t\t\t" + " Végösszeg: " + totalPriceTB.Text + " LEI");
                        }
                        MessageBox.Show("Az adatok fájlba irása sikeresen megtörtént! ", " Figyelem! ");
                        filenameTB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show(" Töltsd ki a file nevét tartalmazó mezőt! ", " Figyelem! ");
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string temp = "";
            string filePath = System.IO.Directory.GetCurrentDirectory();
            ofd.Filter = "*.txt|*.txt";
            ofd.InitialDirectory = filePath.Substring(0, filePath.Length - 9) + "FilesToPrint";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                temp = ofd.FileName;
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = temp;
                myProcess.Start();
            }
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            loadFileLB.BackColor = Color.YellowGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            loadFileLB.BackColor = Color.White;
        }

        private void mentBTN_MouseEnter(object sender, EventArgs e)
        {
            saveIntoFileBTN.BackColor = Color.YellowGreen;
        }

        private void mentBTN_MouseLeave(object sender, EventArgs e)
        {
            saveIntoFileBTN.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            listAfterNameBTN.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            listAfterNameBTN.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medicineRB.Checked)
            {
                totalizeDGV.Rows.Clear();
                totalizeDGV.Refresh();
                totalizeDGV.Columns.Clear();

                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                var last = month.AddDays(-1);
                if (lastMonthRB.Checked)
                {
                    TotalizeMedicinesPerName(first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok where Adagok.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
                else
                {
                    TotalizeMedicinesPerName(firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok where Adagok.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
            }
            else
            {
                totalizeDGV.Rows.Clear();
                totalizeDGV.Refresh();
                totalizeDGV.Columns.Clear();

                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                var last = month.AddDays(-1);
                if (lastMonthRB.Checked)
                {
                    TotalizeNappiesPerName(first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka where AdagokPelenka.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
                else
                {
                    TotalizeNappiesPerName(firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka where AdagokPelenka.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
            }
        }

        private void gyogyszerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (medicineRB.Checked)
            {
                label1.Text = "Kapott gyógyszerek";
                UpdateDatagridview();
            }
            else
            {
                label1.Text = "   Kapott pelenkák";
                UpdateDatagridview();
            }
        }
    }
}
