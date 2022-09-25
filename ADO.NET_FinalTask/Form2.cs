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


namespace ITMO_124_16_ADO.NET_IvanovVA_MyDBApp
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = FormAuthorization.connection;

        /*
        private void LoadButtonButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from users";
            SqlDataReader reader = command.ExecuteReader();

            ListViewItem item = null;
            while (reader.Read())
            {
                item = new ListViewItem(new string[] {Convert.ToString(reader["id"]),
                    Convert.ToString (reader["Name"]),
                    Convert.ToString (reader["Srname"]),
                    Convert.ToString (reader["Age"]),
                    Convert.ToString (reader["idCompany"])});
                listView1.Items.Add(item);
        
            }
        */
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Surname", "Фамилия");
            dataGridView1.Columns.Add("Age", "Возраст");
            dataGridView1.Columns.Add("idCompany", "idCompany");
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataReader record)
        { 
        dataGridView.Rows.Add(record.GetInt32 (0), record.GetString (1), record.GetString(2), record.GetString(3), record.GetInt32(4));
        }

        private void refreshDataGrid (DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string sqlquery = @"select * from [dbo].[Users]";
            SqlCommand command = new SqlCommand(sqlquery, FormAuthorization.connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            refreshDataGrid(dataGridView1);
        }

        private void delete()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string sqlqueryDel = $"delete from [dbo].[Users] wherw id = {index}";
            SqlCommand command = new SqlCommand(sqlqueryDel, FormAuthorization.connection);
            command.ExecuteNonQuery();
            refreshDataGrid(dataGridView1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var surname = textBoxSurname.Text;
            var Age = textBoxAge.Text;
            int idcompany = Convert.ToInt32(textBoxIdCompany.Text);
            string sqlAddQuery = $"insert into [dbo].[Users] ([Name], [Surname], [Age], [idCompany]) values ('{name}', '{surname}', '{Age}', '{idcompany}')";
            SqlCommand command = new SqlCommand(sqlAddQuery, FormAuthorization.connection);
            command.ExecuteNonQuery();
            refreshDataGrid(dataGridView1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string sqlqueryDel = $"delete from [dbo].[Users] where id = {index}";
            SqlCommand command = new SqlCommand(sqlqueryDel, FormAuthorization.connection);
            command.ExecuteNonQuery();
            refreshDataGrid(dataGridView1);
        }

        private void buttonFillTextBox_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxSurname.Text = row.Cells[2].Value.ToString();
            textBoxAge.Text = row.Cells[3].Value.ToString();
            textBoxIdCompany.Text = row.Cells[4].Value.ToString();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var Name = textBoxName.Text;
            var Surname = textBoxSurname.Text;
            var Age = textBoxAge.Text;
            var idCompany = textBoxIdCompany.Text;
            var sqlqueryChange = $"update [dbo].[Users] set [Name] = '{Name}', [Surname] = '{Surname}',[Age] = '{Age}', [idCompany] = '{idCompany}' where id = '{id}'";
            SqlCommand command = new SqlCommand(sqlqueryChange, FormAuthorization.connection);
            command.ExecuteNonQuery();
            refreshDataGrid(dataGridView1);

        }

        private void buttonCloseConnection_Click(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }
    }

        
    
}
