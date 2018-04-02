using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VersenyekSQL
{
    /// <summary>
    /// Data structure for storing Country Information
    /// </summary>
    public struct MedicineStruct
    {
        string m_medName;

        public string gyogyszerName
        {
            get { return m_medName; }
            set { m_medName = value; }
        }

        public MedicineStruct(string gyogyName)
        {
            m_medName = gyogyName;
        }
    }

    public class MedicineClass : DAL
    {
        public List<MedicineStruct> GetAllMedicineName()
        {
            string query = "SELECT distinct Gyogyszerek.Nev from Gyogyszerek order by Gyogyszerek.Nev", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<MedicineStruct> gyogyszerList = new List<MedicineStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    MedicineStruct item = new MedicineStruct();
                    item.gyogyszerName = rdr[0].ToString();
                    gyogyszerList.Add(item);
                }
            }
            CloseConnection();

            return gyogyszerList;
        }
        public List<MedicineStruct> GetAllMedicineNameIntoStorage()
        {
            string query = "SELECT distinct Gyogyszerek.Nev from Gyogyszerek, Raktaron where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID and Mennyiseg <> '0'", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<MedicineStruct> gyogyszerList = new List<MedicineStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    MedicineStruct item = new MedicineStruct();
                    item.gyogyszerName = rdr[0].ToString();
                    gyogyszerList.Add(item);
                }
            }
            CloseConnection();

            return gyogyszerList;
        }
    }
}