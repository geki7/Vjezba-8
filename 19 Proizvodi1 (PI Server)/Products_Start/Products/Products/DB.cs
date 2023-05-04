using System.Data.SqlClient;

namespace Products
{
    public class DB
    {
        private static DB instance;
        private string ConnectionString = @"Data Source=31.147.204.119,1433; Database=Labs; User=LabUser; Password:lab2020";
        private SqlConnection Connection;

        public void Connect()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

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

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connection);
            return cmd.ExecuteReader();
        }

        public object DohvatiUpit(string sqlUpit)
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