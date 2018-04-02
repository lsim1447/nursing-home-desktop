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
    public struct DoseStruct
    {
        int m_doseID;
        string m_MedName;
        string m_PersonName;
        int m_Num;
        float m_DosePrice;
        string m_PartOfDay;
        string m_Date;
        int m_totalNum;
        float mf_totalNum;
        float m_totalValue;
        float mf_Num;

        public int AdagID
        {
            get { return m_doseID; }
            set { m_doseID = value; }
        }

        public int OsszMennyiseg
        {
            get { return m_totalNum; }
            set { m_totalNum = value; }
        }
        public float OsszMennyisegF
        {
            get { return mf_totalNum; }
            set { mf_totalNum = value; }
        }
        public float Osszertek
        {
            get { return m_totalValue; }
            set { m_totalValue = value; }
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
            get { return m_DosePrice; }
            set { m_DosePrice = value; }
        }
        public string SzemelyNev
        {
            get { return m_PersonName; }
            set { m_PersonName = value; }
        }
        public string Napszak
        {
            get { return m_PartOfDay; }
            set { m_PartOfDay = value; }
        }
        public string Datum
        {
            get { return m_Date; }
            set { m_Date = value; }
        }
    }
    public class DoseClass : DAL
    {

        public string SzemelyNev(string query)
        {
            OpenConnection();
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);
            if (error == "OK") 
            {
                query = "";
                while (rdr.Read())
                {
                    query += rdr[0].ToString();
                }
            }
            if (query == "")
                query = "-";
            CloseConnection();
            return query;
        }

        public string getGyogyszerID(string query)
        {
            OpenConnection();
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);
            if (error == "OK")
            {
                query = "";
                while (rdr.Read())
                {
                    query += rdr[0].ToString();
                }
            }
            if (query == "")
                query = "-";
            CloseConnection();
            return query;
        }

        public string getSzemelyID(string query)
        {
            OpenConnection();
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);
            if (error == "OK")
            {
                query = "";
                while (rdr.Read())
                {
                    query += rdr[0].ToString();
                }
            }
            if (query == "")
                query = "-";
            CloseConnection();
            return query;
        }

        public string getNapszakID(string query)
        {
            OpenConnection();
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);
            if (error == "OK")
            {
                query = "";
                while (rdr.Read())
                {
                    query += rdr[0].ToString();
                }
            }
            if (query == "")
                query = "-";
            CloseConnection();
            return query;
        }
        
        public string taroltEljaras(string query)
        {
            OpenConnection();
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);
            if (error == "OK")
            {
                query = "";
                while (rdr.Read())
                {
                    query += rdr[0].ToString();
                }
            }
            if (query == "")
                query = "-";
            CloseConnection();
            return query;
        }
        
        public string taroltEljarasSpecifikus(string query, string aracska)
        {
            OpenConnection();
            aracska = aracska.Replace(",", ".");
            query += aracska + " )";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);
            if (error == "OK")
            {
                query = "";
                while (rdr.Read())
                {
                    query += rdr[0].ToString();
                }
            }
            if (query == "")
                query = "-";
            CloseConnection();
            return query;
        }
        
        public List<DoseStruct> GetAdagCucc(string datum, string nev)
        {
            string query = "select Szemelyek.Nev, Gyogyszerek.Nev, Napszakok.Napszak, Adagok.Mennyiseg, Adagok.AdagAra from Adagok, Szemelyek, Gyogyszerek, Napszakok where Adagok.CNP = Szemelyek.CNP and Adagok.GyogyszerID = Gyogyszerek.GyogyszerID and Napszakok.NapszakID = Adagok.NapszakID ";
            query += " and Adagok.Datum = '" + datum + "' and Szemelyek.Nev = '" + nev + "'";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.SzemelyNev = rdr[0].ToString();
                    item.GyogyszerNev = rdr[1].ToString();
                    item.Napszak = rdr[2].ToString();
                    item.MennyisegF = Convert.ToSingle(rdr[3]);
                    item.Ar = Convert.ToSingle(rdr[4]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetOsszesitesek(string nev, string elsoDatum, string masodikDatum)
        {
            string temp = "select Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, sum(Adagok.Mennyiseg) as Mennyiseg, sum(Adagok.AdagAra) as OsszAr from Gyogyszerek, Szemelyek, Adagok, Napszakok  where Szemelyek.CNP = Adagok.CNP and Gyogyszerek.GyogyszerID = Adagok.GyogyszerID and Adagok.NapszakID = Napszakok.NapszakID and Szemelyek.Nev = '" + nev + "' and Adagok.Datum >= '" + elsoDatum + "' and Adagok.Datum <= '" + masodikDatum + "' group by Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, Napszakok.NapszakID order by Adagok.Datum, Napszakok.NapszakID";
            string query = "select Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, Adagok.Mennyiseg from Adagok, Napszakok, Gyogyszerek, Szemelyek where Napszakok.NapszakID = Adagok.NapszakID and Gyogyszerek.GyogyszerID = Adagok.GyogyszerID  and Szemelyek.CNP = Adagok.CNP and Szemelyek.Nev = '" + nev + "' and Adagok.Datum >= '" + elsoDatum + "' and Adagok.Datum <= '" + masodikDatum + "'";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(temp, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.Datum = rdr[1].ToString();
                    item.Napszak = rdr[2].ToString();
                    item.MennyisegF = Convert.ToSingle(rdr[3]);
                    item.Ar = Convert.ToSingle(rdr[4]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetOsszesitesekPelenka(string nev, string elsoDatum, string masodikDatum)
        {
            string temp = "select Pelenkak.Nev, AdagokPelenka.Datum, sum(AdagokPelenka.Mennyiseg) as Mennyiseg, sum(AdagokPelenka.AdagAra) as OsszAr from Pelenkak, Szemelyek, AdagokPelenka where Szemelyek.CNP = AdagokPelenka.CNP and Pelenkak.PelenkaID = AdagokPelenka.PelenkaID  and Szemelyek.Nev = '" + nev + "' and AdagokPelenka.Datum >= '" + elsoDatum + "' and AdagokPelenka.Datum <= '" + masodikDatum + "' group by Pelenkak.Nev, AdagokPelenka.Datum order by AdagokPelenka.Datum";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(temp, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.Datum = rdr[1].ToString();
                    item.Mennyiseg = Convert.ToInt32(rdr[2]);
                    item.Ar = Convert.ToSingle(rdr[3]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }
        
        public List<DoseStruct> GetTeljesOsszesites(string elsoDatum, string masodikDatum)
        {
            string query = "select Gyogyszerek.Nev, sum(Adagok.Mennyiseg) as OsszMennyiseg, sum (Adagok.AdagAra) as Osszertek from Gyogyszerek, Adagok where Adagok.GyogyszerID = Gyogyszerek.GyogyszerID and Adagok.Datum >= '" + elsoDatum + "'  and Adagok.Datum <= '" + masodikDatum + "' group by Gyogyszerek.Nev";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.OsszMennyisegF = Convert.ToSingle(rdr[1]);
                    item.Osszertek = Convert.ToSingle(rdr[2]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetTeljesOsszesitesPelenka(string elsoDatum, string masodikDatum)
        {
            string query = "select Pelenkak.Nev, sum(AdagokPelenka.Mennyiseg) as OsszMennyiseg, sum (AdagokPelenka.AdagAra) as Osszertek from Pelenkak, AdagokPelenka where AdagokPelenka.PelenkaID = Pelenkak.PelenkaID and AdagokPelenka.Datum >= '" + elsoDatum + "'  and AdagokPelenka.Datum <= '" + masodikDatum + "' group by Pelenkak.Nev";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.OsszMennyiseg = Convert.ToInt32(rdr[1]);
                    item.Osszertek = Convert.ToSingle(rdr[2]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetNevreszoloOsszesites(string elsoDatum, string masodikDatum)
        {
            string query = "select Szemelyek.Nev, Sum(Adagok.AdagAra) as Vegosszeg from Szemelyek, Adagok where Szemelyek.CNP = Adagok.CNP and Adagok.Datum >= '" + elsoDatum +"' and Adagok.Datum <= '" + masodikDatum +"' group by Szemelyek.Nev order by Szemelyek.Nev";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.SzemelyNev = rdr[0].ToString();
                    item.Osszertek = Convert.ToSingle(rdr[1]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetNevreszoloOsszesitesPelenka(string elsoDatum, string masodikDatum)
        {
            string query = "select Szemelyek.Nev, Sum(AdagokPelenka.AdagAra) as Vegosszeg from Szemelyek, AdagokPelenka where Szemelyek.CNP = AdagokPelenka.CNP and AdagokPelenka.Datum >= '" + elsoDatum + "' and AdagokPelenka.Datum <= '" + masodikDatum + "' group by Szemelyek.Nev order by Szemelyek.Nev";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.SzemelyNev = rdr[0].ToString();
                    item.Osszertek = Convert.ToSingle(rdr[1]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetTeljesOsszesitesNevszerint(string nev, string elsoDatum, string masodikDatum)
        {
            string query = "select Gyogyszerek.Nev, sum(Adagok.Mennyiseg) as OsszMennyiseg, sum (Adagok.AdagAra) as Osszertek from Gyogyszerek, Adagok, Szemelyek where Szemelyek.CNP = Adagok.CNP and Szemelyek.Nev = '" + nev + "' and Adagok.GyogyszerID = Gyogyszerek.GyogyszerID and Adagok.Datum >= '" + elsoDatum + "'  and Adagok.Datum <= '" + masodikDatum + "' group by Gyogyszerek.Nev";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.OsszMennyisegF = Convert.ToSingle(rdr[1]);
                    item.Osszertek = Convert.ToSingle(rdr[2]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetTeljesOsszesitesNevszerintPelenka(string nev, string elsoDatum, string masodikDatum)
        {
            string query = "select Pelenkak.Nev, sum(AdagokPelenka.Mennyiseg) as OsszMennyiseg, sum (AdagokPelenka.AdagAra) as Osszertek from Pelenkak, AdagokPelenka, Szemelyek where Szemelyek.CNP = AdagokPelenka.CNP and Szemelyek.Nev = '" + nev + "' and AdagokPelenka.PelenkaID = Pelenkak.PelenkaID and AdagokPelenka.Datum >= '" + elsoDatum + "'  and AdagokPelenka.Datum <= '" + masodikDatum + "' group by Pelenkak.Nev";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.GyogyszerNev = rdr[0].ToString();
                    item.OsszMennyiseg = Convert.ToInt32(rdr[1]);
                    item.Osszertek = Convert.ToSingle(rdr[2]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<string> GetGyogyszerNevLista(string elsoDatum, string masodikDatum)
        {
            string query = "select Distinct Gyogyszerek.Nev from Gyogyszerek, Adagok where Gyogyszerek.GyogyszerID = Adagok.GyogyszerID and Adagok.Datum >= '" + elsoDatum + "' and Adagok.Datum <= '" + masodikDatum + "'";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<string> adagList = new List<string>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    adagList.Add(rdr[0].ToString());
                }
            }
            CloseConnection();
            return adagList;
        }

        public List<DoseStruct> GetTegnapKapottPelenkak(string datum, string nev)
        {
            string query = "select Szemelyek.Nev, Pelenkak.Nev, AdagokPelenka.Mennyiseg, AdagokPelenka.AdagAra from Szemelyek, Pelenkak, AdagokPelenka where Szemelyek.CNP = AdagokPelenka.CNP and AdagokPelenka.PelenkaID = Pelenkak.PelenkaID and Szemelyek.Nev = '" + nev + "' and AdagokPelenka.Datum = '" + datum + "'";
            string error = string.Empty;
            SqlDataReader rdr = myExecuteReader(query, ref error);

            List<DoseStruct> adagList = new List<DoseStruct>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    DoseStruct item = new DoseStruct();
                    item.SzemelyNev = rdr[0].ToString();
                    item.GyogyszerNev = rdr[1].ToString();
                    item.Mennyiseg = Convert.ToInt32(rdr[2]);
                    item.Ar = Convert.ToSingle(rdr[3]);
                    adagList.Add(item);
                }
            }
            CloseConnection();
            return adagList;
        }
     }
}
    
    
    