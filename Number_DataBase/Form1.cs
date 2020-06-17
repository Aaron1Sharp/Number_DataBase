using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Number_DataBase
{
    public partial class Login_window : Form
    {
        RegisterForm registerForm = new RegisterForm();

        public Login_window()
        {
            InitializeComponent();

            registerForm.Show_Prompting("enter login", loginField);
            registerForm.Show_Prompting("enter password", PassField);
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
            {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }      
            else
                Debug_text.Text += "\r\nuser is NOT registered";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void loginField_Enter(object sender, EventArgs e) => registerForm.FieldEnterBC("enter login", loginField);
        private void loginField_Leave(object sender, EventArgs e) => registerForm.FieldLeaveGC("enter login", loginField);
        
        private void PassField_Enter(object sender, EventArgs e) => registerForm.FieldEnterBC("enter password", PassField);
        private void PassField_Leave(object sender, EventArgs e) => registerForm.FieldLeaveGC("enter password", PassField);

    }
}
