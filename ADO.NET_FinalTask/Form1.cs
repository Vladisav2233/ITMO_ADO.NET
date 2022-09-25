using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms.VisualStyles;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace ITMO_124_16_ADO.NET_IvanovVA_MyDBApp
{
    public partial class FormAuthorization : Form

    {
        
        public FormAuthorization()
        {
            InitializeComponent();
        }
        public static SqlConnection connection = new SqlConnection();


    private void EnterButton_Click(object sender, EventArgs e)
        {
            string userlogin = LoginTextBox.Text;
            string userpassword = PasswordTextBox.Text;

            
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    //connection.ConnectionString = @"Server = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\vladi\OneDrive\Рабочий стол\ADO.NET\ITMO_124-16_ADO.NET_IvanovVA_MyDBApp\ITMO_124-16_ADO.NET_IvanovVA_MyDBApp.mdf; Integrated Security = True; Connect Timeout = 30";
                    //connection.ConnectionString = "Provider = SQLOLEDB.1; Password = " + userpassword + "; Persist Security Info = True; User ID = " + userlogin + "; Initial Catalog = Northwind; Data Source = IVANOV\\SQLEXPRESS";
                    connection.ConnectionString = $@"Server = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\vladi\OneDrive\Рабочий стол\ADO.NET\ITMO_124-16_ADO.NET_IvanovVA_MyDBApp\ITMO_124-16_ADO.NET_IvanovVA_MyDBApp.mdf; Integrated Security = False; User ID = {userlogin}; Password = {userpassword}; Connect Timeout = 30";
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных установленно");
                    this.Hide();
                    Form2 dbform = new Form2();
                    dbform.Show();
                    
                }
                else

                    MessageBox.Show("Ошибка приложения");

            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }
        static class conectionstring
        {
            public static string Value { get; set; }
            
        }


    }
}
