using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Common;

namespace VersenyekSQL
{
    class StoredProcedureRetClass:DAL
    {
        private SqlDataAdapter dataAdapterTarolt;
        private bool Err;

        public StoredProcedureRetClass()
        {
            if (!base.IsConnectCreated()) //ha a kapcsolat meg nem jott letre(meg nincs letrehozva)
            {
                Err = !base.MakeConnection();
            }
            dataAdapterTarolt = new SqlDataAdapter();
            dataAdapterTarolt.TableMappings.Add("Table", "VersenyGrid");
        }
        public string AddNewMedicineDose(string persName, string medName, string potd, string date, float num, int userId, ref string Errm)
        {
            try
            {
                OpenConnection();
                myComm = new SqlCommand("ujAdagHozzaadasa", mySqlConn);
                myComm.Parameters.Add("@SzemelyNeve", SqlDbType.VarChar, 50).Value = persName;
                myComm.Parameters.Add("@GyogyszerNeve", SqlDbType.VarChar, 50).Value = medName;
                myComm.Parameters.Add("@Napszak", SqlDbType.VarChar, 50).Value = potd;
                myComm.Parameters.Add("@Datum", SqlDbType.VarChar, 50).Value = date;
                myComm.Parameters.Add("@Mennyiseg", SqlDbType.Float).Value = num;
                myComm.Parameters.Add("@felhasznaloId", SqlDbType.Int).Value = userId;
                SqlParameter pOut = new SqlParameter("@pOut", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                myComm.Parameters.Add(pOut);
                myComm.CommandType = CommandType.StoredProcedure;
                dataAdapterTarolt.SelectCommand = myComm;
                DataSet ds = new DataSet("Cica");

                dataAdapterTarolt.Fill(ds);
                int parOut = (int)pOut.Value;
                if (parOut == 1)
                {
                    CloseConnection();
                    Errm = "OK";
                    return "OK";
                }
                else
                {
                    Errm = "NemOK";
                    return "NemOK";
                }
            }
            catch (Exception ex)
            {
                Errm = ex.Message;
                return null;
            }
        }

        public string AddNewNappyDose(string persName, string nappyName, string date, int num, int userId, ref string Errm)
        {
            try
            {
                OpenConnection();
                myComm = new SqlCommand("ujPelenkaAdagHozzaadasa", mySqlConn);
                myComm.Parameters.Add("@SzemelyNeve", SqlDbType.VarChar, 50).Value = persName;
                myComm.Parameters.Add("@PelenkaNeve", SqlDbType.VarChar, 50).Value = nappyName;
                myComm.Parameters.Add("@Datum", SqlDbType.VarChar, 50).Value = date;
                myComm.Parameters.Add("@Mennyiseg", SqlDbType.Int).Value = num;
                myComm.Parameters.Add("@felhasznaloId", SqlDbType.Int).Value = userId;
                SqlParameter pOut = new SqlParameter("@pOut", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                myComm.Parameters.Add(pOut);
                myComm.CommandType = CommandType.StoredProcedure;
                dataAdapterTarolt.SelectCommand = myComm;
                DataSet ds = new DataSet("Cica");

                dataAdapterTarolt.Fill(ds);
                int parOut = (int)pOut.Value;
                if (parOut == 1)
                {
                    CloseConnection();
                    Errm = "OK";
                    return "OK";
                }
                else
                {
                    Errm = "NemOK";
                    return "NemOK";
                }
            }
            catch (Exception ex)
            {
                Errm = ex.Message;
                return null;
            }
        }
    }
}