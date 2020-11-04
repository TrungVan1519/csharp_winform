using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Unit3_DataGridView.Data
{
    class Data
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SD7FO63\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

        public void Connect()
        {
            connection.Open();
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public DataTable Table()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from myTable";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void Add(string ID, string Name, string Gender)
        {
            string cmd = "Insert into myTable values('" + ID + "', '" + Name + "', '" + Gender + "')";
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public void Del(string ID)
        {
            string cmd = "Delete from myTable where ID = '" + ID + "'";
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public void Update(string ID, string Name, string Gender)
        {
            string cmd = "Update myTable set Name = '" + Name + "', Gender = '" + Gender + "' where ID = '" + ID + "'";
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
