using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VersenyekSQL
{
    /// <summary>
    /// Data structure for storing Country Information
    /// </summary>
    public struct PartOfTheDayStruct
    {
        string m_partOfTheDay;

        public string napszakName
        {
            get { return m_partOfTheDay; }
            set { m_partOfTheDay = value; }
        }

        public PartOfTheDayStruct(string napszakName)
        {
            m_partOfTheDay = napszakName;
        }
    }

    public class PartOfTheDayClass : DAL
    {
        public List<PartOfTheDayStruct> GetPartOfTheDayList()
        {
            string query = "SELECT Napszakok.Napszak from Napszakok", error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<PartOfTheDayStruct> paof = new List<PartOfTheDayStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    PartOfTheDayStruct item = new PartOfTheDayStruct();
                    item.napszakName = rdr[0].ToString();
                    paof.Add(item);
                }
            }
            CloseConnection();

            return paof;
        }
    }
}