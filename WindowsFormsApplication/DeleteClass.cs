using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VersenyekSQL;


namespace VersenyekSQL
{
    public class DeleteClass : DAL
    {
        public string DeletePerson(string name)
        {
            string[] parameterNames = new string[1], parameterValues = new string[1];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("TorolEmber", parameterNames, parameterValues);
            return vissza;
        }
        public string DeleteMedicine(string name)
        {
            string[] parameterNames = new string[1], parameterValues = new string[1];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("TorolGyogyszer", parameterNames, parameterValues);
            return vissza;
        }
        public string DeleteNappy(string name)
        {
            string[] parameterNames = new string[1], parameterValues = new string[1];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("TorolPelenka", parameterNames, parameterValues);
            return vissza;
        }
        public string DeleteFromMedicineStorage(string name, float num, float price, string date)
        {
            string[] parameterNames = new string[4], parameterValues = new string[4];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            parameterNames[1] = "@Mennyiseg"; parameterValues[1] = num.ToString().Replace(',', '.');
            parameterNames[2] = "@Ar"; parameterValues[2] = price.ToString().Replace(',', '.');
            parameterNames[3] = "@Datum"; parameterValues[3] = date.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("TorolRaktarbol", parameterNames, parameterValues);
            return vissza;
        }
        public string DeleteFromNappyStorage(string persName, int num, float price, string date)
        {
            string[] parameterNames = new string[4], parameterValues = new string[4];
            parameterNames[0] = "@Nev"; parameterValues[0] = persName.ToString();
            parameterNames[1] = "@Mennyiseg"; parameterValues[1] = num.ToString();
            parameterNames[2] = "@Ar"; parameterValues[2] = price.ToString().Replace(',', '.');
            parameterNames[3] = "@Datum"; parameterValues[3] = date.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("TorolPelenkatRaktarbol", parameterNames, parameterValues);
            return vissza;
        }
        public string DeleteAndRecoverMedicine(string persId, string medId, string nid, string mid, string date, string dosePrice)
        {
            string[] parameterNames = new string[6], parameterValues = new string[6];
            parameterNames[0] = "@szid"; parameterValues[0] = persId.ToString();
            parameterNames[1] = "@gyid"; parameterValues[1] = medId.ToString();
            parameterNames[2] = "@nid"; parameterValues[2] = nid.ToString();
            parameterNames[3] = "@mid"; parameterValues[3] = mid.ToString().Replace(',', '.');
            parameterNames[4] = "@datum"; parameterValues[4] = date.ToString();
            parameterNames[5] = "@adagAra"; parameterValues[5] = dosePrice.ToString().Replace(',', '.');
            string vissza = ExecuteStoredProcedureNonQuery("TorolVisszaallitGyogyszer", parameterNames, parameterValues);
            return vissza;
        }
        public string DeleteAndRecoverNappy(string persId, string medID, string mid, string date, string dosePrice)
        {
            string[] parameterNames = new string[5], parameterValues = new string[5];
            parameterNames[0] = "@szid"; parameterValues[0] = persId.ToString();
            parameterNames[1] = "@pid"; parameterValues[1] = medID.ToString();
            parameterNames[2] = "@mid"; parameterValues[2] = mid.ToString();
            parameterNames[3] = "@datum"; parameterValues[3] = date.ToString();
            parameterNames[4] = "@adagAra"; parameterValues[4] = dosePrice.ToString().Replace(',', '.');
            string vissza = ExecuteStoredProcedureNonQuery("TorolVisszaallitPelenka", parameterNames, parameterValues);
            return vissza;
        }
    }
}