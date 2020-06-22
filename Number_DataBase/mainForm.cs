using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            string loginUser = loginField.Text;
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

            if (IsUserExists())
                return;

            //СЛОЖНО
            using (MySqlCommand sqlCommand = new MySqlCommand(" INSERT INTO `books` (`name`, `surname`, `number`,`id_book`,`login`) VALUES ( @nameS, @surnameS, @numberS,NULL,@loginUser)", _connection))
            {
                //СЛОЖНО
                sqlCommand.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
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
            }

            Debug_text.Text += "\r\n" + nameSUser + " = name\r\n" + surnameSUser + " = surname\r\n" + numberSUser + " = number";

        }

        private void NameS_TextChanged(object sender, EventArgs e)
        {

        }

        public bool IsUserExists()
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();



            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", _connection);
            sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            mySqlDataAdapter.SelectCommand = sqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                Debug_text.Text += "\r\n нет таких пользователей ";
                return true;
            }
            else
            {
                Debug_text.Text += "\r\n записано";
                return false;
            }
        }

        private void Show_Bill_Click(object sender, EventArgs e)
        {
            string loginUser = get_bill_login.Text;
            List<string[]> data = new List<string[]>();


            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();

            //if (IsUserExists())
             //   return;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM books WHERE login = @loginUser", _connection);

            sqlCommand.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;

            MySqlDataReader dataReader = sqlCommand.ExecuteReader();
            
            DataTable schemaTable = dataReader.GetSchemaTable();

            while (dataReader.Read())
             {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Debug_text.Text += dataReader.GetString(i);
                }
             }

            dataReader.Close();

            Debug_text.Text += "\r\n" + data;

            mySqlDataAdapter.SelectCommand = sqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            

        }
    }
}
