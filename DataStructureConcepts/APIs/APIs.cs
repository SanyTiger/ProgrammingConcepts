using System;
using MySql.Data.MySqlClient;

namespace APIs
{
    public class APIs
    {
        // using MySql.Data.MySqlClient;
        MySqlConnection conn;

        // Converting from Int to Bytes
        public void IntToByte()
        {
            int intValue = 10;
            var intBytes = BitConverter.GetBytes(intValue);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(intBytes);
            byte[] result = intBytes;
        }

        // Read data from a text file and add o tot the My SQL DB
        public void TextToDB()
        {
            //MySQL connection details
            string password = "Apple2016";
            string username = "SanjayBhat";
            string serverName = "127.0.0.1";
            string databaseName = "company";

            // Location of the files given containing the data values for insert
            string worksOnFilePathName = "E:\\UTA\\2nd Sem\\DB1\\Project\\WORKS_ON.txt";

            try
            {
                conn = new MySqlConnection("server=" + serverName + "; uid=" + username + "; pwd=" + password + "; database=" + databaseName + "; ");
                conn.Open();
            }
            // Close the MySQL DB connection
            catch (MySqlException ex)
            { conn.Close(); }
        }
    }
}
