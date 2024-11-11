using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using System.Configuration;

namespace Academy
{
    public static class Connector
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["Academy_PD_311"].ConnectionString;
        static SqlConnection connection;

        static Connector()
        {
            connection = new SqlConnection(connectionString);
        }
        public static DataTable Select(string columns, string tables, string condition = "")
        {
            DataTable table = new DataTable();
            string cmd = $"SELECT {columns} FROM {tables}";
            if (!string.IsNullOrEmpty(condition))
            {
                cmd += $" WHERE {condition}";
            }

            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Columns.Add(reader.GetName(i));
                }

                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
            }

            reader.Close();
            connection.Close();

            return table;
        }

        public static DataTable SelectWithAge(string columns, string tables, string condition = "")
        {
            DataTable table = new DataTable();
            string cmd = $"SELECT {columns}, DATEDIFF(YEAR, birth_date, GETDATE()) - " +
                         "CASE WHEN MONTH(birth_date) > MONTH(GETDATE()) OR " +
                              "(MONTH(birth_date) = MONTH(GETDATE()) AND DAY(birth_date) > DAY(GETDATE())) " +
                         "THEN 1 ELSE 0 END AS age " +
                         $"FROM {tables}";
            if (!string.IsNullOrEmpty(condition))
            {
                cmd += $" WHERE {condition}";
            }

            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Columns.Add(reader.GetName(i));
                }

                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];  
                    }
                    table.Rows.Add(row);
                }
            }

            reader.Close();
            connection.Close();

            return table;
        }
    }
}