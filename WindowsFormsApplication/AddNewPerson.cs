using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VersenyekSQL
{
    public partial class AddNewPerson : Form
    {
        private string userName;
        private InsertionClass m_insert =  new InsertionClass();
        private DeleteClass m_delete = new DeleteClass();
        private DoseClass m_dose = new DoseClass();
        private PersonClass m_person = new PersonClass();
        private CheckClass check = new CheckClass();

        public AddNewPerson(string par)
        {
            userName = par;
            InitializeComponent();
            UpdateDGV();
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            foreach (DataGridViewRow row in personDGV.Rows)
            {
                row.Height = 26;
            }
            personDGV.ReadOnly = true;
        }

        private void UpdateDGV()
        {
            personDGV.Rows.Clear();
            List<PersonStruct> persList = m_person.GetPersonDataList();
            personDGV.ColumnCount = 3;
            personDGV.Columns[0].Name = "Személy neve";
            personDGV.Columns[0].Width = 250;
            personDGV.Columns[1].Name = "Személyi szám";
            personDGV.Columns[1].Width = 200;
            personDGV.Columns[2].Name = "Életkor";
            personDGV.Columns[2].Width = 95;

            foreach (PersonStruct item in persList)
            {
                personDGV.Rows.Add(item.szemelyName, item.szemelyCNP, item.eletkor);
            }
            foreach (DataGridViewRow row in personDGV.Rows)
            {
                row.Height = 26;
            }
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Close();
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            string err;
            string exist = m_dose.taroltEljaras("select COUNT(Szemelyek.CNP) from Szemelyek where Szemelyek.Nev = '" + personNameTB.Text + "'");
            if (exist != "0")
            {
                MessageBox.Show(" Ez a személy már létezik! ", " Figyelem! ");
            }
            else if (personNameTB.Text != "")
            {

                    if (cnpTB.Text != "")
                    {
                        try
                        {
                            if (cnpTB.Text.Length == 13)
                            {
                                string tempDate = cnpTB.Text.Substring(5, 2) + "-" + cnpTB.Text.Substring(3, 2) + "-" + "19" + cnpTB.Text.Substring(1, 2);
                                if (check.CnpCheckAssay(tempDate))
                                {
                                    err = m_insert.InsertNewPerson(personNameTB.Text, cnpTB.Text);
                                    MessageBox.Show("Új személy sikeresen hozzáadva!");
                                    cnpTB.Text = "";
                                    personNameTB.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show(" Érvénytelen/helytelen személyi szám!"," Figyelem!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("A CNP-nek kötelezően 13 karaktert kell tartalmaznia!", "Figyelem!");
                            }
                        }
                        catch(Exception){
                            MessageBox.Show("Az életkor csupán számokat tartalmazhat!", " Figyelem! ");
                        }
                        UpdateDGV();
                    }
                    else
                    {
                        MessageBox.Show("Add meg a személyi számod (is)!", " Figyelem! ");
                    }
            }
            else
            {
                MessageBox.Show("Add meg a neved (is)! ", " Figyelem! ");
            }

        }

        private void embertTorol_Click(object sender, EventArgs e)
        {
            if (personDGV.SelectedRows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd?", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string delete = personDGV.SelectedRows[0].Cells["Személy neve"].Value.ToString();
                    string err = m_delete.DeletePerson(delete);

                    UpdateDGV();
                    MessageBox.Show("A törlés sikeres volt!");
                }
                else
                {
                    //do something
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen név sem! Kérlek válassz ki egy nevet! ","Figyelem!");
            }
        }

        private void Hozzaad_MouseEnter(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.YellowGreen;
        }

        private void Hozzaad_MouseLeave(object sender, EventArgs e)
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

        private void embertTorol_MouseEnter(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.Red;
        }

        private void embertTorol_MouseLeave(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.White;
        }

        private void CloseAndUpdate(object sender, System.EventArgs e)
        {
            UpdateDGV();
        }

        private void emberekDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                InputWindow iw = new InputWindow(personDGV.SelectedCells[0].Value.ToString(), 3);
                iw.Show();
                iw.FormClosed += new FormClosedEventHandler(CloseAndUpdate);
            }
            else if (e.ColumnIndex == 1)
            {
                InputWindow iw = new InputWindow(personDGV.SelectedCells[0].Value.ToString(), 4);
                iw.Show();
                iw.FormClosed += new FormClosedEventHandler(CloseAndUpdate);
            }
        }
    }
}
