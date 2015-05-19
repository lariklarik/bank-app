using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Project_University
{
    public partial class AuthWindow : Form
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string password = GetHashMD5(GetHashMD5(passwordTB.Text));
            string Connect = "database=my_db;datasource=localhost;username=root;password=123456";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand("select * from soft_users where login='" + login + "' and hpwd='" + password + "'", myConnection);

            myConnection.Open();
            MySqlDataReader rdr = myCommand.ExecuteReader();

            if (rdr.Read())
            {
                this.Hide();
                MainWindow mw = new MainWindow();
                mw.Show();

            }
            else
                MessageBox.Show("Incorrect login or password");

            
            myConnection.Close();
        }

        private string GetHashMD5(string s)
        {
            MD5CryptoServiceProvider md5CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = md5CSP.ComputeHash(Encoding.UTF8.GetBytes(s));
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < byteHash.Length; i++)
                result.Append(byteHash[i].ToString("x2"));
            return result.ToString();
        }
    }
}
