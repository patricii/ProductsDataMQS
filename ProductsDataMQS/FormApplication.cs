using System;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    public partial class FormMain : Form
    {
        public static string errorDBMessage = "Não foi possivel conectar com o Banco de Dados! : ";
        ConvertCsvToDt cCTD = new ConvertCsvToDt();
        public FormMain()
        {
            InitializeComponent();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.dailyMQSDataTableAdapter.Fill(this.mQSRequestDatabaseDataSet.DailyMQSData);
            fillAllInofs();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            fillAllInofs();
            try
            {
                dailyMQSDataBindingSource.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex);
            }
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            fillAllInofs();
            try
            {
                dailyMQSDataBindingSource.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex);
            }
        }
        private void fillAllInofs()
        {
            textBoxAllInfos.Text = "PRODUCT: " + textBoxFamily.Text + " PROCESS: " + textBoxProcess.Text + " PYIELD: " + textBoxPYield.Text + " TT:" + textBoxTTime.Text + " s";
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                dailyMQSDataBindingSource.DataSource = cCTD.ConvertCSVtoDataTable(textBoxCsvFolder.Text);
                MessageBox.Show("DataBase updated Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorDBMessage + ex);
            }

        }
    }
}
