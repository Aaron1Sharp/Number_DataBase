using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Number_DataBase
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {    
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();

            try
            {
                Debug_text.Text = "Getting Connection ..." 
                           + "\r\n Openning Connection ...";

                _connection.Open();

                Debug_text.Text = "Getting Connection ..."
                            + "\r\nOpenning Connection ..." 
                            + "\r\nConnection successful! ";
            }
            catch 
            {
                Debug_text.Text = "Getting Connection ..."
                            + "\r\nOpenning Connection ..."
                            + "\r\nError ";
            }
        }
    }
}
