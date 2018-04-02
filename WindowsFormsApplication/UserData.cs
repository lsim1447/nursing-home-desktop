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
    public partial class UserData : Form
    {
        private string user;
        private PersonClass person = new PersonClass();
        private DoseClass m_dose = new DoseClass();
        private CheckClass check = new CheckClass();
        private EncryptsClass classify = new EncryptsClass();

        public UserData(string par)
        {
            InitializeComponent();
            user = par;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            userNameTB.Text = user;
            userNameTB.Enabled = false;
            totalNameTB.Text = m_dose.taroltEljaras("select Felhasznalok.TeljesNev from Felhasznalok where FelhasznaloNev = '" + user + "'");
            emailTB.Text = m_dose.taroltEljaras("select Felhasznalok.Email from Felhasznalok where FelhasznaloNev = '" + user + "'");
            accessTB.Text = m_dose.taroltEljaras("select FelhasznaloTipusok.Tipus from Felhasznalok,FelhasznaloTipusok where FelhasznaloTipusok.FelhasznaloTipusID = Felhasznalok.FelhasznaloTipusID and Felhasznalok.FelhasznaloNev = '" + user + "'");
            accessTB.Enabled = false;
        }


        private void visszaBTN_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow(user);
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(" Biztosan módositani szeretnéd? ", "Figyelem!", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                string passwd = classify.GetMD5(oldPasswordTB.Text);
                string reallyPasswd = m_dose.taroltEljaras("select Felhasznalok.Jelszo from Felhasznalok where FelhasznaloNev = '" + user + "'");
                if (passwd == reallyPasswd)
                {
                    if (newPasswordTB.Text.Replace(" ", "") == "")
                    {
                        MessageBox.Show("Add meg a jelszót is!", "Figyelem!");
                    }
                    else
                    {
                        if (emailTB.Text.Replace(" ", "") == "")
                        {
                            MessageBox.Show(" Töltsd ki az email-t tartalmazó mezőt is! ", "Figyelem!");
                        }
                        else
                        {
                            if (totalNameTB.Text.Replace(" ", "") == "")
                            {
                                MessageBox.Show(" Töltsd ki a teljes nevet tartalmazó mezőt is! ", "Figyelem!");
                            }
                            else
                            {
                                if (newPasswordTB.Text != newPasswordRepeatTB.Text)
                                {
                                    MessageBox.Show("Hiba! A jelszavak nem egyeznek meg! ", "Figyelem!");
                                }
                                else
                                {
                                    string par = classify.GetMD5(newPasswordTB.Text);
                                    //string jog = m_dose.taroltEljaras("select FelhasznaloTipusok.FelhasznaloTipusID from FelhasznaloTipusok where Tipus = '" + hozzaferesCB.Text + "'");
                                    string error = m_dose.taroltEljaras("update Felhasznalok set Jelszo = '" + par + "', Email = '" + emailTB.Text + "', TeljesNev = '" + totalNameTB.Text + "' where FelhasznaloNev = '" + user + "'");
                                    MessageBox.Show("A módositás sikeresen megtörtént!", "Figyelem!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hibás a megadott Régi jelszó!", "Figyelem!");
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            saveModifiedBTN.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            saveModifiedBTN.BackColor = Color.White;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            backToMenuLB.BackColor = Color.White;
            backToMenuLB.ForeColor = Color.Black;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            backToMenuLB.BackColor = Color.Transparent;
            backToMenuLB.ForeColor = Color.White;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MainWindow fo = new MainWindow(user);
            fo.Show();
            this.Close();
        }
    }
}
