using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    public partial class FormMain : Form
    {
        public static string errorDBMessage = "Não foi possivel conectar com o Banco de Dados! : ";
        public static string successDBMessage = "Data updated successfully!!";
        public static string successDBTempMessage = "DataBase *Temp* updated Successfully!!!";
        public static string updatedDaSuccessfullyMsg = "Banco de dados atualizado com sucesso pelo usuario: ";
        public static string dbTableName = "DailyMQSData";
        public static string dbTableNameTemp = "DailyMQSDataTemp";
        public static string setProcess = string.Empty;
        public static string setFamily = string.Empty;
        public static string setAvgTestTime = string.Empty;
        public static string totHandle = string.Empty;

        ConvertCsvToDt cCTD = new ConvertCsvToDt();
        SQLProcedure sqlProcedure = new SQLProcedure();
        Logger logManager = new Logger();
        FormLogin fl = new FormLogin();

        private static FormMain INSTANCE = null;

        public FormMain()
        {
            InitializeComponent();
            INSTANCE = this;
            setLoegTracking();

        }
        public static FormMain getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormMain();

            return INSTANCE;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                dailyMQSDataTableAdapter.Fill(mQSRequestDatabaseDataSet.DailyMQSData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel conectar ao Banco de Dados!!! error: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add();
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }
        private void updateDB()
        {
            if (comboBoxListToADDdb.Text == "")
                MessageBox.Show("Selecione o Novo AvgTestTime para adicionar!");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente atualizar o AvgTestTime?", "!!!Atenção!!!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string[] vect = comboBoxListToADDdb.Text.Split('-');

                        string product = vect[0];
                        product = product.Replace(">>Product: ", "");

                        string process = vect[1];
                        process = process.Replace("Process: ", "");

                        string avgTT = vect[2];
                        avgTT = avgTT.Replace("[NEW AvgTestTime:", "");
                        avgTT = avgTT.Replace("s]", "");

                        sqlProcedure.updateAVGTestTimeToMdb(product, process, avgTT);

                        logManager.logGen(comboBoxListToADDdb.Text + " User:" + fl.getUserName());

                        MessageBox.Show(updatedDaSuccessfullyMsg + fl.getUserName());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(errorDBMessage + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }
        private void insertDB()
        {
            FormLogin fl = new FormLogin();
            DialogResult dialogResult = MessageBox.Show("Deseja realmente carregar o arquivo .csv? o DataBase será atualizado.", "!!!Atenção!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                try
                {
                    foreach (string file_name in Directory.GetFiles(@"rawdata\", "*.csv*", SearchOption.AllDirectories))
                    {
                        dt = cCTD.ConvertCSVtoDataTable(file_name);
                        dailyMQSDataBindingSource.DataSource = dt;
                        dataGridViewToDt();
                    }
                    MessageBox.Show(updatedDaSuccessfullyMsg + fl.getUserName());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(errorDBMessage + ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
        private void dataGridViewToDt()
        {
            try
            {
                DataTable dt = GetDataTableFromDGV(dataGridViewMQS);
                sqlProcedure.dataTableToMdb(dt, dbTableName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void calMchTime() //to do!!!
        {
            textBoxTTime.BackColor = Color.LightBlue;
            if (textBoxTTime.Text != "")
            {
                if (Convert.ToDouble(textBoxTTime.Text) != 0)
                {
                    textBoxMchTime.Text = (Convert.ToDouble(textBoxTTime.Text) + 12).ToString();
                    textBoxNPI.Text = (Convert.ToDouble(textBoxTTime.Text) + 15).ToString();
                }
            }
        }
        public void readRichTextBoxAndFillComboBox()
        {
            comboBoxListToADDdb.Text = "";
            comboBoxListToADDdb.Items.Clear();
            try
            {
                richTextBoxCompare.Lines.ToList()
                .GetRange(0, richTextBoxCompare.Lines.Count() - 1)
                .Where(line => line.Contains("NEW")).ToList()
                .ForEach(validLine => comboBoxListToADDdb.Items.Add(validLine));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel adicionar os valores de tempo de teste do comparador!!! error: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void initializeFields()
        {
            comboBoxProductsFilter.Items.Clear();
            buttonCompareAvg.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxFilterCount.Text = "";
            buttonCompareAvg.BackColor = Color.LightBlue;
            labelStatusCompare.Text = "Searching...this may take a several seconds...";
            richTextBoxCompare.Text = "";
            Application.DoEvents();
            sqlProcedure.compareAvgTestTime();
            labelStatusCompare.Text = "Finished!";
            buttonUpdate.Enabled = true;
            buttonCompareAvg.Enabled = true;
            buttonCompareAvg.BackColor = Color.LightYellow;
            readRichTextBoxAndFillComboBox();
            setLoegTracking();
        }
        private void saveChangesDB(string type, string allInfos)
        {
            try
            {
                logManager.logGen(type + " [* Manually Update] - " + allInfos + " User:" + fl.getUserName());
                dailyMQSDataBindingSource.EndEdit();
                dailyMQSDataTableAdapter.Update(mQSRequestDatabaseDataSet);
                MessageBox.Show(successDBMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void setField()
        {
            textBoxMchTime.Text = "0";
            textBoxNPI.Text = "0";
            textBoxTTime.Text = "0";
            textBoxPrimeFail.Text = "0";
            textBoxPrimePass.Text = "0";
            textBoxPYield.Text = "0";
            textBoxTFail.Text = "0";
            textBoxTPass.Text = "0";
            textBoxTYield.Text = "0";
            textBoxThandle.Text = "0";
            textBoxLocation.Text = "MDB_Jaguariuna";
        }
        private void verifyAndCreateUserLogin()
        {
            if (textBoxCreatePassword.Text == "" || textBoxCreateUserName.Text == "")
            {
                MessageBox.Show("Preencha corretamente todos os campos!");
            }
            else if (textBoxCreatePassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Os campos [Password] e [Confirm Password] devem ser iguais!");
            }
            else
            {
                SQLProcedure sqlProc = new SQLProcedure();
                bool result = sqlProc.InsertNewLoginUsertoDb(textBoxCreateUserName.Text, textBoxCreatePassword.Text);
                if (result)
                    MessageBox.Show("Novo usuario inserido com sucesso!!");
                else
                    MessageBox.Show("Erro ao inserir novo usuario!!");
            }

            textBoxCreatePassword.Text = "";
            textBoxCreateUserName.Text = "";
            textBoxConfirmPassword.Text = "";
        }
        private void callMQSRequestData()
        {
            try
            {
                labelUpdate.Text = "Updating....";
                Application.DoEvents();
                var process = Process.Start(@"MQSRequestData\MQSRequestData.exe");
                process.WaitForExit();
                labelUpdate.Text = "Updated!!!";
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void yieldEvaluateLogic()
        {
            try
            {
                if (Convert.ToDouble(textBoxPYield.Text) < 96.0)
                    textBoxPYield.BackColor = Color.OrangeRed;
                else if (Convert.ToDouble(textBoxPYield.Text) >= 96.0 && Convert.ToDouble(textBoxPYield.Text) <= 98.5)
                    textBoxPYield.BackColor = Color.LightYellow;
                else if (Convert.ToDouble(textBoxPYield.Text) > 98.5)
                    textBoxPYield.BackColor = Color.LightGreen;
                Application.DoEvents();
            }
            catch { }
        }
        private void setLoegTracking()
        {
            try
            {
                string LogContents = File.ReadAllText(@"\\jagnt092\transfer\ProductDataMQS\log\dbUpdateRecord.txt");
                textBoxLogTracking.Text = LogContents;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////Buttons area/////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string allInfos = fillAllInfos();
            saveChangesDB("SAVE CHANGES", allInfos);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                dailyMQSDataBindingSource.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex.Message);
            }
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            try
            {
                dailyMQSDataBindingSource.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex.Message);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            callMQSRequestData();
            try
            {
                dailyMQSDataBindingSource.DataSource = cCTD.ConvertCSVtoDataTable(textBoxCsvFolder.Text);
                DataTable dt = GetDataTableFromDGV(dataGridViewMQS);
                sqlProcedure.dataTableToMdb(dt, dbTableNameTemp);
                MessageBox.Show(successDBTempMessage);
                initializeFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex.Message);
            }
        }
        private void buttonUpdateToDb_Click(object sender, EventArgs e)
        {
            updateDB();
        }
        private void textBoxPYield_TextChanged(object sender, EventArgs e)
        {
            yieldEvaluateLogic();
        }
        private void textBoxThandle_TextChanged(object sender, EventArgs e)
        {
            totHandle = textBoxThandle.Text;
        }
        private void textBoxFamily_TextChanged(object sender, EventArgs e)
        {
            textBoxFamily.BackColor = Color.LightBlue;
            setFamily = textBoxFamily.Text;
        }

        private void textBoxProcess_TextChanged(object sender, EventArgs e)
        {
            textBoxProcess.BackColor = Color.LightBlue;
            setProcess = textBoxProcess.Text;
        }
        private void textBoxTTime_TextChanged(object sender, EventArgs e)
        {
            calMchTime();
            setAvgTestTime = textBoxTTime.Text;
        }
        private string fillAllInfos()
        {
            string resumeInfos = "[PRODUCT:" + setFamily + "][PROCESS:" + setProcess + "][TestTime:" + setAvgTestTime + "s][TotalHandle:" + totHandle + "]";
            return resumeInfos;
        }
        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            textBoxCreatePassword.Enabled = true;
            textBoxCreateUserName.Enabled = true;
            textBoxConfirmPassword.Enabled = true;
            buttonSaveNew.Enabled = true;
        }
        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            verifyAndCreateUserLogin();
        }
        private void buttonInsertDB_Click(object sender, EventArgs e)
        {
            insertDB();
        }
        private void buttonCompareAvg_Click(object sender, EventArgs e)
        {
            initializeFields();
        }
        private void textBoxFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFilterValue.Text == "0" || textBoxFilterValue.Text == "")
                textBoxFilterValue.Text = "10";
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                dailyMQSDataBindingSource.AddNew();
                setField();
                buttonSave.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex.Message);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente deletar o registro? o DataBase será atualizado.", "!!!Atenção!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string allInfos = fillAllInfos();
                    dailyMQSDataBindingSource.RemoveCurrent();
                    saveChangesDB("DELETE", allInfos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(errorDBMessage + ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
        private void buttonEnableLogin_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void checkBoxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEdit.Checked == true)
            {
                buttonSave.Enabled = true;
                buttonAddNew.Enabled = true;
                buttonDelete.Enabled = true;
                bindingWithPersistDB();
            }
            else
            {
                buttonSave.Enabled = false;
                buttonAddNew.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            bindingWithPersistDB();
        }
        private void bindingWithPersistDB()
        {
            try
            {
                dailyMQSDataBindingSource.DataSource = mQSRequestDatabaseDataSet.DailyMQSData;
                dailyMQSDataTableAdapter.Fill(mQSRequestDatabaseDataSet.DailyMQSData);
                dataGridViewMQS.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel conectar ao banco de dados!!! Error: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxProductsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductsFilter.Text == "")
            {
                //do nothing!!
            }
            else
            {
                initializeFields();
            }

        }

        private void buttonRefreshLogs_Click(object sender, EventArgs e)
        {
            setLoegTracking();
        }
    }
}
