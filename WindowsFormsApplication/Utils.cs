using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VersenyekSQL
{
    public class Utils
    {
        public Utils()
        {
        }

        public static void ListboxToltoDR(System.Windows.Forms.ListBox lb, System.Data.SqlClient.SqlDataReader drSzemelyek)
        {
            //amig van mit olvasni a DataReaderbol
            while (drSzemelyek.Read())
            {
                //a DataReader objektum soraibol az egyes oszlopertekeket kiolvashatjuk, 
                //ha megadjuk az oszlop nevet vagy a "sorszamat"
                //(hanyadik a datareaderben)
                //szogletes zarojelek kozott
                lb.Items.Add(drSzemelyek[0].ToString());//NyaraloNev
            }
            //mindig le kell zarni a DataReader objektumokat, mert a DataReader lefoglalja
            //a Connection objektumot es a tobbi parancs addig nem tud vegrehajtodni mig a 
            //Connection objektumhoz tartozo DR nyitva van
            drSzemelyek.Close();
        }        
    }
}