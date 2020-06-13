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
            Console.WriteLine("Getting Connection ...");
            MySqlConnection _connection = DataBaseUtils.GetMySqlConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");

                _connection.Open();
                MessageBox.Show("Connection successful!");
                Console.WriteLine("Connection successful!");
            }
            catch 
            {
                MessageBox.Show("Error");
                Console.WriteLine("Error: ");
            }
        }
    }
}
