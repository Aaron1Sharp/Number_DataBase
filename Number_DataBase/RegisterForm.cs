using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Show_Prompting(string _fieldspace, TextBox textBox)
        {
            textBox.Text = _fieldspace;
            textBox.ForeColor = Color.Gray;
        }

        private void FieldEnterBC(string _fieldspace,TextBox textBox)
        {
            if (textBox.Text == _fieldspace)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        private void FieldLeaveGC(string _fieldspace, TextBox textBox)
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

            try
            {
                Debug_text.Text = ("Connection Getting...");
                _connection.Open();
                Debug_text.Text += ("\r\nConnection Open...");
            }
            catch 
            {
                Debug_text.Text = ("Connection Close");
            }

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass`  = @uP", _connection);
            sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            sqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            mySqlDataAdapter.SelectCommand = sqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                Debug_text.Text += "\r\nuser is registered! change login or password";
            else
                Debug_text.Text += "\r\nuser is NOT registered";
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
    }
}
