using System.Data.SqlClient;

namespace ADO_Products
{
    public class DB
    {
        private static DB instance;
        private string ConnectionString = @"Data Source=31.147.204.119,1433; Database=NorthWind; User=LabUser21; Password=Lab2021";
        private SqlConnection Connetcion;

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
            Connetcion = new SqlConnection(ConnectionString);
            Connetcion.Open();
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connetcion);
            return cmd.ExecuteReader();
        }

        public object DohvatiUpit(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connetcion);
            return cmd.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sqlUpit, Connetcion);
            return cmd.ExecuteNonQuery();
        }
    }
}