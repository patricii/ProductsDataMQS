using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    class SQLProcedure
    {
        string dbConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ProductDataMQS\db\MQSRequestDatabase.mdb";
        string dbTableName = "DailyMQSData";
        public void dataTableToMdb(DataTable dataTable)
        {
            deleteTableProcedure();
            OleDbConnection myConn = new OleDbConnection(dbConnection);
            myConn.Open();
            try
            {
                string strCom = string.Format("SELECT * FROM {0}", dbTableName);
                OleDbDataAdapter da = new OleDbDataAdapter(strCom, myConn);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da)
                {
                    QuotePrefix = "[",
                    QuoteSuffix = "]"
                };
                DataSet midData = new DataSet();
                da.Fill(midData, dbTableName);
                foreach (DataRow dR in dataTable.Rows)
                {
                    DataRow dr = midData.Tables[dbTableName].NewRow();
                    dr.ItemArray = dR.ItemArray;
                    midData.Tables[dbTableName].Rows.Add(dr);
                }
                da.Update(midData, dbTableName);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        private void deleteTableProcedure()
        {
            OleDbConnection myConn = new OleDbConnection(dbConnection);
            try
            {
                myConn.Open();
                string cmdText = string.Format(@"DELETE FROM {0}", dbTableName);
                OleDbCommand cmd = new OleDbCommand(cmdText, myConn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}
