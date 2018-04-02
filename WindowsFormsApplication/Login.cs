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
    public partial class Login : Form
    {
        private EncryptsClass classify = new EncryptsClass();
        private CheckClass check = new CheckClass();
        
        public Login()
        {
            InitializeComponent();
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint | 
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | 
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, 
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string k = passwordLB.Text;
            {
                if (userNameTB.Text == "")
                    MessageBox.Show("Add meg a felhasználó nevet!");
                else
                {
                    string query = "SELECT FelhasznaloID FROM Felhasznalok WHERE FelhasznaloNev = '" + userNameTB.Text + "'";
                    if (classify.Checker(query) != "-")
                    {
                        if (passwordLB.Text == "")
                        {
                            MessageBox.Show("Add meg jelszavat!");
                        }
                        else
                        {
                            query = "SELECT Jelszo FROM Felhasznalok WHERE FelhasznaloNev = '" + userNameTB.Text + "'";
                            string passwd = classify.Checker(query);
                            string saved = classify.GetMD5(k);
                            if (passwd == saved)
                            {
                                MainWindow ablak = new MainWindow(userNameTB.Text);
                                ablak.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hibás jelszó!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nincs ilyen felhasznaló!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form F = new Form();
            F.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            signInBTN.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            signInBTN.BackColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
            //label4.BackColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            //label4.BackColor = Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
