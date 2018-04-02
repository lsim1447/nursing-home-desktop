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
    public partial class NappyStorage : Form
    {
        private string userName;
        private NappyClass m_nappy = new NappyClass();
        private DoseClass m_dose = new DoseClass();
        private StorageClass m_stoore = new StorageClass();
        private InsertionClass insert = new InsertionClass();
        private DeleteClass delete = new DeleteClass();


        public NappyStorage()
        {
            InitializeComponent();
        }

        public NappyStorage(string par)
        {
            InitializeComponent();
            pelenkaNevComboFill();
            nappyNameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            userName = par;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            ListStorageContent();
            foreach (DataGridViewRow row in storageDGV.Rows)
            {
                row.Height = 26;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow foAblak = new MainWindow(userName);
            foAblak.Show();
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.YellowGreen;
        }

        public void pelenkaNevComboFill()
        {
            List<NappyStruct> pelenkaList = m_nappy.GetNappyNameList("1");
            nappyNameCB.DataSource = pelenkaList;
            nappyNameCB.DisplayMember = "pelenkaName";
        }



        private void button1_MouseLeave(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.White;
        }

        private void ListStorageContent()
        {
            storageDGV.Rows.Clear();
            List<StorageStruct> storeList = m_stoore.GetAllFromNappyStorage();
            storageDGV.ColumnCount = 4;
            storageDGV.Columns[0].Name = "Pelenka";
            storageDGV.Columns[0].Width = 240;
            storageDGV.Columns[1].Name = "Egység";
            storageDGV.Columns[1].Width = 110;
            storageDGV.Columns[2].Name = "Ár/csomag (LEI)";
            storageDGV.Columns[2].Width = 150;
            storageDGV.Columns[3].Name = "Dátum";
            storageDGV.Columns[3].Width = 120;

            foreach (StorageStruct item in storeList)
            {
                storageDGV.Rows.Add(item.GyogyszerNev, item.Mennyiseg, item.Ar, item.Datum);
            }
            foreach (DataGridViewRow row in storageDGV.Rows)
            {
                row.Height = 26;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nrOfPack.Value.ToString().Replace(" ", "") != ""){
                if (priceTB.Text.Replace(" ", "") != ""){
                    int nr = -1;
                    float pc = -1;

                    try
                    {
                        nr = Convert.ToInt32(nrOfPack.Value);
                        try
                        {
                            pc = Convert.ToSingle(priceTB.Text.Replace(".",","));
                            var today = DateTime.Today.ToShortDateString().ToString().Replace(".", "-").Replace(" ", "").Substring(0,10);
                            string err = insert.UploadNappyStock(nappyNameCB.Text, Convert.ToInt32(nrOfPack.Value), pc, today);
                            ListStorageContent();
                            priceTB.Text = "";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("A csomagok ára kizárólag számot tartalmazhat! ", " Figyelem! ");
                            priceTB.Text = "";
                        }
                    }
                    catch(Exception){
                        MessageBox.Show("A csomagok száma kizárólag egész számot tartalmazhat! ", " Figyelem! ");
                    }
                }
                else{
                    MessageBox.Show(" Kérlek add meg a csomagok árát is! ", " Figyelem! ");
                    priceTB.Text = "";
                }
            }
            else{
                MessageBox.Show(" Kérlek add meg a csomagok számát is! ", " Figyelem! ");
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (storageDGV.SelectedRows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd?", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string name = storageDGV.SelectedRows[0].Cells["Pelenka"].Value.ToString();
                    int quanta = Convert.ToInt32(storageDGV.SelectedRows[0].Cells["Egység"].Value);
                    float pc = Convert.ToSingle(storageDGV.SelectedRows[0].Cells["Ár/csomag (LEI)"].Value);
                    string date = storageDGV.SelectedRows[0].Cells["Dátum"].Value.ToString();
                    string error = delete.DeleteFromNappyStorage(name, quanta, pc, date);
                    if (error == "OK")
                    {
                        MessageBox.Show("Sikeres törlés", "");
                        ListStorageContent();
                    }
                    else
                        MessageBox.Show(error);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show(" Nincs kijelölve egyetlen sor sem! ", " Figyelem! ");
            }
        }

        private void pelenkaNevCB_MouseEnter(object sender, EventArgs e)
        {
            nappyNameCB.BackColor = Color.YellowGreen;
        }
    }
}
