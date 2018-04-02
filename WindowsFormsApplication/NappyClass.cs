using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VersenyekSQL
{
    /// <summary>
    /// Data structure for storing Country Information
    /// </summary>
    public struct NappyStruct
    {
        string m_name;
        string m_size;

        public string pelenkaName
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public string pelenkaMeretName
        {
            get { return m_size; }
            set { m_size = value; }
        }

    }

    public class NappyClass : DAL
    {
        public List<NappyStruct> GetNappyNameList(string par)
        {
            string query = "SELECT distinct Pelenkak.Nev from Pelenkak", error = string.Empty;
            string temp = "SELECT distinct Pelenkak.Nev from Pelenkak, RaktaronPelenka where Pelenkak.PelenkaID = RaktaronPelenka.PelenkaID and RaktaronPelenka.Mennyiseg != 0", errorr = string.Empty;
            SqlDataReader rdr;
            if (par == "1")
            {
                rdr = myExecuteReader(query, ref error);
            }
            else
            {
                rdr = myExecuteReader(temp, ref error);
            }

            List<NappyStruct> nappyList = new List<NappyStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    NappyStruct item = new NappyStruct();
                    item.pelenkaName = rdr[0].ToString();
                    nappyList.Add(item);
                }
            }
            CloseConnection();

            return nappyList;
        }

        public List<NappyStruct> GetNappySizeNameList()
        {
            string query = "SELECT distinct Pelenkak.Meret from Pelenkak", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<NappyStruct> nappyList = new List<NappyStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    NappyStruct item = new NappyStruct();
                    item.pelenkaMeretName = rdr[0].ToString();
                    nappyList.Add(item);
                }
            }
            CloseConnection();

            return nappyList;
        }
    }
}