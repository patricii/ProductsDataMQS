using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    public partial class FormMain : Form
    {
        public static string errorDBMessage = "Não foi possivel conectar com o Banco de Dados! : ";
        public static string successDBMessage = "Data saved successfully!!";
        ConvertCsvToDt cCTD = new ConvertCsvToDt();
        public FormMain()
        {
            InitializeComponent();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dailyMQSDataTableAdapter.Fill(mQSRequestDatabaseDataSet.DailyMQSData);           
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
        private void yieldEvaluateLogic()
        {
            if (Convert.ToDouble(textBoxPYield.Text) < 96.0)
                textBoxPYield.BackColor = Color.Red;
            else if (Convert.ToDouble(textBoxPYield.Text) >= 96.0 && Convert.ToDouble(textBoxPYield.Text) <= 98.5)
                textBoxPYield.BackColor = Color.Yellow;
            else if (Convert.ToDouble(textBoxPYield.Text) > 98.5)
                textBoxPYield.BackColor = Color.LightGreen;
            Application.DoEvents();
        }
        private void fillAllInofs()
        {
            textBoxAllInfos.Text = "[PRODUCT: " + textBoxFamily.Text + "] [PROCESS: " + textBoxProcess.Text + "] [PYIELD: " + textBoxPYield.Text + "] [TestTime:" + textBoxTTime.Text + " s]";
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            callMQSRequestData();

            try
            {
                dailyMQSDataBindingSource.DataSource = cCTD.ConvertCSVtoDataTable(textBoxCsvFolder.Text);
                MessageBox.Show("DataBase updated Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex.Message);
            }
        }
        private void textBoxPYield_TextChanged(object sender, EventArgs e)
        {
            yieldEvaluateLogic();
            fillAllInofs();
        }
        private void textBoxFamily_TextChanged(object sender, EventArgs e)
        {
            textBoxFamily.BackColor = Color.LightBlue;
        }

        private void textBoxProcess_TextChanged(object sender, EventArgs e)
        {
            textBoxProcess.BackColor = Color.LightBlue;
        }
        private void callMQSRequestData()
        {
            labelUpdate.Text = "Updating....";
            Application.DoEvents();
            var process = Process.Start(@"C:\ProductDataMQS\MQSRequestData\MQSRequestData.exe");
            process.WaitForExit();
            labelUpdate.Text = "Updated!!!";
            Application.DoEvents();
        }
        private void textBoxTTime_TextChanged(object sender, EventArgs e)
        {
            calMchTime();
        }
        private void calMchTime() //to do!!!
        {
            textBoxTTime.BackColor = Color.LightSkyBlue;
            textBoxMchTime.BackColor = Color.LightYellow;
            textBoxNPI.BackColor = Color.Orange;
            if (textBoxTTime.Text != "")
            {
                if (Convert.ToDouble(textBoxTTime.Text) != 0)
                {
                    textBoxMchTime.Text = (Convert.ToDouble(textBoxTTime.Text) + 12).ToString();
                    textBoxNPI.Text = (Convert.ToDouble(textBoxTTime.Text) + 15).ToString();
                }

            }
        }
    }
}
