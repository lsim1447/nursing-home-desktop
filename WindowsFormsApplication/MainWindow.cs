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
    public partial class MainWindow : Form
    {
        private string userName;
        private CheckClass check = new CheckClass();
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(string par)
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
            userNameLB.Text = userName;
            if (check.CheckAcces(userName) != "admin") newUserRegisterLB.Visible = false;
        }

        private void UjBeteg_Click(object sender, EventArgs e)
        {
            AddNewPerson newPerson = new AddNewPerson(userName);
            newPerson.Show();
            this.Close();
        }

        private void UjGyogyszer_Click(object sender, EventArgs e)
        {
            AddNewMedicine newMedicine = new AddNewMedicine(userName);
            newMedicine.Show();
            this.Close();
        }

        private void UjAdag_Click(object sender, EventArgs e)
        {
            AddNewDose newDose = new AddNewDose(userName);
            newDose.Show();
            this.Close();
        }

        private void Kijelentkezes_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void raktarBTN_Click(object sender, EventArgs e)
        {
            Storage r = new Storage(userName);
            r.Show();
            this.Close();
        }

        private void osszegzoBTN_Click(object sender, EventArgs e)
        {
            PersonalSummarization total = new PersonalSummarization(userName);
            total.Show();
            this.Close();
        }

        private void altalanosOsszBTN_Click(object sender, EventArgs e)
        {
            GeneralSummarization genTot = new GeneralSummarization(userName);
            genTot.Show();
            this.Close();
        }

        private void ujPelenkaFajta_Click(object sender, EventArgs e)
        {
            AddNewNappy newNappy = new AddNewNappy(userName);
            newNappy.Show();
            this.Close();
        }

        private void raktaronPelenkakBTN_Click(object sender, EventArgs e)
        {
            NappyStorage nappyStoore = new NappyStorage(userName);
            nappyStoore.Show();
            this.Close();
        }

        private void ujPelenkaAdagolasa_Click(object sender, EventArgs e)
        {
            AddNewNappyDose newNappyDose = new AddNewNappyDose(userName);
            newNappyDose.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register(userName);
            reg.Show();
            this.Close();
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            newUserRegisterLB.BackColor = Color.White;
            newUserRegisterLB.ForeColor = Color.Black;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            newUserRegisterLB.ForeColor = Color.White;
            newUserRegisterLB.BackColor = Color.Transparent;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            addNewPersonLB.BackColor = Color.White;
            addNewPersonLB.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            addNewPersonLB.ForeColor = Color.White;
            addNewPersonLB.BackColor = Color.Transparent;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            addNewMedicineLB.BackColor = Color.White;
            addNewMedicineLB.ForeColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            addNewMedicineLB.ForeColor = Color.White;
            addNewMedicineLB.BackColor = Color.Transparent;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            addNewNappyLB.BackColor = Color.White;
            addNewNappyLB.ForeColor = Color.Black;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            addNewNappyLB.ForeColor = Color.White;
            addNewNappyLB.BackColor = Color.Transparent;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            addNewMedicineDoseLB.BackColor = Color.White;
            addNewMedicineDoseLB.ForeColor = Color.Black;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            addNewMedicineDoseLB.ForeColor = Color.White;
            addNewMedicineDoseLB.BackColor = Color.Transparent;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            addNewNappyDoseLB.BackColor = Color.White;
            addNewNappyDoseLB.ForeColor = Color.Black;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            addNewNappyDoseLB.ForeColor = Color.White;
            addNewNappyDoseLB.BackColor = Color.Transparent;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            medicineOnStoorLB.BackColor = Color.White;
            medicineOnStoorLB.ForeColor = Color.Black;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            medicineOnStoorLB.ForeColor = Color.White;
            medicineOnStoorLB.BackColor = Color.Transparent;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            nappyOnStoorLB.BackColor = Color.White;
            nappyOnStoorLB.ForeColor = Color.Black;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            nappyOnStoorLB.ForeColor = Color.White;
            nappyOnStoorLB.BackColor = Color.Transparent;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            generalTotalizeLB.BackColor = Color.White;
            generalTotalizeLB.ForeColor = Color.Black;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            generalTotalizeLB.ForeColor = Color.White;
            generalTotalizeLB.BackColor = Color.Transparent;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            totalizeP.BackColor = Color.White;
            totalizeP.ForeColor = Color.Black;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            totalizeP.ForeColor = Color.White;
            totalizeP.BackColor = Color.Transparent;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Register reg = new Register(userName);
            reg.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddNewPerson ujEmber = new AddNewPerson(userName);
            ujEmber.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddNewMedicine newMed = new AddNewMedicine(userName);
            newMed.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AddNewNappy newNappy = new AddNewNappy(userName);
            newNappy.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AddNewDose newDose = new AddNewDose(userName);
            newDose.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AddNewNappyDose upa = new AddNewNappyDose(userName);
            upa.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Storage r = new Storage(userName);
            r.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            NappyStorage pelRak = new NappyStorage(userName);
            pelRak.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            GeneralSummarization altOssz = new GeneralSummarization(userName);
            altOssz.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            PersonalSummarization ossz = new PersonalSummarization(userName);
            ossz.Show();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            logOutLB.ForeColor = Color.Red;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            logOutLB.ForeColor = Color.White;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            userNameLB.ForeColor = Color.Green;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            userNameLB.ForeColor = Color.White;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData(userName);
            userData.Show();
            this.Close();
        }
    }
}
