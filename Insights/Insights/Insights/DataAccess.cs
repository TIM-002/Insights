using System;
using System.Data;
using System.Data.SqlClient;

public class DataAccess
{
    private string connectionString;

    public DataAccess(string dbPath)
    {
        // Define the connection string using the path provided
        connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\{dbPath};Integrated Security=True;";
    }

    public DataTable ExecuteCommand(string query)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
