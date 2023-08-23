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
        public void dataTableToMdb(DataTable dataTable, string tableName)
        {
            deleteTableProcedure(tableName);
            OleDbConnection myConn = new OleDbConnection(dbConnection);
            myConn.Open();
            try
            {
                string strCom = string.Format("SELECT * FROM {0}", tableName);
                OleDbDataAdapter da = new OleDbDataAdapter(strCom, myConn);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da)
                {
                    QuotePrefix = "[",
                    QuoteSuffix = "]"
                };
                DataSet midData = new DataSet();
                da.Fill(midData, tableName);
                foreach (DataRow dR in dataTable.Rows)
                {
                    DataRow dr = midData.Tables[tableName].NewRow();
                    dr.ItemArray = dR.ItemArray;
                    midData.Tables[tableName].Rows.Add(dr);
                }
                da.Update(midData, tableName);
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
        private void deleteTableProcedure(string tableName)
        {
            OleDbConnection myConn = new OleDbConnection(dbConnection);
            try
            {
                myConn.Open();
                string cmdText = string.Format(@"DELETE FROM {0}", tableName);
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
        public void compareAvgTestTime()
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

                int[] columnsToCompare = new int[] { 0, 1, 2 };

                CompareTables(installedTable, baselineTable, columnsToCompare);
            }
        }

        private void CompareTables(DataTable table1, DataTable table2, IEnumerable<int> columnsToCompare)
        {
            int countCompare = 0;
            FormMain frm = FormMain.getInstance();
            for (int i_rowIndex = 0; i_rowIndex < table1.Rows.Count; i_rowIndex++)
            {
                for (int j_rowIndex = 0; j_rowIndex < table2.Rows.Count; j_rowIndex++)
                {
                    foreach (int colIndex in columnsToCompare)
                    {
                        try
                        {
                            if (table1.Rows[i_rowIndex][colIndex - 2].Equals(table2.Rows[j_rowIndex][colIndex - 2]) && table1.Rows[i_rowIndex][colIndex - 1].Equals(table2.Rows[j_rowIndex][colIndex - 1]))
                            {
                                if (!table1.Rows[i_rowIndex][colIndex].Equals(table2.Rows[j_rowIndex][colIndex]))
                                {
                                    frm.textBoxCompare.Text += "[Product: " + table1.Rows[i_rowIndex][colIndex - 2].ToString() + " - Process: " + table1.Rows[i_rowIndex][colIndex - 1].ToString() + " - Old AvgTestTime: " + table1.Rows[i_rowIndex][colIndex].ToString() + "s ]" + Environment.NewLine + "[Product: " + table2.Rows[j_rowIndex][colIndex - 2].ToString() + " - Process: " + table2.Rows[j_rowIndex][colIndex - 1].ToString() + " - New AvgTestTime: " + table2.Rows[j_rowIndex][colIndex].ToString() + "s ]" + Environment.NewLine + Environment.NewLine;
                                    countCompare++;
                                    frm.textBoxCompareCount.Text = countCompare.ToString();
                                    Application.DoEvents();

                                }
                            }
                        }
                        catch { }
                    }
                }
            }
        }
    }
}
