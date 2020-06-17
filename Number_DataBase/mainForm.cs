using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Number_DataBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameSUser = NameS.Text;
            string surnameSUser = SurnameS.Text;
            string numberSUser = NumberS.Text;
            
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();

            try
            {
                Debug_text.Text = "Connection Getting...";
                _connection.Open();
                Debug_text.Text += "\r\nConnection Open...";
            }
            catch
            {
                Debug_text.Text += "\r\nConnection Close";
            }
                //СЛОЖНО
            MySqlCommand sqlCommand = new MySqlCommand("" +
                "INSERT INTO `books`(`id_users`) SELECT `id` FROM `users`; INSERT INTO `books` (`id_users`, `name`, `surname`, `number`) VALUES (`id_users`, @nameS, @surnameS, @numberS)", _connection);
            //СЛОЖНО
            sqlCommand.Parameters.Add("@nameS", MySqlDbType.VarChar).Value = nameSUser;
            sqlCommand.Parameters.Add("@surnameS", MySqlDbType.VarChar).Value = surnameSUser;
            sqlCommand.Parameters.Add("@numberS", MySqlDbType.VarChar).Value = numberSUser;


            try
            {
                mySqlDataAdapter.SelectCommand = sqlCommand;
                mySqlDataAdapter.Fill(dataTable);
            }
            catch (Exception)
            {
                Debug_text.Text += "\r\nERROR FOR ID ROW 1";
            }
            
            Debug_text.Text += "\r\n" + nameSUser + " = name\r\n" + surnameSUser + " = surname\r\n" + numberSUser + " = number";

        }

        private void NameS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
