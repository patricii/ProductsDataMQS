using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    public partial class FormLogin : Form
    {
        public static string userName = string.Empty;
       
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
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Login] Where [user]='" + textBoxUser.Text + "' And [password]='" + textBoxPassword.Text + "'", SQLProcedure.dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                setUserName(textBoxUser.Text);
                FormMain frm = FormMain.getInstance();
                frm.labelUserLogin.Text = "User: " + textBoxUser.Text;
                Hide();

                if (textBoxUser.Text == "admin")
                    frm.buttonInsertDB.Enabled = true;

                frm.checkBoxEdit.Enabled = true;
                frm.comboBoxListToADDdb.Enabled = true;
                frm.buttonUpdateToDb.Enabled = true;

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
