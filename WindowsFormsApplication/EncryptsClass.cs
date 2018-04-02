using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace VersenyekSQL
{
    class EncryptsClass : DAL
    {
        public EncryptsClass()
        {
            if (!base.IsConnectCreated())
            {
                base.MakeConnection();
            }
        }

        public string Checker(string query)
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
        public string GetMD5(string text)
        {
            OpenConnection();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; ++i)
            {
                str.Append(result[i].ToString("x2"));
            }
            CloseConnection();
            string ret = str.ToString();
            return ret;
        }
        public string Register(string userName, string pass, string totName, string email, string accesId)
        {
            OpenConnection();
            string[] parameterNames = new string[5], parameterValues = new string[5];
            parameterNames[0] = "@pNev"; parameterValues[0] = userName.ToString();
            parameterNames[1] = "@pJelszo"; parameterValues[1] = pass.ToString();
            parameterNames[2] = "@pTeljesNev"; parameterValues[2] = totName.ToString();
            parameterNames[3] = "@pEmail"; parameterValues[3] = email.ToString();
            parameterNames[4] = "@pHozzaferesId"; parameterValues[4] = accesId.ToString();
            string k = ExecuteStoredProcedureNonQuery("Regisztral", parameterNames, parameterValues);
            CloseConnection();
            return k;
        }
    }
}
