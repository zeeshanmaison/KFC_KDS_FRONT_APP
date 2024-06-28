using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCKDS.Helper
{
    public static class SqlHelper
    {
        public static int ExecuteNonQuery(string connectionString, string query, CommandType commandType = CommandType.Text, Dictionary<string, object> parameters = null)
        {
            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = commandType;

            if (parameters != null && parameters.Count > 0)
            {
                foreach (string key in parameters.Keys)
                {
                    string parameterName = key.Replace("@", "");
                    command.Parameters.AddWithValue(string.Format("@{0}", parameterName), parameters[key]);
                }
            }

            affectedRows = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            connection.Dispose();

            return affectedRows;
        }

        public static DataSet ExecuteDataSet(string connectionString, string query, CommandType commandType = CommandType.Text, Dictionary<string, object> parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.CommandType = commandType;
            adapter.SelectCommand.CommandTimeout = 90;

            if (parameters != null && parameters.Count > 0)
            {
                foreach (string key in parameters.Keys)
                {
                    string parameterName = key.Replace("@", "");
                    adapter.SelectCommand.Parameters.AddWithValue(string.Format("@{0}", parameterName), parameters[key]);
                }
            }

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            return dataSet;
        }

        public static IList<T> ExecuteList<T>(string connectionString, string query, CommandType commandType = CommandType.Text, Dictionary<string, object> parameters = null)
        {
            DataSet dataSet = ExecuteDataSet(connectionString, query, commandType, parameters);
            IList<T> list = null;

            if (dataSet != null && dataSet.Tables != null && dataSet.Tables.Count > 0)
            {
                //TODO:
                //list = DataHelper.ConvertToList<T>(dataSet.Tables[0]);
            }

            return list;
        }
    }
}
