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
    public partial class AddNewMedicine : Form
    {
        private string userName;
        private InsertionClass m_insert = new InsertionClass();
        private SqlDataReader drMedicine;
        private string ErrMess = "";
        private UploadsClass m_myUp = new UploadsClass();
        private DeleteClass m_delete = new DeleteClass();
        private DoseClass m_dose = new DoseClass();
        public AddNewMedicine(string par)
        {
            userName = par;
            InitializeComponent();
            medicineBox.Items.Clear();
            drMedicine = m_myUp.ListBoxUploadMedDR(ref ErrMess);
            Utils.ListboxToltoDR(medicineBox, drMedicine);
                            
            unitCB.DisplayMember = "Text";
            unitCB.ValueMember = "Value";
            unitCB.Items.Add(new { Text = "gr", Value = "gr" });
            unitCB.Items.Add(new { Text = "mg", Value = "mg" });
            unitCB.Items.Add(new { Text = "ml", Value = "ml" });
            unitCB.Items.Add(new { Text = "darab", Value = "darab" });

            typeCB.DisplayMember = "Text";
            typeCB.ValueMember = "Value";
            typeCB.Items.Add(new { Text = "állandó", Value = "allando" });
            typeCB.Items.Add(new { Text = "alkalmi", Value = "alkalmi" });
            unitCB.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            //gyogyszerBox.BackColor = Color.MediumTurquoise;

            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

           
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exist = m_dose.taroltEljaras("select count(Gyogyszerek.GyogyszerID) from Gyogyszerek where Gyogyszerek.Nev = '" + medicineNameTB.Text + "'");
            if (exist != "0")
            {
                MessageBox.Show(" Ez a gyógyszer már létezik! ", " Figyelem! ");
            }
            else if (medicineNameTB.Text != "")
            {
                if (unitCB.Text != "")
                {
                    if (typeCB.Text != "")
                    {
                        if (numTB.Text != "")
                        {
                            try
                            {
                                string err = m_insert.InsertNewMedicine(medicineNameTB.Text, unitCB.Text, typeCB.Text, Convert.ToInt32(numTB.Text));
                                medicineNameTB.Text = "";
                                unitCB.Text = "";
                                typeCB.Text = "";
                                numTB.Text = "";
                                MessageBox.Show(" A gyógyszer hozzáadása sikeres volt! ");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Hibás adatok!");
                                medicineNameTB.Text = "";
                                unitCB.Text = "";
                                typeCB.Text = "";
                                numTB.Text = "";
                            }
                            medicineBox.Items.Clear();
                            drMedicine = m_myUp.ListBoxUploadMedDR(ref ErrMess);
                            Utils.ListboxToltoDR(medicineBox, drMedicine);
                        }
                        else
                        {
                            MessageBox.Show(" Add meg a darabszamot is! ", " Figyelem! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Add meg a gyógyszer tipúsát (is)!!", " Figyelem! ");
                    }
                }
                else
                {
                    MessageBox.Show("Add meg a gyógyszer mértékegységét (is)!!", " Figyelem! ");
                }
            }
            else
            {
                MessageBox.Show("Add meg a gyógyszer nevét (is)!!", " Figyelem! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (medicineBox.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd?", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string delete = medicineBox.SelectedItem.ToString();
                    string err = m_delete.DeleteMedicine(delete);
                    medicineBox.Items.Clear();

                    drMedicine = m_myUp.ListBoxUploadMedDR(ref ErrMess);
                    Utils.ListboxToltoDR(medicineBox, drMedicine);
                    MessageBox.Show("A törlés sikeres volt!", " Figyelem! ");
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölve egyetlen gyógyszer sem! Kérlek válassz ki egyet! ","Figyelem!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            addNewMedicineBTN.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            addNewMedicineBTN.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            deleteMedBTN.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            deleteMedBTN.BackColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void mertekegysegCB_MouseEnter(object sender, EventArgs e)
        {
            unitCB.BackColor = Color.YellowGreen;
        }

        private void tipusCB_MouseEnter(object sender, EventArgs e)
        {
            typeCB.BackColor = Color.YellowGreen;
        }

        private void CloseAndUpdate(object sender, System.EventArgs e)
        {
            medicineBox.Items.Clear();
            drMedicine = m_myUp.ListBoxUploadMedDR(ref ErrMess);
            Utils.ListboxToltoDR(medicineBox, drMedicine);
        }

        private void gyogyszerBox_DoubleClick(object sender, EventArgs e)
        {
            if (medicineBox.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Biztosan módositani szeretnéd a gyógyszer nevét?", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string selected = medicineBox.SelectedItem.ToString();
                    medicineBox.Items.Clear();
                    InputWindow iw = new InputWindow(selected, 1);
                    iw.Show();
                    iw.FormClosed += new FormClosedEventHandler(CloseAndUpdate);
                    drMedicine = m_myUp.ListBoxUploadMedDR(ref ErrMess);
                    Utils.ListboxToltoDR(medicineBox, drMedicine);
                }
            }
        }

        private void mertekegysegCB_TextChanged(object sender, EventArgs e)
        {
            if (unitCB.Text == "ml")
            {
                label3.Text = "Mennyiség( ml ): ";
            }
            else
            {
                label3.Text = "Darab/doboz:      "; // length = 18
            }
        }
    }
}
