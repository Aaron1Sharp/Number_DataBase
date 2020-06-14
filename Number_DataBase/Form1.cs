using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Number_DataBase
{
    public partial class login_window : Form
    {
        public login_window()
        {
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = PassField.Text;

            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();

            try
            {
                Debug_text.Text = "Openning Connection ...";
                _connection.Open();
                Debug_text.Text += "\r\nConnection successful!\r\n...";
            }
            catch
            {
                Debug_text.Text += "\r\nError";
            }

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass`  = @uP",_connection);
            
            sqlCommand.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginUser;
            sqlCommand.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passUser;

            mySqlDataAdapter.SelectCommand = sqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                Debug_text.Text += "\r\nuser is registered";           
            else
                Debug_text.Text += "\r\nuser is NOT registered";
            

        }

        private void Debug_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
