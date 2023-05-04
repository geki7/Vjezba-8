﻿using System.Data.SqlClient;

namespace ADO_Titles
{
    public class DB
    {
        private static DB instance;
        private string ConnectionString = @"Data Source=31.147.204.119,1433; Database=pubs; User=LabUser21; Password=Lab2021";
        private SqlConnection Connection;

        public static DB Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        public void Connect()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connection);
            return cmd.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connection);
            return cmd.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connection);
            return cmd.ExecuteNonQuery();
        }
    }
}