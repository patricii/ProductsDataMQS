using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProductsDataMQS
{ 
    public partial class FormLogin : Form
    {
        private string userName = string.Empty;
        string dbConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ProductDataMQS\db\MQSRequestDatabase.mdb";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Login] Where [user]='" + textBoxUser.Text + "' And [password]='" + textBoxPassword.Text + "'", dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                setUserName(textBoxUser.Text);
                FormMain frm = FormMain.getInstance();
                Hide();
                frm.buttonSave.Enabled = true;
                frm.buttonAddNew.Enabled = true;
                frm.buttonInsertDB.Enabled = true;
                frm.buttonDelete.Enabled = true;

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!!!");
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
            }
        }
        private void setUserName(string UserName)
        {
            userName = UserName;
        }
        public string getUserName()
        {
            return userName;
        }
    }
}
