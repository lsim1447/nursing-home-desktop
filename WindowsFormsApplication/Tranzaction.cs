using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Common;
using System.Threading;


namespace VersenyekSQL
{
    class Tranzaction
    {

        private StoredProcedureRetClass storedProc = new StoredProcedureRetClass();
        private DoseClass m_dose = new DoseClass();
        private StoredProcedureRetClass m_storedproc = new StoredProcedureRetClass();

        public int AddNewMedDose(string persName, string medName, string partOfTheDay, string date, string num, string userName)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GS9HEBT;Initial Catalog=OregOtthonProjekt;Integrated Security=SSPI"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    string error = "";
                    error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                    string stProc = storedProc.AddNewMedicineDose(persName, medName, partOfTheDay, date, Convert.ToSingle(num.Replace(".", ",")), Convert.ToInt32(error), ref error);
                    if (stProc == "OK")
                    {
                        MessageBox.Show(" A gyógyszer adagolása sikeresen megtörtént! ");
                    }
                    transaction.Commit();
                    connection.Close();
                    return 1;
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Rollback Exception Type: " + ex2.GetType());
                    }
                    return -1;
                }
            }
        }

        public int AddNewNappyDose(string persName, string nappyName, string date, int num, string userName)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GS9HEBT;Initial Catalog=OregOtthonProjekt;Integrated Security=SSPI"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    string error = "";
                    error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                    string str = m_storedproc.AddNewNappyDose(persName, nappyName, date, num, Convert.ToInt32(error), ref error);
                    if (str == "OK")
                    {
                        MessageBox.Show(" A gyógyszer adagolása sikeresen megtörtént! ");
                    }
                    transaction.Commit();
                    connection.Close();
                    return 1;
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Rollback Exception Type: " + ex2.GetType());
                    }
                    return -1;
                }
            }
        }

        public int AddYesterdayNappyDose(DataGridView nappyYestDGV, string userName, string today)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GS9HEBT;Initial Catalog=OregOtthonProjekt;Integrated Security=SSPI"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    foreach (DataGridViewRow row in nappyYestDGV.Rows)
                    {
                        if ((row.Index < nappyYestDGV.RowCount - 1))
                        {
                            string error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                            string mufurc = m_storedproc.AddNewNappyDose(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), today, Convert.ToInt32(row.Cells[2].Value.ToString()), Convert.ToInt32(error), ref error);
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                    MessageBox.Show(" A pelenka adagolása sikeres volt! ", "Figyelem!");
                    return 1;
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Rollback Exception Type: " + ex2.GetType());
                    }
                    return -1;
                }
            }
        }

        public int AddYesterdayMedicineDose(DataGridView medYestDGV, string userName, string today)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GS9HEBT;Initial Catalog=OregOtthonProjekt;Integrated Security=SSPI"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    foreach (DataGridViewRow row in medYestDGV.Rows)
                    {
                        if ((row.Index < medYestDGV.RowCount - 1))
                        {
                            string error = "";
                            error = m_dose.taroltEljaras("select Felhasznalok.FelhasznaloID from Felhasznalok where FelhasznaloNev = '" + userName + "'");
                            string mufurc = storedProc.AddNewMedicineDose(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), today, Convert.ToSingle(row.Cells[3].Value.ToString().Substring(0, row.Cells[3].Value.ToString().IndexOf(" ") + 1)), Convert.ToInt32(error), ref error);
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                    MessageBox.Show(" A gyógyszer adagolása sikeres volt! ", "Figyelem!");
                    return 1;
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Rollback Exception Type: " + ex2.GetType());
                    }
                    return -1;
                }
            }
        }
    
    }
}
