using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VersenyekSQL;


namespace VersenyekSQL
{
    public class InsertionClass : DAL
    {
        public string InsertNewPerson(string name,  string cnp)
        {
            string[] parameterNames = new string[2], parameterValues = new string[2];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            parameterNames[1] = "@Cnp"; parameterValues[1] = cnp.ToString();

            string vissza = ExecuteStoredProcedureNonQuery("UjEmber", parameterNames, parameterValues);
            return vissza;
        }

        public string InsertNewMedicine(string name, string unit, string type, int nr)
        {
            string[] parameterNames = new string[4], parameterValues = new string[4];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            parameterNames[1] = "@Mertekegyseg"; parameterValues[1] = unit.ToString();
            parameterNames[2] = "@Tipus"; parameterValues[2] = type.ToString();
            parameterNames[3] = "@Darab"; parameterValues[3] = nr.ToString();

            string vissza = ExecuteStoredProcedureNonQuery("UjGyogyszer", parameterNames, parameterValues);
            return vissza;
        }
        public string UploadMedicineStock(string name, int num, float price, string date)
        {
            string stringValue = price.ToString().Replace(',', '.');
            string[] parameterNames = new string[4], parameterValues = new string[4];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            parameterNames[1] = "@DobozSzam"; parameterValues[1] = num.ToString();
            parameterNames[2] = "@Ar"; parameterValues[2] = stringValue;
            parameterNames[3] = "@Datum"; parameterValues[3] = date.ToString();

            string vissza = ExecuteStoredProcedureNonQuery("KeszletFeltoltese", parameterNames, parameterValues);
            return vissza;
        }
        public string UploadNappyStock(string name, int num, float price, string date)
        {
            string stringValue = price.ToString().Replace(',', '.');
            string[] parameterNames = new string[4], parameterValues = new string[4];
            parameterNames[0] = "@Nev"; parameterValues[0] = name.ToString();
            parameterNames[1] = "@DobozSzam"; parameterValues[1] = num.ToString();
            parameterNames[2] = "@Ar"; parameterValues[2] = stringValue;
            parameterNames[3] = "@Datum"; parameterValues[3] = date.ToString();

            string vissza = ExecuteStoredProcedureNonQuery("KeszletFeltoltesePelenkaval", parameterNames, parameterValues);
            return vissza;
        }
        public string AddNewDose(string persName, string medName, string partOfTheDay, string date ,int num)
        {
            string[] parameterNames = new string[5], parameterValues = new string[5];
            parameterNames[0] = "@SzemelyNeve"; parameterValues[0] = persName.ToString();
            parameterNames[1] = "@GyogyszerNeve"; parameterValues[1] = medName.ToString();
            parameterNames[2] = "@Napszak"; parameterValues[2] = partOfTheDay.ToString();
            parameterNames[3] = "@Datum"; parameterValues[3] = date.ToString();
            parameterNames[4] = "@Mennyiseg"; parameterValues[4] = num.ToString();

            string vissza = ExecuteStoredProcedureNonQuery("ujAdagHozzaadasa", parameterNames, parameterValues);
            return vissza;
        }
        public string AddAllMedicine(string pName, string medName, string potd, string date, int userId)
        {
            string[] parameterNames = new string[5], parameterValues = new string[5];
            parameterNames[0] = "@SzemelyNeve"; parameterValues[0] = pName.ToString();
            parameterNames[1] = "@GyogyszerNeve"; parameterValues[1] = medName.ToString();
            parameterNames[2] = "@Napszak"; parameterValues[2] = potd.ToString();
            parameterNames[3] = "@Datum"; parameterValues[3] = date.ToString();
            parameterNames[4] = "@felhasznaloId"; parameterValues[4] = userId.ToString();

            string vissza = ExecuteStoredProcedureNonQuery("OsszesAdagHozzaadasa", parameterNames, parameterValues);
            return vissza;
        }
        public string AddAllNappy(string pName, string nappyName, string date, int userId)
        {
            string[] parameterNames = new string[4], parameterValues = new string[4];
            parameterNames[0] = "@SzemelyNeve"; parameterValues[0] = pName.ToString();
            parameterNames[1] = "@PelenkaNeve"; parameterValues[1] = nappyName.ToString();
            parameterNames[2] = "@Datum"; parameterValues[2] = date.ToString();
            parameterNames[3] = "@felhasznaloId"; parameterValues[3] = userId.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("OsszesPelenkaAdagHozzaadasa", parameterNames, parameterValues);
            return vissza;
        }
        public string CNPmodified(string oldCnp, string newCnp, string name)
        {
            string[] parameterNames = new string[3], parameterValues = new string[3];
            parameterNames[0] = "@regiCNP"; parameterValues[0] = oldCnp.ToString();
            parameterNames[1] = "@ujCNP"; parameterValues[1] = newCnp.ToString();
            parameterNames[2] = "@Nev"; parameterValues[2] = name.ToString();
            string vissza = ExecuteStoredProcedureNonQuery("CNPmodosito", parameterNames, parameterValues);
            return vissza;
        }
    }
}