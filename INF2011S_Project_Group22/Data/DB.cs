using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




using INF2011S_Project_Group22.Properties;


//testing commit

namespace INF2011S_Project_Group22.Data
{
    class DB
    {
        //innocent change
        #region Variable declaration

        //
        private string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hello\\Desktop\\new_Group22\\INF2011S_Project_Group22\\HotelBookingDB.mdf;Integrated Security=True;Encrypt=False";
        //private string strConn = Settings.Default.HotelBookingDBConnectionString; //connection string used to connect to the HotelBookingDB
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
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(aSQLstring, cnMain))
                {
                    if (cnMain.State != ConnectionState.Open)
                        cnMain.Open();

                    adapter.Fill(dsMain, aTable);
                }
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "\n" + errObj.StackTrace, "Error Filling DataSet");
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }
        }

        #endregion

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success = true;

            try
            {
                if (cnMain.State != ConnectionState.Open)
                    cnMain.Open();

                daMain.Update(dsMain, table);
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "\n" + errObj.StackTrace, "Error Updating DataSource");
                success = false;
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }

            // Refresh dataset after update
            FillDataSet(sqlLocal, table);

            return success;
        }

        #endregion
    }
}
