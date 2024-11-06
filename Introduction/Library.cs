using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Introduction
{
	class Library
	{
		const string connectionString = @"
                Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=Library;
                Integrated Security=True;
                Connect Timeout=30;Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False";
		static SqlConnection connection;
		static Library()
		{
			connection = new SqlConnection(connectionString);
		}
		public static void InsertBook(string title, string first_name, string last_name)
		{
			int author = GetAuthorId(first_name, last_name);
			string cmd = $"INSERT Books(title,author) VALUES ('{title}', '{author}')";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static int GetAuthorId(string first_name, string last_name)
		{
			string cmd = $"(SELECT author_id FROM Authors WHERE first_name =@first_name AND last_name = @last_name)";
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.AddWithValue("@first_name", first_name);
			command.Parameters.AddWithValue("@last_name", last_name);
			connection.Open();
			int author_id = Convert.ToInt32(command.ExecuteScalar());
			connection.Close();
			return author_id;
		}
		public static void InsertAuthor(string first_name, string last_name)
		{
			string cmd = $"INSERT  Authors(first_name,last_name)VALUES ('{first_name}','{last_name}')";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static void Select(string columns, string tables, string condition)
		{
			string cmd = $"Select {columns} FROM {tables} WHERE {condition}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				int padding = 28;
				for (int i = 0; i < reader.FieldCount; i++)
				{
					Console.Write(reader.GetName(i).PadRight(padding));
				}
				Console.WriteLine();
				//Console.WriteLine("\n------------------------------------------------------------------------------------\n");
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(padding));
					}
					Console.WriteLine();
				}
			}
			reader.Close();
			connection.Close();
		}

		public static void SelectBooks()
		{
			string cmd = " SELECT title, first_name, last_name FROM Books, Authors WHERE author = author_id";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				int padding = 32;
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					}
					Console.WriteLine("\n---------------------------------------------------\n");
				}
				Console.WriteLine();
			}
			reader.Close();
			connection.Close();
		}
		public static void SelectAuthors()
		{
			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.Parameters.AddWithValue("@id", "author_id");
			command.Parameters.AddWithValue("@first_name", "first_name");
			command.Parameters.AddWithValue("@last_name", "last_name");
			command.Parameters.AddWithValue("@Table", "Authors");
			command.CommandText = "SELECT @id,@first_name,@last_name FROM Authors";
			
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			const int padding = 32;
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();

				while (reader.Read())
				{

					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
					for (int i = 0; i < reader.FieldCount; i++)
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					Console.WriteLine();
				}

			}
			reader.Close();
			connection.Close();
			Console.WriteLine("Done");
		}
		
	}
}



