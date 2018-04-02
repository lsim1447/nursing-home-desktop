using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VersenyekSQL;
using System.Globalization;

namespace VersenyekSQL
{
    public struct StorageStruct
    {
        int m_MedID;
        string m_MedName;
        int m_Num;
        float mf_Num;
        float m_Price;
        string m_Date;

        public int GyogyszerID
        {
            get { return m_MedID; }
            set { m_MedID = value; }
        }
        public string Datum
        {
            get { return m_Date; }
            set { m_Date = value; }
        }
        public string GyogyszerNev
        {
            get { return m_MedName; }
            set { m_MedName = value; }
        }

        public int Mennyiseg
        {
            get { return m_Num; }
            set { m_Num = value; }
        }
        public float MennyisegF
        {
            get { return mf_Num; }
            set { mf_Num = value; }
        }
        public float Ar
        {
            get { return m_Price; }
            set { m_Price = value; }
        }
    }
    public class StorageClass : DAL
    {

        public List<StorageStruct> GetAllFromMedicineStorage()
        {
            string query = "select Gyogyszerek.Nev, Raktaron.Mennyiseg, Raktaron.Ar, Raktaron.Datum from Raktaron, Gyogyszerek where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<StorageStruct> stList = new List<StorageStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    StorageStruct item = new StorageStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.MennyisegF = Convert.ToSingle(rdr[1]);
                    item.Ar = Convert.ToSingle(rdr[2]);
                    item.Datum = rdr[3].ToString();
                    stList.Add(item);
                }
            }
            CloseConnection();
            return stList;
        }

        public List<StorageStruct> GetAllFromNappyStorage()
        {
            string query = "select Pelenkak.Nev, RaktaronPelenka.Mennyiseg, RaktaronPelenka.Ar, RaktaronPelenka.Datum from RaktaronPelenka, Pelenkak where RaktaronPelenka.PelenkaID = Pelenkak.PelenkaID";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<StorageStruct> stList = new List<StorageStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    StorageStruct item = new StorageStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.Mennyiseg = Convert.ToInt32(rdr[1]);
                    item.Ar = Convert.ToSingle(rdr[2]);
                    item.Datum = rdr[3].ToString();
                    stList.Add(item);
                }
            }
            CloseConnection();
            return stList;
        }
    }
}