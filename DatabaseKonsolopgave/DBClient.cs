using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace DatabaseKonsolopgave
{
    public class DBClient
    {

        public void Start()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            


            //Create
            //string queryString = "Insert into DemoHotel Values (8, 'Navn', 'Husvej 16')";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Connection.Open();

            //    command.ExecuteNonQuery();
            //}

            // Read
            
            //    string queryString = "select * from Hotel";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
                    
            //        SqlCommand read = new SqlCommand(queryString, connection);
            //        read.Connection.Open();
            //        SqlDataReader reader = read.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(reader.GetInt32(0));
            //            Console.WriteLine(reader.GetString(1));
            //        }
            //    }
            //}

            //Update
            //string queryString = "UPDATE DemoHotel Set Name = 'Navnnn' WHERE Hotel_No = 8";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Connection.Open();

            //    command.ExecuteNonQuery();
            //}

            //Delete
            //string queryString = "Delete from DemoHotel Where Hotel_No = 8";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Connection.Open();

            //    command.ExecuteNonQuery();
            //}









        }
    }

