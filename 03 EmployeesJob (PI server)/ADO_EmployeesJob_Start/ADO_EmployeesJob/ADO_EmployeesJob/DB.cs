using System.Data.SqlClient;
using System.Data;

namespace ADO_EmployeesJob
{
    public class DB
    {
        private static DB instance;
        private string ConnectionString = @"Data Source=31.147.204.119,1433; Database=pubs; User=LabUser21; Password=Lab2021";
        private SqlConnection Connection { get; set; }

        public void Connect()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public static DB Instance
        {
            get
            {
                if(instance != null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        public void Disconnect()
        {
            if(Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public SqlDataReader DohvatiDataReaded(string sqlUpit)
        {
            Connect();
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvriUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}