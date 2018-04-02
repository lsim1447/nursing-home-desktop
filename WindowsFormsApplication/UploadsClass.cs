using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Common;

namespace VersenyekSQL
{
    class UploadsClass : DAL
    {
        private SqlDataAdapter daSzem = new SqlDataAdapter();
        private bool oke = false;
        public UploadsClass()
        {
            if (!base.IsConnectCreated()) //ha a kapcsolat meg nem jott letre(meg nincs letrehozva)
            {
                oke = !base.MakeConnection();
            }
            daSzem.TableMappings.Add("Table", "VersenyGrid");
        }


        public SqlDataReader ListBoxToltDR(ref string ErrM)
        {
            string sSQL = "select Szemelyek.Nev from Szemelyek order by Nev";
            myDataReader = base.myExecuteReader(sSQL, ref ErrM);
            return myDataReader;
        }

        public SqlDataReader ListBoxUploadMedDR(ref string ErrM)
        {
            string sSQL = "select Gyogyszerek.Nev from Gyogyszerek order by Nev";
            myDataReader = base.myExecuteReader(sSQL, ref ErrM);
            return myDataReader;
        }

        public SqlDataReader ListBoxUploadNappyDR(ref string ErrM)
        {
            string sSQL = "select Pelenkak.Nev from Pelenkak order by Nev";
            myDataReader = base.myExecuteReader(sSQL, ref ErrM);
            return myDataReader;
        }
    }
}