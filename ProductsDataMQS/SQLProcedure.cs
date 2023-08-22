using System;
using System.Collections.Generic;
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
        public bool compareAvgTestTime()
        {
            string query1 = "SELECT Family, Process, AvgPASSTime FROM DailyMQSData ORDER BY Family, Process;";
            string query2 = "SELECT Family, Process, AvgPASSTime FROM DailyMQSDataTemp ORDER BY Family, Process;";

            using (var installedDBAdapter = new OleDbDataAdapter(query1, dbConnection))
            using (var baselineDBAdapter = new OleDbDataAdapter(query2, dbConnection))
            using (var installedTable = new DataTable())
            using (var baselineTable = new DataTable())
            {
                installedDBAdapter.Fill(installedTable);
                baselineDBAdapter.Fill(baselineTable);

                int[] columnsToCompare = new int[] { 0, 1 , 2 };

                return CompareTables(installedTable, baselineTable, columnsToCompare);
            }
        }

        bool CompareTables(DataTable table1, DataTable table2, IEnumerable<int> columnsToCompare)
        {
            if (table1.Rows.Count != table2.Rows.Count)
                return false;

            for (int rowIndex = 0; rowIndex < table1.Rows.Count; rowIndex++)
            {
                foreach (int colIndex in columnsToCompare)
                {
                    if (!table1.Rows[rowIndex][colIndex].Equals(table2.Rows[rowIndex][colIndex]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
