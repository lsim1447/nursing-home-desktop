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
    public partial class InputWindow : Form
    {
        private InsertionClass insert = new InsertionClass();
        private UploadsClass myFeltoltesek = new UploadsClass();
        private DoseClass m_dose = new DoseClass();
        private CheckClass check = new CheckClass();
        private int whichOption;
        private string name;
        public InputWindow(string par, int nr)
        {
            InitializeComponent();
            if (nr == 1) label1.Text = "Add meg a gyógyszer új nevét!";
            else if (nr == 2) label1.Text = "Add meg a pelenka új nevét!";
            else if (nr == 3) label1.Text = "Add meg a személy új nevét!";
            else if (nr == 4) label1.Text = "Add meg az új személyi számot!";

            whichOption = nr;
            name = par;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newNameTB.Text.Replace(" ", "") != "")
            {
                if (whichOption == 1)
                {
                    string exist = m_dose.taroltEljaras("select count(Gyogyszerek.GyogyszerID) from Gyogyszerek where Gyogyszerek.Nev = '" + newNameTB.Text + "'");
                    if (exist != "0")
                    {
                        MessageBox.Show(" Ez a gyógyszernév már létezik! ", " Figyelem! ");
                        newNameTB.Text = "";
                    }
                    else
                    {
                        string err = m_dose.taroltEljaras("update Gyogyszerek set Nev = '" + newNameTB.Text + "' where Nev = '" + name + "'");
                        if (err == "-")
                        {
                            MessageBox.Show("A módositás sikeres volt!", " Figyelem! ");
                        }
                        else
                        {
                            MessageBox.Show("A módositás sikertelen volt!", " Figyelem! ");
                        }
                        this.Close();
                    }
                }
                else if (whichOption == 2)
                {
                    string exist = m_dose.taroltEljaras("select count(Pelenkak.PelenkaID) from Pelenkak where Pelenkak.Nev = '" + newNameTB.Text + "'");
                    if (exist != "0")
                    {
                        MessageBox.Show(" Ez a pelenkanév már létezik! ", " Figyelem! ");
                        newNameTB.Text = "";
                    }
                    else
                    {
                        string err = m_dose.taroltEljaras("update Pelenkak set Nev = '" + newNameTB.Text + "' where Nev = '" + name + "'");
                        if (err == "-")
                        {
                            MessageBox.Show("A módositás sikeres volt!", " Figyelem! ");
                        }
                        else
                        {
                            MessageBox.Show("A módositás sikertelen volt!", " Figyelem! ");
                        }
                        this.Close();
                    }
                }
                else if (whichOption == 3)
                {
                    if (newNameTB.Text.Replace(" ", "") != "")
                    {
                        string err = m_dose.taroltEljaras("update Szemelyek set Nev = '" + newNameTB.Text + "' where Nev = '" + name + "'");
                        if (err == "-") MessageBox.Show("A módositás sikeres volt!", " Figyelem! ");
                        else MessageBox.Show("A módositás sikertelen volt!", " Figyelem! ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Töltsd ki az üres mezőt! ", " Figyelem! ");
                    }
                }
                else if (whichOption == 4)
                {
                    string tempDate = newNameTB.Text.Substring(5, 2) + "-" + newNameTB.Text.Substring(3, 2) + "-" + "19" + newNameTB.Text.Substring(1, 2);
                    if (check.CnpCheckAssay(tempDate))
                    {
                        if (newNameTB.Text.Replace(" ", "").Length == 13)
                        {
                            string perName = m_dose.taroltEljaras("select Szemelyek.Nev from Szemelyek where CNP = '" + name + "'");
                            insert.CNPmodified(name, newNameTB.Text, perName);
                            this.Close();
                            MessageBox.Show("A módositás sikeres volt!", " Figyelem! ");
                        }
                        else
                        {
                            MessageBox.Show("A CNP-nek kötelezően 13 karaktert kell tartalmaznia!", "Figyelem!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Érvénytelen/helytelen személyi szám!", " Figyelem!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Töltsd ki az üres mezőt! ", " Figyelem! ");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
