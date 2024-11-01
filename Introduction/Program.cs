﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//namespace Introduction
//{

//	class Program
//	{
//		const string connectionString = @"
//                Data Source=(localdb)\MSSQLLocalDB;
//                Initial Catalog=Library;
//                Integrated Security=True;
//                Connect Timeout=30;Encrypt=False;
//                TrustServerCertificate=False;
//                ApplicationIntent=ReadWrite;
//                MultiSubnetFailover=False";
//		static SqlConnection connection;
//		static Program()
//		{
//			connection = new SqlConnection(connectionString);
//		}
//		static void Main(string[] args)
//		{
//			SelectAuthors();

//			string cmd = " SELECT title, first_name, last_name FROM Books, Authors WHERE author = author_id";
//			SqlCommand command = new SqlCommand( cmd,connection);
//			connection.Open();
//			SqlDataReader reader = command.ExecuteReader();
//			if (reader.HasRows)
//			{
//				int padding = 32;
//				for (int i = 0; i < reader.FieldCount; i++)
//					Console.Write(reader.GetName(i).PadRight(padding));
//					Console.WriteLine();
//				while (reader.Read())
//				{
//					for (int i = 0; i < reader.FieldCount; i++)
//					{ 
//						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
//					}
//						Console.WriteLine("\n---------------------------------------------------\n");
//				}
//				Console.WriteLine();
//			}
//			connection.Close();
//		}
//		static void SelectAuthors()
//		{
//			SqlCommand command = new SqlCommand();
//			command.Connection = connection;
//			command.CommandText = "SELECT * FROM Authors";

//			connection.Open();
//			SqlDataReader reader = command.ExecuteReader();
//			const int padding = 32;
//			if (reader.HasRows)
//			{
//				for (int i = 0; i < reader.FieldCount; i++)
//					Console.Write(reader.GetName(i).PadRight(padding));
//				Console.WriteLine();

//				while (reader.Read())
//				{

//					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
//					for (int i = 0; i < reader.FieldCount; i++)
//						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
//					Console.WriteLine();
//				}

//			}
//			connection.Close();
//			Console.WriteLine("Done");
//		}
//	}
//}


namespace Introduction
{
    class Program
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

        static Program()
        {
            connection = new SqlConnection(connectionString);
        }

        static void Main(string[] args)
        {
            Select("Authors", "author_id, first_name, last_name");
            Select("Books", "title, author");
            Select("Books, Authors", "title, first_name, last_name");
        }

        static void Select(string tables, string fields)
        {
            string cmd = $"SELECT {fields} FROM {tables}";

            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            const int padding = 32;
            if (reader.HasRows)
            {
                // Вывод заголовков
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).PadRight(padding));
                Console.WriteLine();

                // Вывод данных
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write(reader.GetValue(i).ToString().PadRight(padding));
                    Console.WriteLine();
                }
                Console.WriteLine("\n---------------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("Нет данных для отображения.");
            }

            connection.Close();
        }
    }
}

