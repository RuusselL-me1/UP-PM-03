using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ApartmentRental_v1
{
    public static class DatabaseContext
    {
        private static string _cachedConnectionString;

        public static string GetConnectionString()
        {
            if (!string.IsNullOrEmpty(_cachedConnectionString))
            {
                return _cachedConnectionString;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] candidatePaths = new string[]
            {
                Path.Combine(baseDir, "rental.accdb"),
                Path.Combine(baseDir, "..", "rental.accdb"),
                Path.Combine(baseDir, "..", "..", "rental.accdb"),
                Path.Combine(baseDir, "..", "..", "..", "rental.accdb"),
                Path.Combine(baseDir, "ApartmentRental_v1", "rental.accdb")
            };

            string foundPath = null;
            foreach (string p in candidatePaths)
            {
                if (File.Exists(p))
                {
                    foundPath = Path.GetFullPath(p);
                    break;
                }
            }

            if (foundPath == null)
            {
                foundPath = Path.Combine(baseDir, "rental.accdb");
            }

            _cachedConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=False;", foundPath);
            return _cachedConnectionString;
        }

        public static DataTable ExecuteQuery(string query, params OleDbParameter[] parameters)
        {
            DataTable table = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(GetConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }

        public static int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(GetConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, params OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(GetConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
