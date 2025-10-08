using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using INF2011S_Project_Group22.Properties;

namespace INF2011S_Project_Group22.Data
{
    class DB
    {
        #region Variable declaration

        private string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\new inf2011s project\\INF2011S_Project_Group22\\HotelBookingDB.mdf;Integrated Security=True;Encrypt=False";//connection string used to connect to the HotelBookingDB
        protected SqlConnection cnMain; //represents a connection in the database 
        protected DataSet dsMain; //An in-memory collection of the data
        protected SqlDataAdapter daMain; // delivers data from the database to the dataset
        public enum DBOperation //The three operations that will be performed on the database 
        {
            add,
            edit,
            delete
        }
        #endregion

        #region Constructor
        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion

        #region Update the DateSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                cnMain.Open();
                //update the database table via the data adapter
                daMain.Update(dsMain, table);
                //close the connection
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}
//qwertyuiop
