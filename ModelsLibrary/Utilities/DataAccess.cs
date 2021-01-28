using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;

namespace ModelsLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                var output = cn.Query<T>(sql, new DynamicParameters()).ToList();
                return output;
            }
        }

        public void SaveData<T>(T user, string sql)
        {
            using (IDbConnection cn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                cn.Execute(sql, user);
            }
        }

        public void UpdateData<T>(T user, string sql)
        {
            using (IDbConnection cn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                cn.Execute(sql, user);
            }
        }
        public string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
