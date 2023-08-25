﻿using System;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormMain frm = FormMain.getInstance();
            if (textBoxUser.Text == "test" && textBoxPassword.Text == "test123")
            {
                Hide();
                frm.updateDB();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!!!");
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
