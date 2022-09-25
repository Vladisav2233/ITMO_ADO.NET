using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;


namespace ADO.NET_Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);
            foreach (NorthwindDataSet.CustomersRow NWCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }

        }
    }
}
