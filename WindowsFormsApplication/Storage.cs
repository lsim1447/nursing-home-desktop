using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace VersenyekSQL
{
    public partial class Storage : Form
    {
        private string userName;
        private StorageClass m_storage = new StorageClass();
        private MedicineClass m_medicine = new MedicineClass();
        private InsertionClass insert = new InsertionClass();
        private DeleteClass delete = new DeleteClass();
        private DoseClass m_dose = new DoseClass();
        private CheckClass check = new CheckClass();

        public Storage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        public Storage(string par)
        {
            userName = par;
            InitializeComponent();
            UpdateStorageDGV();
            medicineNameComboFill();
            medicineNameCB.DropDownStyle = ComboBoxStyle.DropDownList;

            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            foreach (DataGridViewRow row in storageDGV.Rows)
            {
                row.Height = 26;
            }
        }
        public void medicineNameComboFill()
        {
            List<MedicineStruct> medicineList = m_medicine.GetAllMedicineName();
            medicineNameCB.DataSource = medicineList;
            medicineNameCB.DisplayMember = "gyogyszerName";
        }
        private void UpdateStorageDGV()
        {
            storageDGV.Rows.Clear();
            List<StorageStruct> storeList = m_storage.GetAllFromMedicineStorage();
            storageDGV.ColumnCount = 4;
            storageDGV.Columns[0].Name = "Gyógyszer neve";
            storageDGV.Columns[0].Width = 296;
            storageDGV.Columns[1].Name = "Mennyiség";
            storageDGV.Columns[1].Width = 150;
            storageDGV.Columns[2].Name = "Ár/doboz (LEI)";
            storageDGV.Columns[2].Width = 150;
            storageDGV.Columns[3].Name = "Dátum";
            storageDGV.Columns[3].Width = 100;
            foreach (StorageStruct item in storeList)
            {
                string unit = m_dose.taroltEljaras("select Gyogyszerek.Mertekegyseg from Gyogyszerek where Nev = '" + item.GyogyszerNev + "'");
                storageDGV.Rows.Add(item.GyogyszerNev, item.MennyisegF + " " + unit, item.Ar, item.Datum);
            }
            foreach (DataGridViewRow row in storageDGV.Rows)
            {
                row.Height = 26;
            }
        }

        private void hozzaadBTN_Click(object sender, EventArgs e)
        {
            if (medicineNameCB.Text != "")
            {
                if (nrOfPack.Value.ToString() != "")
                {
                    if (priceTB.Text != "")
                    {
                        try
                        {
                            string temp = priceTB.Text.Replace(',', '.');
                            DateTimePicker DTP = new DateTimePicker();
                            DTP.Format = DateTimePickerFormat.Short;
                            DTP.Value = DateTime.Today;
                            DateTime idate = DTP.Value;
                            CultureInfo ci = CultureInfo.InvariantCulture;
                            string date = idate.ToString("yyyy-MM-dd", ci);

                            string k = insert.UploadMedicineStock(medicineNameCB.Text, Convert.ToInt32(nrOfPack.Value), float.Parse(temp, CultureInfo.InvariantCulture.NumberFormat), date);
                            UpdateStorageDGV();
                            MessageBox.Show("A gyógyszer hozzáadása sikeres volt!");
                            medicineNameCB.Text = "";
                            priceTB.Text = "";
                        }
                        catch(Exception){
                            MessageBox.Show("A 'Dobozok száma' és 'Ár/doboz' mezők csak számokat tartalmazhatnak!", " Figyelem!  ");
                            priceTB.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Töltsd ki az ár mezőt is! ", "Figyelem!");
                    }
                }
                else{
                    MessageBox.Show(" Töltsd ki a mennyiség mezőt is! ", "Figyelem!");
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy gyógyszert!", "Figyelem!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(userName);
            mainWindow.Show();
            this.Close();
        }

        private void torlesBTN_Click(object sender, EventArgs e)
        {
            if (storageDGV.SelectedRows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd?", " Figyelem! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string name = storageDGV.SelectedRows[0].Cells["Gyógyszer neve"].Value.ToString();
                    float num = Convert.ToSingle(storageDGV.SelectedRows[0].Cells["Mennyiség"].Value.ToString().Substring(0, storageDGV.SelectedRows[0].Cells["Mennyiség"].Value.ToString().IndexOf(" ") + 1));
                    
                    float pc = Convert.ToSingle(storageDGV.SelectedRows[0].Cells["Ár/doboz (LEI)"].Value);
                    string date = storageDGV.SelectedRows[0].Cells["Dátum"].Value.ToString();
                    string error = delete.DeleteFromMedicineStorage(name, num, pc, date);
                    if (error == "OK")
                    {
                        MessageBox.Show("Sikeres törlés", "");
                        UpdateStorageDGV();
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
                MessageBox.Show(" Nincs kiválasztott elem! ", " Figyelem! ");
            }
        }

        private void hozzaadBTN_MouseEnter(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.YellowGreen;
        }

        private void hozzaadBTN_MouseLeave(object sender, EventArgs e)
        {
            addBTN.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            backBTN.BackColor = Color.White;
        }

        private void torlesBTN_MouseEnter(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.Red;
        }

        private void torlesBTN_MouseLeave(object sender, EventArgs e)
        {
            deleteBTN.BackColor = Color.White;
        }

        private void gyogyszerNevCB_MouseEnter(object sender, EventArgs e)
        {
            medicineNameCB.BackColor = Color.YellowGreen;
        }

    }
    
}
