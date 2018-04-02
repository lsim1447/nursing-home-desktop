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
    public partial class Register : Form
    {
        private EncryptsClass classify = new EncryptsClass();
        private PersonClass person = new PersonClass();
        private DoseClass m_dose = new DoseClass();
        private CheckClass check = new CheckClass();
        private string userName;

        public Register(string par)
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
            HozzaferesekComboFeltoltese();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (felhnev_reg.Text == "")
                MessageBox.Show("Adj meg egy userName nevet!!", "Figyelem!");
            else
            {
                string query = "SELECT FelhasznaloID FROM Felhasznalok WHERE FelhasznaloNev = '" + felhnev_reg.Text + "'";
                if (classify.Checker(query) == "-")
                {
                    if (emailTB.Text.Replace(" ", "") == "")
                    {
                        MessageBox.Show(" Töltsd ki az email-t tartalmazó mezőt is! ", "Figyelem!");
                    }
                    else
                    {
                            if (teljesNevTB.Text.Replace(" ", "") == "")
                            {
                                MessageBox.Show(" Töltsd ki a teljes nevet tartalmazó mezőt is! ", "Figyelem!");
                            }
                            else
                            {
                                string password = check.generatePassword(10);
                                string par = classify.GetMD5(password);
                                string jog = m_dose.taroltEljaras("select FelhasznaloTipusok.FelhasznaloTipusID from FelhasznaloTipusok where Tipus = '" + hozzaferesCB.Text + "'");
                                string error = classify.Register(felhnev_reg.Text, par, teljesNevTB.Text, emailTB.Text, jog);
                                if (error == "OK")
                                {
                                    check.sendPasswordToEmail("lazar.szilard1995@gmail.com", emailTB.Text, "Hi " + teljesNevTB.Text + "! \n Your password: " + password);
                                    MessageBox.Show("                                 A regisztráció sikeres volt! \n\nA jelszó megtekintéséhez jelentkezz be az email fiókodba! \nA jelszó megtekintése után a jelszót ajánlott megváltoztatni!", "Figyelem!");
                                    felhnev_reg.Text = "";
                                    teljesNevTB.Text = "";
                                    emailTB.Text = "";
                                }
                                else MessageBox.Show(error + " \n A regisztrálás sikertelen volt! ");
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Ez a felhasználó már létezik!", "Figyelem!");
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow fo = new MainWindow(userName);
            fo.Show();
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.YellowGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        public void HozzaferesekComboFeltoltese()
        {
            List<PersonStruct> szemelyList = person.GetAccesList();
            hozzaferesCB.DataSource = szemelyList;
            hozzaferesCB.DisplayMember = "Hozzaferesek";
        }
    }
}
