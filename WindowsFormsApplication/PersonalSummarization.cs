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
    public partial class PersonalSummarization : Form
    {
        string userName;
        private PersonClass m_person = new PersonClass();
        private DoseClass m_dose = new DoseClass();
        private bool ok = true;
        private OpenFileDialog ofd = new OpenFileDialog();
        private bool whichPrint = true;
        private CheckClass check = new CheckClass();

        public PersonalSummarization(string par)
        {
            InitializeComponent();
            userName = par;
            szemelyNevComboFill(nameCB);
            label3.Visible = false;
            label4.Visible = false;
            firstDatePicker.Visible = false;
            lastDatePicker.Visible = false;
            rectangleShape1.Visible = false;
            lastMonthRB.Checked = true;
            nameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ok = false;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            UpdateDatagridview();
            medicineRB.Checked = true;
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }

        private void visszaBTN_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Hide();
        }

        public void szemelyNevComboFill(ComboBox k)
        {
            List<PersonStruct> personList = m_person.GetPersonNameList();
            k.DataSource = personList;
            k.DisplayMember = "szemelyName";
        }

        private void egyHonap_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
            if (intervalRB.Checked)
            {
                label3.Visible = true;
                label4.Visible = true;
                firstDatePicker.Visible = true;
                lastDatePicker.Visible = true;
                rectangleShape1.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                firstDatePicker.Visible = false;
                lastDatePicker.Visible = false;
                rectangleShape1.Visible = false;
            }
        }

        private void TotalizeMedicineData(string nev, string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetOsszesitesek(nev, firstDate, secondDate);
            totalizeDGV.ColumnCount = 5;
            totalizeDGV.Columns[0].Name = "Gyógyszer neve";
            totalizeDGV.Columns[0].Width = 218;
            totalizeDGV.Columns[1].Name = "Dátum";
            totalizeDGV.Columns[1].Width = 95;
            totalizeDGV.Columns[2].Name = "Napszak";
            totalizeDGV.Columns[2].Width = 90;
            totalizeDGV.Columns[3].Name = "Mennyiség";
            totalizeDGV.Columns[3].Width = 105;
            totalizeDGV.Columns[4].Name = "Ár";
            totalizeDGV.Columns[4].Width = 95;

            foreach (DoseStruct item in doseList)
            {
                string unit = m_dose.taroltEljaras("select Gyogyszerek.Mertekegyseg from Gyogyszerek where Nev = '" + item.GyogyszerNev + "'");
                totalizeDGV.Rows.Add(item.GyogyszerNev, item.Datum, item.Napszak, check.PriceWithTwoPrecision(item.MennyisegF.ToString()) + " " + unit, check.PriceWithTwoPrecision(item.Ar.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }

        private void TotalizeNappyData(string nev, string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetOsszesitesekPelenka(nev, firstDate, secondDate);
            totalizeDGV.ColumnCount = 4;
            totalizeDGV.Columns[0].Name = "Pelenka";
            totalizeDGV.Columns[0].Width = 288;
            totalizeDGV.Columns[1].Name = "Dátum";
            totalizeDGV.Columns[1].Width = 105;
            totalizeDGV.Columns[2].Name = "Mennyiség";
            totalizeDGV.Columns[2].Width = 105;
            totalizeDGV.Columns[3].Name = "Ár";
            totalizeDGV.Columns[3].Width = 105;

            foreach (DoseStruct item in doseList)
            {
                totalizeDGV.Rows.Add(item.GyogyszerNev, item.Datum, item.Mennyiseg, check.PriceWithTwoPrecision(item.Ar.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }
        
        private void TotalConsumerismMedicine(string name, string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetTeljesOsszesitesNevszerint(name, firstDate, secondDate);
            totalizeDGV.ColumnCount = 3;
            totalizeDGV.Columns[0].Name = "Gyógyszer neve";
            totalizeDGV.Columns[0].Width = 300;
            totalizeDGV.Columns[1].Name = "Összmennyiség";
            totalizeDGV.Columns[1].Width = 150;
            totalizeDGV.Columns[2].Name = "Összár";
            totalizeDGV.Columns[2].Width = 153;

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

        private void TotalConsumerismNappy(string name, string firstDate, string secondDate)
        {
            totalizeDGV.Rows.Clear();
            List<DoseStruct> doseList = m_dose.GetTeljesOsszesitesNevszerintPelenka(name, firstDate, secondDate);
            totalizeDGV.ColumnCount = 3;
            totalizeDGV.Columns[0].Name = "Pelenka neve";
            totalizeDGV.Columns[0].Width = 300;
            totalizeDGV.Columns[1].Name = "Összmennyiség";
            totalizeDGV.Columns[1].Width = 150;
            totalizeDGV.Columns[2].Name = "Összár";
            totalizeDGV.Columns[2].Width = 153;

            foreach (DoseStruct item in doseList)
            {
                totalizeDGV.Rows.Add(item.GyogyszerNev, item.OsszMennyiseg, check.PriceWithTwoPrecision(item.Osszertek.ToString()));
            }
            foreach (DataGridViewRow row in totalizeDGV.Rows)
            {
                row.Height = 25;
            }
        }
        
        private void UpdateDatagridview()
        {
            if (medicineRB.Checked)
            {
                whichPrint = true;
                if (!ok)
                {
                    var today = DateTime.Today;
                    var month = new DateTime(today.Year, today.Month, 1);
                    var first = month.AddMonths(-1);
                    var last = month.AddDays(-1);
                    if (lastMonthRB.Checked)
                    {
                        TotalizeMedicineData(nameCB.Text, first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok, Szemelyek where Adagok.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "' and Adagok.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                    else
                    {
                        TotalizeMedicineData(nameCB.Text, firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok, Szemelyek where Adagok.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "' and Adagok.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                    filenameTB.Text = nameCB.Text;
                }
            }
            else
            {
                whichPrint = true;
                if (!ok)
                {
                    var today = DateTime.Today;
                    var month = new DateTime(today.Year, today.Month, 1);
                    var first = month.AddMonths(-1);
                    var last = month.AddDays(-1);
                    if (lastMonthRB.Checked)
                    {
                        TotalizeNappyData(nameCB.Text, first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka, Szemelyek where AdagokPelenka.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "' and AdagokPelenka.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                    else
                    {
                        TotalizeNappyData(nameCB.Text, firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                        totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka, Szemelyek where AdagokPelenka.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "' and AdagokPelenka.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                    }
                    filenameTB.Text = nameCB.Text;
                }
            }
        }

        private void nevCB_TextChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
        }

        private void kezdetiPicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
        }

        private void vegsoPicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagridview();
        }

        private void Osszesitesek_Load(object sender, EventArgs e)
        {
            UpdateDatagridview();
        }

        private void kiirBTN_Click(object sender, EventArgs e)
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
                    if (whichPrint)
                    {
                        using (StreamWriter file = new StreamWriter(dbFile, false))
                        {
                            if (medicineRB.Checked)
                            {
                                if (lastMonthRB.Checked)
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "\t" + "Dátum: " + first.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + last.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                                else
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "\t" + "Dátum: " + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                            }
                            else
                            {
                                if (lastMonthRB.Checked)
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "Dátum: " + first.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + last.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                                else
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "Dátum: " + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                            }


                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            if (medicineRB.Checked) file.WriteLine("\t\t" + "Gyógyszer neve" + "\t\t" + "Dátum" + "\t\t" + "Napszak" + "\t\t" + "Mennyiség");
                            else file.WriteLine("\t\t\t" + "Pelenka" + "\t\t\t\t" + "Dátum" + "\t\t" + "Mennyiség");
                            file.WriteLine("\n");
                            foreach (DataGridViewRow row in totalizeDGV.Rows)
                            {
                                if (row.Index < totalizeDGV.RowCount - 1)
                                {
                                    if (medicineRB.Checked)
                                    {
                                        if (row.Cells[0].Value.ToString().Length < 8)
                                        {
                                            file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t" + row.Cells[1].Value.ToString() + "\t" + row.Cells[2].Value.ToString() + "\t\t" + row.Cells[3].Value.ToString());
                                        }
                                        else
                                        {
                                            if (row.Cells[0].Value.ToString().Length < 16) file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t" + row.Cells[1].Value.ToString() + "\t" + row.Cells[2].Value.ToString() + "\t\t" + row.Cells[3].Value.ToString());
                                            else file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t" + row.Cells[1].Value.ToString() + "\t" + row.Cells[2].Value.ToString() + "\t\t" + row.Cells[3].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (row.Cells[0].Value.ToString().Length < 8)
                                        {
                                            file.WriteLine("\t\t\t" + row.Cells[0].Value.ToString() + "\t\t\t\t" + row.Cells[1].Value.ToString() + "\t" + row.Cells[2].Value.ToString());
                                        }
                                        else
                                        {
                                            if (row.Cells[0].Value.ToString().Length < 16) file.WriteLine("\t\t\t" + row.Cells[0].Value.ToString() + "\t\t\t" + row.Cells[1].Value.ToString() + "\t" + row.Cells[2].Value.ToString());
                                            else file.WriteLine("\t\t\t" + row.Cells[0].Value.ToString() + "\t\t" + row.Cells[1].Value.ToString() + "\t" + row.Cells[2].Value.ToString());
                                        }
                                    }
                                }
                            }
                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            file.WriteLine("\t\t\t\t\t" + " Végösszeg: " + totalPriceTB.Text + " LEI");
                        }
                    }
                    else
                    {
                        using (StreamWriter file = new StreamWriter(dbFile, false))
                        {
                            if (medicineRB.Checked)
                            {
                                if (lastMonthRB.Checked)
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "\t" + "Dátum: " + first.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + last.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                                else
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "\t" + "Dátum: " + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                            }
                            else
                            {
                                if (lastMonthRB.Checked)
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "Dátum: " + first.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + last.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                                else
                                {
                                    file.WriteLine("\t\t\t Név: " + nameCB.Text + "\t" + "Dátum: " + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10) + " - " + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10));
                                }
                            }


                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            if (medicineRB.Checked) file.WriteLine("\t\t" + "Gyógyszer neve" + "\t\t" + " Összmennyiség" + "\t\t" + "     Összár(LEI) ");
                            else file.WriteLine("\t\t" + "Pelenka" + "\t\t\t" + " Összmennyiség" + "\t\t" + "      Összár(LEI) ");
                            file.WriteLine("\n");
                            foreach (DataGridViewRow row in totalizeDGV.Rows)
                            {
                                if (row.Index < totalizeDGV.RowCount - 1)
                                {
                                    if (row.Cells[0].Value.ToString().Length < 8)
                                    {
                                        if (medicineRB.Checked) file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t\t" + row.Cells[1].Value.ToString() + "\t\t\t" + row.Cells[2].Value.ToString());
                                        else file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t\t" + row.Cells[1].Value.ToString() + "\t\t\t" + row.Cells[2].Value.ToString());
                                    }
                                    else
                                    {
                                        if (row.Cells[0].Value.ToString().Length < 16)
                                        {
                                            if (medicineRB.Checked) file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t" + row.Cells[1].Value.ToString() + "\t\t\t" + row.Cells[2].Value.ToString());
                                            else file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t\t" + row.Cells[1].Value.ToString() + "\t\t\t" + row.Cells[2].Value.ToString());
                                        }
                                        else
                                        {
                                            if (medicineRB.Checked) file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t" + row.Cells[1].Value.ToString() + "\t\t\t" + row.Cells[2].Value.ToString());
                                            else file.WriteLine("\t\t" + row.Cells[0].Value.ToString() + "\t\t" + row.Cells[1].Value.ToString() + "\t\t\t" + row.Cells[2].Value.ToString());
                                        }
                                    }
                                }
                            }
                            file.WriteLine("\n");
                            file.WriteLine("\n");
                            if (nappyRB.Checked) file.WriteLine("\t\t\t\t" + " Végösszeg: " + totalPriceTB.Text + " LEI");
                            else file.WriteLine("\t\t\t\t\t" + " Végösszeg: " + totalPriceTB.Text + " LEI");
                        }
                    }
                    MessageBox.Show("Az adatok fájlba irása sikeresen megtörtént! ", " Figyelem! ");
                    filenameTB.Text = "";
                }
            }
            else{
                MessageBox.Show(" Töltsd ki a file nevét tartalmazó mezőt! ", " Figyelem! ");
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
            loadFromFileLB.BackColor = Color.YellowGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            loadFromFileLB.BackColor = Color.White;
        }

        private void visszaBTN_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void visszaBTN_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void nevCB_MouseEnter(object sender, EventArgs e)
        {
            nameCB.BackColor = Color.YellowGreen;
        }

        private void nevCB_MouseLeave(object sender, EventArgs e)
        {
            nameCB.BackColor = Color.White;
        }

        private void kiirBTN_MouseEnter(object sender, EventArgs e)
        {
            saveIntoFileBTN.BackColor = Color.YellowGreen;
        }

        private void kiirBTN_MouseLeave(object sender, EventArgs e)
        {
            saveIntoFileBTN.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            whichPrint = false;
            if (medicineRB.Checked)
            {
                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                var last = month.AddDays(-1);
                if (lastMonthRB.Checked)
                {
                    TotalConsumerismMedicine(nameCB.Text, first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok, Szemelyek where Adagok.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "'  and Adagok.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
                else
                {
                    TotalConsumerismMedicine(nameCB.Text, firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(Adagok.AdagAra) from Adagok, Szemelyek where Adagok.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "' and Adagok.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and Adagok.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
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
                    TotalConsumerismNappy(nameCB.Text, first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka, Szemelyek where AdagokPelenka.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "'  and AdagokPelenka.Datum >= '" + first.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + last.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
                else
                {
                    TotalConsumerismNappy(nameCB.Text, firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"), lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-"));
                    totalPriceTB.Text = check.PriceWithTwoPrecision(m_dose.taroltEljaras("select sum(AdagokPelenka.AdagAra) from AdagokPelenka, Szemelyek where AdagokPelenka.CNP = Szemelyek.CNP and Szemelyek.Nev = '" + nameCB.Text + "' and AdagokPelenka.Datum >= '" + firstDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "' and AdagokPelenka.Datum <= '" + lastDatePicker.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-") + "'"));
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            totalizeBTN.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            totalizeBTN.BackColor = Color.White;
        }

        private void gyogyszerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (medicineRB.Checked)
            {
                label7.Text = "A kapott gyógyszeradagok";
                UpdateDatagridview();
            }
            else
            {
                label7.Text = " A kapott pelenkaadagok";
                UpdateDatagridview();
            }
        }

    }
}
