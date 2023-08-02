using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Sample.DAL
{
    public class Database
    {
        string servername = "127.0.0.1";
        string username = "admin";
        string password = "admin@123";
        string dbname = "spc";
        string port = "8888";
        MySqlConnection conn = null;
        string connString = string.Empty;

        public Database()
        {

            connString = String.Format("Server={0};Database={1};Port={2};Uid={3};Pwd={4};" +
           "SsLMode=none;Allow User Variables=True; charset=utf8", servername, dbname, port, username, password);
            conn = new MySqlConnection(connString);
        }
        public DataTable getSPCData()
        {
            string querry = "SET @row_number = 0; " +
                "SET @chunk = 0;SET @total_qty = 0;SET @min_qty = 0;SET @max_qty = 0; " +
                "SELECT chunk, SUM(qty) AS total_qty, ROUND((SUM(qty)/6),1) as average, " +
                "max(qty) as max_qty, min(qty) as min_qty, max(qty) - min(qty) as range_qty " +
                "FROM (SELECT qty, @row_number := @row_number + 1 AS row_num,@chunk := FLOOR((@row_number - 1) / 6) AS chunk, " +
                "@total_qty := @total_qty + qty AS running_total FROM data) AS temp " +
                "GROUP BY chunk LIMIT 50";
            DataTable data = getTable(querry);
            return data;
        }
        public DataTable getHistogramData()
        {
            string querry = "SELECT * FROM data LIMIT 100";
            DataTable data = getTable(querry);
            return data;
        }
        public void DoSql(string query)
        {

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 5;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private DataTable getTable(string querry)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            DataTable data_tmp = new DataTable();
            data_tmp.Load(cmd.ExecuteReader());
            conn.Close();
            return data_tmp;
        }
    }
    public class DBContex
    {

    }
}
