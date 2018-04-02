using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersenyekSQL
{
    public partial class AddNewNappyDose : Form
    {
        private string userName;
        private PersonClass m_person = new PersonClass();
        private NappyClass m_nappy = new NappyClass();
        private StoredProcedureRetClass m_storedproc = new StoredProcedureRetClass();
        private InsertionClass m_insert = new InsertionClass();
        private Boolean tempBool = false;
        private DoseClass m_dose = new DoseClass();
        private DeleteClass m_delete = new DeleteClass();
        private Tranzaction m_tranz = new Tranzaction();
        private int counter;
        public AddNewNappyDose(string par)
        {
            InitializeComponent();
            userName = par;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            personNameComboFill(personNameCB);
            personNameComboFill(yestNameCB);
            NappyNameComboFill();
            nappyNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            personNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            yestNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateDGV(-1);
            nappyYestDGV.Columns[0].ReadOnly = true;
            nappyYestDGV.Columns[1].ReadOnly = true;
            dateTimePicker2.Value = DateTime.Today.AddDays(-1);
            tempBool = true;
            counter = 0;
            foreach (DataGridViewRow row in nappyYestDGV.Rows)
            {
                row.Height = 30;
            }
        }

        private void Vissza_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void Vissza_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            MainWindow fo =  new MainWindow(userName);
            fo.Show();
            this.Close();
        }

        private void mehetBTN_MouseEnter(object sender, EventArgs e)
        {
            mehetBTN.BackColor = Color.YellowGreen;
        }

        private void mehetBTN_MouseLeave(object sender, EventArgs e)
        {
            mehetBTN.BackColor = Color.White;
        }

        public void personNameComboFill(ComboBox k)
        {
            List<PersonStruct> persList = m_person.GetPersonNameList();
            k.DataSource = persList;
            k.DisplayMember = "szemelyName";
        }

        public void NappyNameComboFill()
        {
            List<NappyStruct> nappyList = m_nappy.GetNappyNameList("2");
            nappyNameCB.DataSource = nappyList;
            nappyNameCB.DisplayMember = "pelenkaName";
        }

        private void mehetBTN_Click(object sender, EventArgs e)
        {
            if (CounterUpDown.Value.ToString().Replace(" ", "") != ""){
                try
                {
                    string error = "";
                    error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'"); 
                    string date = dateTimePicker1.Value.ToShortDateString().Replace(" ", "").Substring(0, 10).Replace(".", "-");
                    
                    int ret = m_tranz.AddNewNappyDose(personNameCB.Text, nappyNameCB.Text, dateTimePicker1.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10), Convert.ToInt32(CounterUpDown.Value),  userName);
                    if (ret == 1)
                    {
                        UpdateDGV(1);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Nincs elegendő mennyiségű pelenka a raktáron! \n A megmaradt mennyiséget igy is hozzáadjam?", "Nincs elegendő pelenka", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string err = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                            string rest = m_insert.AddAllNappy(personNameCB.Text, nappyNameCB.Text, date, Convert.ToInt32(err));
                            UpdateDGV(1);
                        }
                    }
                }
                catch(Exception){
                    MessageBox.Show("A Mennyiség mező csupán egész számot tartalmazhat!", " Figyelem!");
                }
            }
            else{
                MessageBox.Show(" Kérlek töltsd ki a Mennyiség mezőt is! "," Figyelem! ");
            }
        }

        private void UpdateDGV(int k)
        {
            nappyYestDGV.Rows.Clear();
            string date;
            string name = "";
            if (k == -1)
            {
                name = m_dose.SzemelyNev("select top 1 Szemelyek.Nev from Szemelyek order by Nev");
                date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            }
            else
            {
                name = yestNameCB.Text;
                date = dateTimePicker2.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10);
            }

            List<DoseStruct> doseList = m_dose.GetTegnapKapottPelenkak(date, name);
            nappyYestDGV.ColumnCount = 4;
            nappyYestDGV.Columns[0].Name = "Személy neve";
            nappyYestDGV.Columns[0].Width = 273;
            nappyYestDGV.Columns[1].Name = "Pelenka";
            nappyYestDGV.Columns[1].Width = 290;
            nappyYestDGV.Columns[2].Name = "Mennyiség";
            nappyYestDGV.Columns[2].Width = 160;
            nappyYestDGV.Columns[3].Name = "AdagAra";
            nappyYestDGV.Columns[3].Width = 117;
            nappyYestDGV.Columns[3].Visible = false;
            foreach (DoseStruct item in doseList)
            {
                nappyYestDGV.Rows.Add(item.SzemelyNev, item.GyogyszerNev, item.Mennyiseg, item.Ar);
            }
            foreach (DataGridViewRow row in nappyYestDGV.Rows)
            {
                row.Height = 30;
            }
        }

        private void tegnapiNevCB_TextChanged(object sender, EventArgs e)
        {
            UpdateDGV(1);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            reAddBTN.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            reAddBTN.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("                   Ezek az adatok a kiválasztott Új dátum-ra lennének lementve!   \n                   Biztosan hozzá akarja adni ezeket az adatokat adatbázishoz?", "  Hozzáadás  ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int tempM = 0;
                int errMenny = 0;
                string date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                string today = dateTimePicker3.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10);
                foreach (DataGridViewRow row in nappyYestDGV.Rows)
                {
                    if (row.Index < nappyYestDGV.RowCount - 1)
                    {
                        try
                        {
                            tempM = Convert.ToInt32(row.Cells[2].Value.ToString());
                        }
                        catch (Exception)
                        {
                            errMenny = -1;
                        }
                    }
                }
                if (errMenny == -1)
                {
                    MessageBox.Show("A 'Mennyiség' oszlopban csak számok szerepelhetnek! ", "Figyelem!");
                }
                else if (errMenny != -1)
                {
                    HashSet<string> set = new HashSet<string>();
                    foreach (DataGridViewRow row in nappyYestDGV.Rows)
                    {
                        if ((row.Index < nappyYestDGV.RowCount - 1))
                        {
                            set.Add(row.Cells[1].Value.ToString());
                        }
                    }
                    int[] mx = new int[50];
                    int szamlalo = -1;
                    foreach (string gyNev in set)
                    {
                        szamlalo++;
                        foreach (DataGridViewRow row in nappyYestDGV.Rows)
                        {
                            if ((row.Index < nappyYestDGV.RowCount - 1))
                            {
                                if (row.Cells[1].Value.ToString() == gyNev)
                                {
                                    mx[szamlalo] += Convert.ToInt32(row.Cells[2].Value);
                                }
                            }
                        }
                    }
                    int MM = -1;
                    bool oke = true;
                    int i = 0;
                    int errorr = -1;
                    try
                    {
                        while (i <= szamlalo && oke)
                        {
                            MM = Convert.ToInt32(m_dose.taroltEljaras("select sum(RaktaronPelenka.Mennyiseg) from RaktaronPelenka, Pelenkak where RaktaronPelenka.PelenkaID = Pelenkak.PelenkaID and Pelenkak.Nev = '" + set.ElementAt(i) + "'"));
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
                            m_tranz.AddYesterdayNappyDose(nappyYestDGV, userName, today);
                            //foreach (DataGridViewRow row in nappyYestDGV.Rows)
                            //{
                            //    if ((row.Index < nappyYestDGV.RowCount - 1))
                            //    {
                            //        string error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                            //        string mufurc = m_storedproc.AddNewNappyDose(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), today, Convert.ToInt32(row.Cells[2].Value.ToString()), Convert.ToInt32(error), ref error);
                            //    }
                            //}
                            
                        }
                    }catch(Exception){
                        MessageBox.Show("Bizonyos pelenkafajtákból nincs elegendő a raktáron, kérlek ellenőrizd a raktáron lévő pelenkamennyiségeket!", " Figyelem!");
                    }

                }

            }
            else
            {
                // else do something  --- dont do anything
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nappyYestDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("                       Biztosan szeretnéd eltávolitani ezt a sort? \n Ezzel az eltávolitással a kijelölt adagok nem lesznek hozzáadva az új adagoláshoz, viszont a régi adatok megmaradnak! ", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewCell oneCell in nappyYestDGV.SelectedCells)
                    {
                        if (oneCell.Selected) nappyYestDGV.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen sor sem! ", "Figyelem!");
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            dropRowBTN.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            dropRowBTN.BackColor = Color.White;
        }

        private void szemelyNevCB_MouseEnter(object sender, EventArgs e)
        {
            personNameCB.BackColor = Color.YellowGreen;
        }

        private void pelenkaNevCB_MouseEnter(object sender, EventArgs e)
        {
            nappyNameCB.BackColor = Color.YellowGreen;
        }

        private void tegnapiNevCB_MouseEnter(object sender, EventArgs e)
        {
            yestNameCB.BackColor = Color.YellowGreen;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (tempBool) UpdateDGV(1);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            deleteSelectedRowBTN.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            deleteSelectedRowBTN.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nappyYestDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("                       Biztosan törölni szeretnéd ezt az adagolást? \n Amennyiben igen, az adott adagolás törölve lesz és a törölt mennyiség visszakerül a raktárba.", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string persID = m_dose.taroltEljaras("select Szemelyek.CNP from Szemelyek where Nev = '" + nappyYestDGV.SelectedRows[0].Cells["Személy neve"].Value.ToString() + "'");
                    string medID = m_dose.taroltEljaras("select Pelenkak.PelenkaID from Pelenkak where Nev = '" + nappyYestDGV.SelectedRows[0].Cells["Pelenka"].Value.ToString() + "'");
                    string num = nappyYestDGV.SelectedRows[0].Cells["Mennyiség"].Value.ToString();
                    string date = dateTimePicker2.Value.ToShortDateString().Replace(".", "-").Replace(" ", "").Substring(0, 10);
                    string pc = nappyYestDGV.SelectedRows[0].Cells["AdagAra"].Value.ToString();
                    string error = m_delete.DeleteAndRecoverNappy(persID, medID, num, date, pc);
                    UpdateDGV(1);
                    MessageBox.Show(" A törlés és visszaállitás sikeresen megtörtént! ", " Figyelem! ");
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen sor sem! ", "Figyelem!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 != 0)
            {
                rectangleShape2.Visible = false;
                label10.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                yestNameCB.Visible = false;
                dateTimePicker2.Visible = false;
                dateTimePicker3.Visible = false;
                nappyYestDGV.Visible = false;
                reAddBTN.Visible = false;
                dropRowBTN.Visible = false;
                deleteSelectedRowBTN.Visible = false;
                label7.Text = "Korábbi adatok megjelenitése(katt ide)";
            }
            else
            {
                rectangleShape2.Visible = true;
                label10.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                yestNameCB.Visible = true;
                dateTimePicker2.Visible = true;
                dateTimePicker3.Visible = true;
                nappyYestDGV.Visible = true;
                reAddBTN.Visible = true;
                dropRowBTN.Visible = true;
                deleteSelectedRowBTN.Visible = true;
                label7.Text = "Korábbi adatok elrejtése(katt ide)";
            }
        }
    }
}
