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
    public partial class AddNewNappy : Form
    {
        private string userName;
        private DoseClass m_dose = new DoseClass();
        private NappyClass m_nappy = new NappyClass();
        private UploadsClass m_myUp = new UploadsClass();
        private DeleteClass m_delete = new DeleteClass();
        private SqlDataReader drNappy;
        private string ErrMess = "";

        public AddNewNappy()
        {
            InitializeComponent();
        }

        public AddNewNappy(string par)
        {
            userName = par;
            InitializeComponent();
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            pelenkaBox.Items.Clear();
            drNappy = m_myUp.ListBoxUploadNappyDR(ref ErrMess);
            Utils.ListboxToltoDR(pelenkaBox, drNappy);
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Close();
        }

        private void Vissza_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void Vissza_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void mentBTN_Click(object sender, EventArgs e)
        {
            if (nappyNameTB.Text.Replace(" ","") != ""){
                string ok = "-1";
                ok = m_dose.taroltEljaras("select PelenkaID from Pelenkak where Nev = '" + nappyNameTB.Text.Replace(" ", "") + "'");
                if (ok == "-")
                {
                    if (numTB.Text.Replace(" ", "") != "")
                    {
                        int db = -1;
                        try
                        {
                            db = Convert.ToInt32(numTB.Text);
                            string query = "insert into Pelenkak values ('" + nappyNameTB.Text + "'" + ", " + numTB.Text + ")";
                            m_dose.taroltEljaras(query);
                            numTB.Text = "";
                            nappyNameTB.Text = "";
                            MessageBox.Show(" A termék regisztrálása sikeres volt! ", " Figyelem! ");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(" A darabszám kötelezően egész szám kell legyen!  ", " Figyelem! ");
                            numTB.Text = "";
                        }
                        pelenkaBox.Items.Clear();
                        drNappy = m_myUp.ListBoxUploadNappyDR(ref ErrMess);
                        Utils.ListboxToltoDR(pelenkaBox, drNappy);
                    }
                    else
                    {
                        MessageBox.Show(" Kérlek add meg a csomagban lévő pelenkák számát is! ", " Figyelem! ");
                        numTB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show(" Már létezik ilyen nevű pelenka! ", " Figyelem! ");
                    numTB.Text = "";
                    nappyNameTB.Text = "";
                }
            }
            else{
                MessageBox.Show(" Kérlek add meg a nevet is! ", " Figyelem! ");
                nappyNameTB.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd?", " Figyelem! ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pelenkaBox.SelectedIndex > -1)
                {
                    string delete = pelenkaBox.SelectedItem.ToString();
                    string err = m_delete.DeleteNappy(delete);
                    pelenkaBox.Items.Clear();
                    drNappy = m_myUp.ListBoxUploadNappyDR(ref ErrMess);
                    Utils.ListboxToltoDR(pelenkaBox, drNappy);

                    MessageBox.Show("A törlés sikeres volt!", " Figyelem! ");
                }
                else
                {
                    MessageBox.Show(" Kérlek jelölj ki egy sort! ", " Figyelem! ");
                }
            }
            else
            {
                //do something
            }
        }

        private void mentBTN_MouseEnter(object sender, EventArgs e)
        {
            saveBTN.BackColor = Color.YellowGreen;
        }

        private void mentBTN_MouseLeave(object sender, EventArgs e)
        {
            saveBTN.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.White;
        }

        private void CloseAndUpdate(object sender, System.EventArgs e)
        {
            pelenkaBox.Items.Clear();
            drNappy = m_myUp.ListBoxUploadNappyDR(ref ErrMess);
            Utils.ListboxToltoDR(pelenkaBox, drNappy);
        }

        private void pelenkaBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan módositani szeretnéd a pelenka nevét?", " Figyelem! ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pelenkaBox.SelectedIndex > -1)
                {
                    string torol = pelenkaBox.SelectedItem.ToString();
                    pelenkaBox.Items.Clear();
                    InputWindow iw = new InputWindow(torol, 2);
                    iw.Show();
                    iw.FormClosed += new FormClosedEventHandler(CloseAndUpdate);
                    drNappy = m_myUp.ListBoxUploadNappyDR(ref ErrMess);
                    Utils.ListboxToltoDR(pelenkaBox, drNappy);
                }
            }
        }
    }
}
