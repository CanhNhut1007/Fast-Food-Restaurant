using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast_Food_Restaurant.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }
        private DataProvider() { }
        private string query = Program.str_query;
       
        protected SqlConnection cnn;
        protected SqlCommand cm;

        internal DataTable ExecuteReader(string query)
        {
            throw new NotImplementedException();
        }

        internal DataTable ExecuteReader(string query, object[] v)
        {
            throw new NotImplementedException();
        }

        protected SqlDataAdapter adapter;

        protected void connect()
        {
            cnn = new SqlConnection(query);
            cnn.Open();
        }
        protected void disconnect()
        {
            cnn.Close();
        }

        public DataTable ExecuteQuery(string sql, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (cnn = new SqlConnection(query))
            {
                connect();
                cm = new SqlCommand(sql, cnn);
                cm.CommandType = CommandType.StoredProcedure;
                if (parameter != null)
                {
                    foreach (object item in parameter)
                    {
                        cm.Parameters.Add(item);
                    }
                }
                adapter = new SqlDataAdapter(cm);
                adapter.Fill(data);
                disconnect();
            }

            return data;
        }
        public SqlDataReader ReadData(string ss)
        {
            cnn = new SqlConnection();

            connect();
            cm = cnn.CreateCommand();
            cm.CommandText = ss;
            cm.CommandType = CommandType.Text;
            SqlDataReader reader = cm.ExecuteReader();
            return reader;
        }
        public void DisConnect()
        {
            disconnect();
        }
        public int ExecuteNonQuery(string sql, object[] parameter = null)
        {
            int data = 0;
            using (cnn = new SqlConnection(query))
            {
                connect();
                cm = new SqlCommand(sql, cnn);
                cm.CommandType = CommandType.StoredProcedure;
                if (parameter != null)
                {
                    foreach (object item in parameter)
                    {
                        cm.Parameters.Add(item);
                    }
                }
                data = cm.ExecuteNonQuery();
            }

            disconnect();
            return data;
        }
        public object ExecuteScalar(string sql)
        {
            object data = 0;
            using (cnn = new SqlConnection(query))
            {
                connect();
                cm = new SqlCommand(sql, cnn);
            }
           
            data = cm.ExecuteScalar();
            disconnect();
            return data;
        }

    }
}
