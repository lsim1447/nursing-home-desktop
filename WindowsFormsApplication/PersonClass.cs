using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VersenyekSQL
{
    /// <summary>
    /// Data structure for storing Country Information
    /// </summary>
    public struct PersonStruct
    {
        string m_persName;
        string m_cnp;
        int m_age;
        string m_acces;

        public string szemelyName
        {
            get { return m_persName; }
            set { m_persName = value; }
        }
        public string Hozzaferesek
        {
            get { return m_acces; }
            set { m_acces = value; }
        }
        public string szemelyCNP
        {
            get { return m_cnp; }
            set { m_cnp = value; }
        }
        public int eletkor
        {
            get { return m_age; }
            set { m_age = value; }
        }
    }

    public class PersonClass : DAL
    {
        public List<PersonStruct> GetPersonNameList()
        {
            string query = "SELECT Szemelyek.Nev from Szemelyek order by Nev", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<PersonStruct> persList = new List<PersonStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    PersonStruct item = new PersonStruct();
                    item.szemelyName = rdr[0].ToString();
                    persList.Add(item);
                }
            }
            CloseConnection();

            return persList;
        }

        public List<PersonStruct> GetAccesList()
        {
            string query = "SELECT FelhasznaloTipusok.Tipus from FelhasznaloTipusok", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<PersonStruct> accList = new List<PersonStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    PersonStruct item = new PersonStruct();
                    item.Hozzaferesek = rdr[0].ToString();
                    accList.Add(item);
                }
            }
            CloseConnection();

            return accList;
        }

        public List<PersonStruct> GetPersonDataList()
        {
            string query = "SELECT Szemelyek.Nev, Szemelyek.CNP from Szemelyek order by Szemelyek.Nev", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<PersonStruct> persList = new List<PersonStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    PersonStruct item = new PersonStruct();
                    int year = Convert.ToInt32(DateTime.Now.Year.ToString());
                    int month = Convert.ToInt32(DateTime.Now.Month.ToString());
                    int day = Convert.ToInt32(DateTime.Now.Day.ToString());
                    int tempYear = Convert.ToInt32("19" + rdr[1].ToString().Substring(1, 2));
                    int tempMonth = Convert.ToInt32(rdr[1].ToString().Substring(3, 2));
                    int tempDay = Convert.ToInt32(rdr[1].ToString().Substring(5, 2));

                    int ev;
                    if (month > tempMonth || (month == tempMonth && day >= tempDay))
                    {
                        ev = year - tempYear;
                    }
                    else ev = year - tempYear - 1;

                    item.szemelyName = rdr[0].ToString();
                    item.szemelyCNP = rdr[1].ToString();
                    item.eletkor = ev;
                    persList.Add(item);
                }
            }
            CloseConnection();

            return persList;
        }
    }
}