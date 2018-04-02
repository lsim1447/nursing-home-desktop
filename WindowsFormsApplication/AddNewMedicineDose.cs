using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Common;
using System.Threading;
using System.Globalization;
using System.Collections;

namespace VersenyekSQL
{
    public partial class AddNewDose : Form
    {
        private int counter = 0;
        private string userName;
        private MedicineClass m_medicine = new MedicineClass();
        private PersonClass m_person = new PersonClass();
        private PartOfTheDayClass m_partOfTheDay = new PartOfTheDayClass();
        private InsertionClass m_insert = new InsertionClass();
        private StoredProcedureRetClass storedProc = new StoredProcedureRetClass();
        private DeleteClass m_delete = new DeleteClass();
        private DoseClass m_dose = new DoseClass();
        private Boolean tempBool = false;
        private CheckClass check = new CheckClass();
        private Tranzaction m_tranz;

        public AddNewDose(string par)
        {
            userName = par;
            m_tranz = new Tranzaction();
            InitializeComponent();
            MedNameComboFill();
            PersonNameComboFill(persNameCB);
            PersonNameComboFill(personTNameCB);
            PartOfTheDayComboFill();
            reAddBTN.Visible = true;
            yesterdayDGV.Visible = true;
            personTNameCB.Visible = true;
            tegnapiNev.Visible = true;
            UpdateOldDataDGV(-1);
            yesterdayDGV.Columns[0].ReadOnly = true;
            yesterdayDGV.Columns[1].ReadOnly = true;
            persNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            medNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            partOfTheDayCB.DropDownStyle = ComboBoxStyle.DropDownList;
            personTNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            oldDatePicker.Value = DateTime.Today.AddDays(-1);
            tempBool = true;
            foreach (DataGridViewRow row in yesterdayDGV.Rows)
            {
                row.Height = 30;
            }
        }

        private void UpdateOldDataDGV(int k)
        {
            yesterdayDGV.Rows.Clear();
            string date;
            string name = "";
            if (k == -1)
            {
                date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                name = m_dose.SzemelyNev("select top 1 Szemelyek.Nev from Szemelyek order by Nev");
            }
            else
            {
                name = personTNameCB.Text;
                date = oldDatePicker.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10);
            }

            List<DoseStruct> doseList = m_dose.GetAdagCucc(date, name);
            yesterdayDGV.ColumnCount = 5;
            yesterdayDGV.Columns[0].Name = "Személy neve";
            yesterdayDGV.Columns[0].Width = 250;
            yesterdayDGV.Columns[1].Name = "Gyógyszer neve";
            yesterdayDGV.Columns[1].Width = 295;
            yesterdayDGV.Columns[2].Name = "Napszak";
            yesterdayDGV.Columns[2].Width = 100;
            yesterdayDGV.Columns[3].Name = "Mennyiség";
            yesterdayDGV.Columns[3].Width = 133;
            yesterdayDGV.Columns[4].Name = "AdagAra";
            yesterdayDGV.Columns[4].Width = 100;
            yesterdayDGV.Columns[4].Visible = false;

            foreach (DoseStruct item in doseList)
            {
                string unit = m_dose.taroltEljaras("select Gyogyszerek.Mertekegyseg from Gyogyszerek where Nev = '" + item.GyogyszerNev + "'");
                yesterdayDGV.Rows.Add(item.SzemelyNev, item.GyogyszerNev, item.Napszak, item.MennyisegF + " " + unit, item.Ar);
            }
            foreach (DataGridViewRow row in yesterdayDGV.Rows)
            {
                row.Height = 30;
            }
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Hide();
        }

