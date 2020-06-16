using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Number_DataBase
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            Show_Prompting("Enter name", NameField);
            Show_Prompting("Enter surname", SurnameField);
            Show_Prompting("Enter login", loginField);
            Show_Prompting("Enter password", PassField);
        }

        public void Show_Prompting(string _fieldspace, TextBox textBox)
        {
            textBox.Text = _fieldspace;
            textBox.ForeColor = Color.Gray;
        }
        public void FieldEnterBC(string _fieldspace, TextBox textBox)
        {
            if (textBox.Text == _fieldspace)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public void FieldLeaveGC(string _fieldspace, TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = _fieldspace;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = PassField.Text;
            string nameUser = NameField.Text;
            string surnameUser = SurnameField.Text;


            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();
            //OPEN CONNECTION
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

            if (NameField.Text == "Enter name" || SurnameField.Text == "Enter surname" || loginField.Text == "Enter login" || PassField.Text == "Enter password")
            {
                Debug_text.Text += "\r\nAccount was not created(Fill in all the fields)...";
                return;
            }
            else
            {
                Debug_text.Text += "\r\nAccount has been created.";
            }
            if (IsUserExists())
                return;

            Debug_text.Text += "\r\nRegistration completed.";
            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`) VALUES (NULL, @uLogin, @uPassword, @uName, @uSurname);", _connection);

            sqlCommand.Parameters.Add("@uLogin",        MySqlDbType.VarChar).Value = loginUser;
            sqlCommand.Parameters.Add("@uPassword", MySqlDbType.VarChar).Value = passUser;
            sqlCommand.Parameters.Add("@uName",       MySqlDbType.VarChar).Value = nameUser;
            sqlCommand.Parameters.Add("@uSurname",  MySqlDbType.VarChar).Value = surnameUser;

            mySqlDataAdapter.SelectCommand = sqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            //CLOSE CONNECTION
            _connection.Close();
            Debug_text.Text += "\r\nConnection Close";
        }

        #region Prompting
        private void NameField_Enter(object sender, EventArgs e) => FieldEnterBC("Enter name",NameField);
        private void NameField_Leave(object sender, EventArgs e) => FieldLeaveGC("Enter name",NameField);

        private void SurnameField_Enter(object sender, EventArgs e) => FieldEnterBC("Enter surname",SurnameField);
        private void SurnameField_Leave(object sender, EventArgs e) => FieldLeaveGC("Enter surname",SurnameField);

        private void loginField_Enter(object sender, EventArgs e) => FieldEnterBC("Enter login",loginField);
        private void loginField_Leave(object sender, EventArgs e) => FieldLeaveGC("Enter login",loginField);

        private void PassField_Enter(object sender, EventArgs e) => FieldEnterBC("Enter password", PassField);
        private void PassField_Leave(object sender, EventArgs e) => FieldLeaveGC("Enter password", PassField);
        #endregion

        public bool IsUserExists()
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", _connection);
            sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            mySqlDataAdapter.SelectCommand = sqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                Debug_text.Text += "\r\nlogin busy";
                return true;
            }
            else
            {
                //Debug_text.Text += "\r\nlogin free";
                return false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Login_window _login_Window = new Login_window();
            _login_Window.Show();
        }
    }
}
