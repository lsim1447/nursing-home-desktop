using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace VersenyekSQL
{
    /// <summary>
    /// Summary description for DAL.
    /// </summary>
    public abstract class DAL
    {
        protected static bool kapcsolodva;
        protected static bool ConnectionCreated;

        //ebben a projektben egy SQL szerveren futo adatbazishoz akarunk csatlakozni
        //SQL adatbazishoz SqlConnection objektumokkal kapcsolodhatunk
        protected static SqlConnection mySqlConn;

        //kapcsolati karakterlanc: szerver neve, adatbazis neve, kapcsolodas modja

        protected string strSqlConn = "Data Source=DESKTOP-GS9HEBT;Initial Catalog=OregOtthonProjekt;Integrated Security=SSPI";
        //protected string strSqlConn = "Data Source=(local);Initial Catalog=OregOtthonProjekt;user=szilard;password=szilardka1";//Integrated Security=SSPI";
            
        //parancsobjektum-ezek segitsegevel tudunk SQL utasitasokat vegrehajtani
        //parancsobjektumok a kapcsolati objektumok segitsegevel tartanak kapcsolatot 
        //az adatbazissal
        protected System.Data.SqlClient.SqlCommand myComm;
        //a kovetkezo ket objektum segitsegevel az adatbazisbol adatokat olvashatunk be
        //illetve tarolhatjuk ezeket
        protected System.Data.SqlClient.SqlDataReader myDataReader;
        protected System.Data.DataSet myDataSet;

        //igaz, ha a kapcsolat letrejott-a szarmaztatott osztaly konstruktoraba kell
        protected bool IsConnectCreated()
        {
            return ConnectionCreated;
        }

        protected bool IsConnected()
        {
            return kapcsolodva;
        }

        protected System.Data.SqlClient.SqlConnection theConnection()
        { return mySqlConn; }

        //kapcsolatot teremt az adatbazissal, ha ez meg nem tortent meg eddig 
        protected bool MakeConnection()
        {
            // Create the Connection if is was not already created.
            if (ConnectionCreated != true)
            {
                try
                {
                    //uj OleDbConnection objektum letrehozasa
                    //ezzel a konstruktorral letrehoztuk a kapcsolati objektumot es beallitottuk a ConnectionString
                    //tulajdonsagat is
                    //ez csak akkor allithato be, ha a kapcsolati objektum zarva van
                    mySqlConn = new  SqlConnection(strSqlConn);
                    //kapcsolodunk az adatbazishoz
                    mySqlConn.Open();
                    ConnectionCreated = true; //logikai valtozo-igaz, ha a kapcsolat letrejott
                    //be is zarjuk a kapcsolatot-igyekeznunk kell minel kevesebb ideig nyitva hagyni a kapcsolatot,
                    //mert igy sporolunk az adatbazis eroforrasaival
                    mySqlConn.Close();
                    kapcsolodva = false;
                    //igazat terithetunk vissza, hisz a kapcsolat gond nelkul letrejott
                    return true;
                }
                catch(Exception e)
                {
                    string str;
                    str = e.Message;
                    return false;
                }
            }
            else { return true; }
        }

        //vegrehajtja az elso parameterben megadott stringben levo select utasitast
        //egy eredmenyhalmaz jon letre ezaltal, melyet egy DataReader objektumban tarolunk el
        //es teritunk vissza
        protected SqlDataReader myExecuteReader(string sQuery, ref string ErrMess)
        {
            try
            {
                this.OpenConnection();//megnyitja az adatbazis-kapcsolatot, ha meg nincs megnyitva) 

                //uj sqlcommand objektumot igy is letrehozhatunk:
                //sQuery-tartalmazza az SQL utasitast, melybol adatot kerunk le
                //mySqlConn-SqlConnection objektum 
                myComm = new SqlCommand(sQuery,mySqlConn);
                //myComm OleDbCommand CommandText tulajdonsagat atkuldi a myAccesConn
                //connectionnek es letrehoz egy DataReadert

                //ExectuerReader tagfgv-olyan select utasitasok vegrehajtasara szolgal, melyek
                //eredmenyhalmazt adnak vissza-az eredmenyhalmaz egy DataReader objektumban ter vissza
                myDataReader = myComm.ExecuteReader();
                ErrMess = "OK";

                return myDataReader;

            }
            catch (SqlException e)
            {
                ErrMess = e.Message;
                this.CloseConnection();
                return null;
            }
        }
        /// <summary>
        /// Open the Connection when the state is not already open.
        /// </summary>
        protected bool OpenConnection()
        {
            // Open the Connection when the state is not already open.
            if (kapcsolodva != true)
            {
                try
                {
                    mySqlConn.Open();
                    kapcsolodva = true;
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else { return true; }
        }
        protected string ExecuteStoredProcedureNonQuery(string name, string[] parameterNames, string[] parameterValues)
        {
            string error;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(name, mySqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameterNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                }
                cmd.ExecuteNonQuery();

                error = "OK";
            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            finally
            {
                CloseConnection();
            }
            return error;
        }
        protected string ExecuteNonQuery(string command)
        {
            string error;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(command, mySqlConn);
                cmd.ExecuteNonQuery();
                error = "OK";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return error;

        }
        //bezarjuk a kapcsolatot, ha meg nyitva van
        internal void CloseConnection()
        {
            // Close the Connection when the connection is opened.
            if (kapcsolodva == true)
            {
                mySqlConn.Close();
                kapcsolodva = false;
            }
        }        
    }
}