        public void MedNameComboFill()
        {
            List<MedicineStruct> medName = m_medicine.GetAllMedicineNameIntoStorage();
            medNameCB.DataSource = medName;
            medNameCB.DisplayMember = "gyogyszerName";
        }
        public void PersonNameComboFill(ComboBox k)
        {
            List<PersonStruct> personList = m_person.GetPersonNameList();
            k.DataSource = personList;
            k.DisplayMember = "szemelyName";
        }
        public void PartOfTheDayComboFill()
        {
            List<PartOfTheDayStruct> potd = m_partOfTheDay.GetPartOfTheDayList();
            partOfTheDayCB.DataSource = potd;
            partOfTheDayCB.DisplayMember = "napszakName";
        }
        private void mehetBTN_Click(object sender, EventArgs e)
        {
            if (persNameCB.Text.Replace(" ", "") != "")
            {
                if (medNameCB.Text.Replace(" ", "") != "")
                {
                    if (partOfTheDayCB.Text.Replace(" ", "") != "")
                    {
                        if (numTB.Text.Replace(" ", "") != "")
                        {
                            try
                            {
                                string date = dateTimePicker.Value.ToShortDateString().Replace(".", "-").Replace(" ","").Substring(0, 10);
                                string error = "";
                                error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                                int mufurc = m_tranz.AddNewMedDose(persNameCB.Text, medNameCB.Text, partOfTheDayCB.Text, date, numTB.Text.Replace(".", ","), userName);
                                if (mufurc == 1)
                                {
                                    UpdateOldDataDGV(1);
                                }
                                else
                                {
                                    DialogResult dialogResult = MessageBox.Show("Nincs elegendő mennyiségű gyógyszer a raktáron! \n A megmaradt mennyiséget igy is hozzáadjam?", "Nincs elegendő gyógyszer", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        string pname = persNameCB.Text;
                                        string medName = medNameCB.Text;
                                        string partName = partOfTheDayCB.Text;
                                        string err = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                                        int tempID = Convert.ToInt32(err);
                                        string maradek = m_insert.AddAllMedicine(pname, medName, partName, date, tempID);
                                        numTB.Text = "";
                                        UpdateOldDataDGV(1);
                                    }
                                    else if (dialogResult == DialogResult.No)
                                    {

                                    }
                                }
                                numTB.Text = "";
                                persNameCB.Text = "";
                                medNameCB.Text = "";
                                partOfTheDayCB.Text = "";
                                error = "";
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("A 'Mennyiség' mező kötelezően egész számot kell tartalmazzon!");
                                numTB.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show(" Add meg a mennyiséget (is)!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Válaszd ki a napszakot! ");
                    }
                }
                else
                {
                    MessageBox.Show(" Add meg a gyógyszer nevét! ");
                }
            }
            else{
                MessageBox.Show(" Add meg a személy nevét! ");
            }
        }

        private void valtakozoLabel_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            if (counter % 2 != 0)
            {
                yesterdayDGV.Visible = false;
                valtakozoLabel.Text = "Korábbi adatok betöltése(katt ide)";
                reAddBTN.Visible = false;
                personTNameCB.Visible = false;
                tegnapiNev.Visible = false;
                rectangleShape2.Visible = false;
                dropRowBTN.Visible = false;
                label7.Visible = false;
                oldDatePicker.Visible = false;
                newDatePicker.Visible = false;
                label8.Visible = false;
                deleteRowBTN.Visible = false;
            }
            else
            {
                deleteRowBTN.Visible = true;
                label7.Visible = true;
                personTNameCB.Visible = true;
                tegnapiNev.Visible = true;
                yesterdayDGV.Visible = true;
                valtakozoLabel.Text = "Korábbi adatok elrejtése(katt ide)";
                reAddBTN.Visible = true;
                rectangleShape2.Visible = true;
                dropRowBTN.Visible = true;
                label8.Visible = true;
                newDatePicker.Visible = true;
                oldDatePicker.Visible = true;
            }
        }

        private void tegnapiCB_TextChanged(object sender, EventArgs e)
        {
            UpdateOldDataDGV(1);
        }

        private void tegnapiBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("                   Ezek az adatok a kiválasztott Új dátum-ra lennének lementve!   \n                   Biztosan hozzá akarja adni ezeket az adatokat adatbázishoz?", "  Hozzáadás  ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                float tempM = 0;
                int errDay = 0;
                int errMenny = 0;
                string date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                string today = newDatePicker.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10);
                foreach (DataGridViewRow row in yesterdayDGV.Rows)
                {
                    if (row.Index < yesterdayDGV.RowCount - 1)
                    {
                        try
                        {
                            tempM = Convert.ToSingle(row.Cells[3].Value.ToString().Substring(0, row.Cells[3].Value.ToString().IndexOf(" ") + 1));
                        }
                        catch (Exception)
                        {
                            errMenny = -1;
                        }
                        if (row.Cells[2].Value.ToString().ToUpper() != "REGGEL" && row.Cells[2].Value.ToString().ToUpper() != "DÉL" && row.Cells[2].Value.ToString().ToUpper() != "ESTE")
                        {
                            errDay = -1;
                        }
                    }
                }
                if (errMenny == -1)
                {
                    MessageBox.Show("A 'Mennyiség' oszlopban csak számok szerepelhetnek! ", "Figyelem!");
                }
                if (errDay == -1)
                {
                    MessageBox.Show(" A 'Napszak' oszlopban csak: 'REGGEL/DÉL/ESTE' értékek szerepelhetnek! ", "Figyelem!");
                }
                else if (errDay != -1 && errMenny != -1)
                {
                    // go forward, everything is oke
                    // MessageBox.Show("Everything is oke!");
                    HashSet<string> set = new HashSet<string>();
                    foreach (DataGridViewRow row in yesterdayDGV.Rows)
                    {
                        if ((row.Index < yesterdayDGV.RowCount - 1))
                        {
                            set.Add(row.Cells[1].Value.ToString());
                        }
                    }
                    float[] mx  = new float[50];
                    int counter = -1;
                    foreach (string gyNev in set)
                    {
                        counter++;
                        foreach (DataGridViewRow row in yesterdayDGV.Rows)
                        {
                            if ((row.Index < yesterdayDGV.RowCount - 1))
                            {
                                if (row.Cells[1].Value.ToString() == gyNev)
                                {
                                    mx[counter] += Convert.ToSingle(row.Cells[3].Value.ToString().Substring(0, row.Cells[3].Value.ToString().IndexOf(" ") + 1));
                                }
                            }
                        }   
                    }
                    float MM = -1;
                    bool oke = true;
                    int i = 0;
                    int errorr = -1;
                    try
                    {
                        while (i <= counter && oke)
                        {
                            MM = Convert.ToSingle(m_dose.taroltEljaras("select sum(Raktaron.Mennyiseg) from Raktaron, Gyogyszerek where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID and Gyogyszerek.Nev = '" + set.ElementAt(i) + "'"));
                            if (MM < mx[i])
                            {
                                errorr = i;
                                oke = false;
                            }
                            i++;
                        }
                        if (!oke)
                        {
                            MessageBox.Show(("          Nincs elegendő mennyiségű " + set.ElementAt(errorr) + "! \n               Csupán " + MM + " darab van belőle"), " Figyelem! ");
                        }
                        else
                        {
                            m_tranz.AddYesterdayMedicineDose(yesterdayDGV, userName, today);
                            //foreach (DataGridViewRow row in yesterdayDGV.Rows)
                            //{
                            //    if ((row.Index < yesterdayDGV.RowCount - 1))
                            //    {
                            //        string error = "";
                            //        error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                            //        string mufurc = storedProc.AddNewMedicineDose(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), today, Convert.ToSingle(row.Cells[3].Value.ToString().Substring(0, row.Cells[3].Value.ToString().IndexOf(" ") + 1)), Convert.ToInt32(error), ref error);
                            //    }
                            //}
                            //MessageBox.Show(" A gyógyszer adagolása sikeres volt! ", "Figyelem!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bizonyos gyógyszerekből nincs elegendő a raktáron, kérlek ellenőrizd a raktáron lévő gyógyszermennyiségeket!"," Figyelem!");
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (yesterdayDGV.SelectedRows.Count > 0){
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd? ", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewCell oneCell in yesterdayDGV.SelectedCells)
                    {
                        if (oneCell.Selected) yesterdayDGV.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
                else
                {
                    //do something
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen sor sem! ", "Figyelem!");
            }
        }

        private void mehetBTN_MouseEnter(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.YellowGreen;
        }

        private void mehetBTN_MouseLeave(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.White;
        }

        private void Vissza_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void Vissza_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void tegnapiBTN_MouseEnter(object sender, EventArgs e)
        {
            reAddBTN.BackColor = Color.YellowGreen;
        }

        private void tegnapiBTN_MouseLeave(object sender, EventArgs e)
        {
            reAddBTN.BackColor = Color.White;
        }

        private void tegnapiCB_MouseEnter(object sender, EventArgs e)
        {
            personTNameCB.BackColor = Color.YellowGreen;
        }

        private void szemelyNevCB_MouseEnter(object sender, EventArgs e)
        {
            persNameCB.BackColor = Color.YellowGreen;
        }

        private void gyogyszerNevCB_MouseEnter(object sender, EventArgs e)
        {
            medNameCB.BackColor = Color.YellowGreen;
        }

        private void napszakCB_MouseEnter(object sender, EventArgs e)
        {
            partOfTheDayCB.BackColor = Color.YellowGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yesterdayDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("                           Biztosan szeretnéd eltávolitani ezt a sort? \n Ezzel az eltávolitással a kijelölt adagok nem lesznek hozzáadva az új adagoláshoz, viszont a régi adatok megmaradnak! ", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewCell oneCell in yesterdayDGV.SelectedCells)
                    {
                        if (oneCell.Selected) yesterdayDGV.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen sor sem! ", "Figyelem!");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            dropRowBTN.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            dropRowBTN.BackColor = Color.White;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (tempBool) UpdateOldDataDGV(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yesterdayDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("                       Biztosan törölni szeretnéd ezt az adagolást? \n Amennyiben igen, az adott adagolás törölve lesz és a törölt mennyiség visszakerül a raktárba.", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string persID = m_dose.taroltEljaras("select Szemelyek.CNP from Szemelyek where Nev = '" + yesterdayDGV.SelectedRows[0].Cells["Személy neve"].Value.ToString() + "'");
                    string medID = m_dose.taroltEljaras("select Gyogyszerek.GyogyszerID from Gyogyszerek where Nev = '" + yesterdayDGV.SelectedRows[0].Cells["Gyógyszer neve"].Value.ToString() + "'");
                    string partID = m_dose.taroltEljaras("select top 1 Napszakok.NapszakID from Napszakok where Napszak = '" + yesterdayDGV.SelectedRows[0].Cells["Napszak"].Value.ToString() + "'");
                    string num = yesterdayDGV.SelectedRows[0].Cells["Mennyiség"].Value.ToString().Substring(0, yesterdayDGV.SelectedRows[0].Cells["Mennyiség"].Value.ToString().IndexOf(" ") + 1);
                    string date = oldDatePicker.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10);
                    string price = yesterdayDGV.SelectedRows[0].Cells["AdagAra"].Value.ToString();
                    string error = m_delete.DeleteAndRecoverMedicine(persID, medID, partID, num, date, price);
                    UpdateOldDataDGV(1);
                    MessageBox.Show(" A törlés és visszaállitás sikeresen megtörtént! ", " Figyelem! ");
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen sor sem! ", "Figyelem!");
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            deleteRowBTN.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            deleteRowBTN.BackColor = Color.White;
        }

        private void gyogyszerNevCB_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(gyogyszerNevCB.Text);
            string str = m_dose.taroltEljaras("select Gyogyszerek.Mertekegyseg from Gyogyszerek where Nev = '" + medNameCB.Text + "'");
            if (str == "ml")
            {
                label3.Text = "Mennyiség(ml):";
            }
            else
            {
                label3.Text = "Mennyiség:       ";
            }
        }
    }
}
