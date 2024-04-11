using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    class SQLProcedure
    {
        //public static string dbConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ProductDataMQS\db\MQSRequestDatabase.mdb;Jet OLEDB:Database Password=116484;";
        public static string dbConnection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\jagnt092\transfer\ProductDataMQS\db\MQSRequestDatabase.mdb;Jet OLEDB:Database Password=116484;";
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
        public DataTable updatePersistDataBase(string tableName)
        {
            DataTable persistData = new DataTable();
            FormMain frm = FormMain.getInstance();
            try
            {
                string cmdText = string.Format("SELECT * FROM {0}", tableName);
                OleDbConnection con = new OleDbConnection(dbConnection);
                OleDbCommand cmd = new OleDbCommand(cmdText, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(persistData);

                return persistData;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return persistData;
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
            string query1 = "SELECT Family, Process, AvgPASSTime, TotHandle FROM DailyMQSData ORDER BY Family, Process;";
            string query2 = "SELECT Family, Process, AvgPASSTime, TotHandle FROM DailyMQSDataTemp ORDER BY Family, Process;";

            using (var installedDBAdapter = new OleDbDataAdapter(query1, dbConnection))
            using (var baselineDBAdapter = new OleDbDataAdapter(query2, dbConnection))
            using (var installedTable = new DataTable())
            using (var baselineTable = new DataTable())
            {
                try
                {
                    installedDBAdapter.Fill(installedTable);
                    baselineDBAdapter.Fill(baselineTable);

                    int[] columnsToCompare = new int[] { 0, 1, 2, 3 };
                    CompareTables(installedTable, baselineTable, columnsToCompare);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivél comparar os tempos de teste!!! error: " + ex.Message);
                }
            }
        }

        private void ColourRrbText(RichTextBox rtb)
        {
            Regex regExp = new Regex("[*a-zA-Z0-9_:-<>]");

            foreach (Match match in regExp.Matches(rtb.Text))
            {
                rtb.Select(match.Index, match.Length);
                rtb.SelectionColor = Color.Red;
            }
        }
        public bool InsertNewLoginUsertoDb(string userName, string passwordKey)
        {
            bool result = false;
            try
            {
                var con = new OleDbConnection(dbConnection);
                var cmd = new OleDbCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO [Login] ([user], [password]) VALUES ('" + userName + "', '" + passwordKey + "');";
                cmd.Parameters.AddWithValue("@user", userName);
                cmd.Parameters.AddWithValue("@password", passwordKey);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Application.DoEvents();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                result = false;
            }
            return result;

        }
        public void updateAVGTestTimeToMdb(string product, string process, string newTT)
        {
            try
            {
                var con = new OleDbConnection(dbConnection);
                var cmd = new OleDbCommand();
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@Family", product);
                cmd.Parameters.AddWithValue("@Process", process);
                cmd.Parameters.AddWithValue("@AvgPASSTime", newTT);

                cmd.CommandText = "UPDATE DailyMQSData SET AvgPASSTime = " + newTT + " Where Family = '" + product + "' AND Process = '" + process + "'";

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
        private void CompareTables(DataTable table1, DataTable table2, IEnumerable<int> columnsToCompare)
        {
            FormMain frm = FormMain.getInstance();
            int countCompareOut = 0;
            int avgTTOld = 0;
            int avgTTNew = 0;
            int result = 0;
            int filterValue = Convert.ToInt32(frm.textBoxFilterValue.Text);

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
                                    avgTTOld = Convert.ToInt32(table1.Rows[i_rowIndex][colIndex]);
                                    avgTTNew = Convert.ToInt32(table2.Rows[j_rowIndex][colIndex]);
                                    result = avgTTOld - avgTTNew;
                                    if (result < 0)
                                        result = result * -1;
                                    if (!table1.Rows[i_rowIndex][colIndex - 1].ToString().Contains("CAL") && !table1.Rows[i_rowIndex][colIndex - 1].ToString().Contains("NORM") && !table1.Rows[i_rowIndex][colIndex - 1].ToString().Contains("BACKFLASH"))
                                    {
                                        if (result >= filterValue)
                                        {
                                            string temp = ">>Product: " + table1.Rows[i_rowIndex][colIndex - 2].ToString() + "-Process: " + table1.Rows[i_rowIndex][colIndex - 1].ToString() + "-[OLD AvgTestTime: " + table1.Rows[i_rowIndex][colIndex].ToString() + "s" + "]-TotHandle:" + table1.Rows[i_rowIndex][colIndex + 1].ToString() + "<<" + Environment.NewLine + ">>Product: " + table2.Rows[j_rowIndex][colIndex - 2].ToString() + "-Process: " + table2.Rows[j_rowIndex][colIndex - 1].ToString() + "-[NEW AvgTestTime:" + table2.Rows[j_rowIndex][colIndex].ToString() + "s" + "]-TotHandle:" + table2.Rows[i_rowIndex][colIndex + 1].ToString() + "<<" + Environment.NewLine + Environment.NewLine;
                                            frm.richTextBoxCompare.Text += temp;
                                            countCompareOut++;
                                            frm.textBoxFilterCount.Text = countCompareOut.ToString();
                                            frm.textBoxFilterCount.BackColor = Color.OrangeRed;
                                        }
                                    }
                                    Application.DoEvents();
                                    result = 0;

                                }
                            }
                            else
                                Application.DoEvents();

                        }
                        catch { }
                    }
                }
            }
            ColourRrbText(frm.richTextBoxCompare);

            if (countCompareOut == 0)
                frm.richTextBoxCompare.Text = "There's No AvgTestTime changes!!!";

        }
    }
}
