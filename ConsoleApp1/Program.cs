using System;
//using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "3,'a','b','c','d'";
            string myConnectionString = "server=192.168.2.104;database=db1;uid=n;pwd=secret;";

            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = "INSERT INTO Persons Values(" + data + ")";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
        }
    }
}

/*
 *                 MySqlConnection cnn;
                string connetionString = "server=192.168.2.104;database=db1;uid=n;pwd=secret;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    Console.Write("Connection Open ! ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                Console.WriteLine("Can not open connection ! ");
                Console.WriteLine(ex);
                }
                */


