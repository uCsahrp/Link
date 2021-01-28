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
        #region LoadData

        /// <summary>
        /// loading any data from 
        /// </summary>
        /// <typeparam name="T">
        /// model of the data 
        /// </typeparam>
        /// <param name="sql">
        /// sql querry
        /// </param>
        /// <returns>
        /// List of the model obeject
        /// </returns>
        public List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                var output = cn.Query<T>(sql, new DynamicParameters()).ToList();
                return output;
            }
        }
        //Implementation example:
        //public List<UserModel> LoadUsers()
        //{
        //    /*string sql = "select * from Users";*/

        //    var output = _database.LoadData<UserModel>("select UserName, Email, Password, IsStudent from Users");

        //    return output;
        //}

        #endregion

        #region SaveData
        /// <summary>
        /// Save data to the database
        /// </summary>
        /// <typeparam name="T">
        /// model of data that you wish to come as
        /// </typeparam>
        /// <param name="user">Model</param>
        /// <param name="sql">sql querry</param>
        public void SaveData<T>(T user, string sql)
        {
            using (IDbConnection cn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                cn.Execute(sql, user);
            }
        }
        //implementation example:
        //public void SaveUser(UserModel user)
        //{
        //    string sql = "insert into Users (UserName,Email,Password,Access) " +
        //        "values (@UserName, @Email, @Password, @Access)";

        //    /* sql = sql.Replace("@UserId", $"'{ user.UserId }'");*/
        //    sql = sql.Replace("@UserName", $"'{ user.UserName }'");
        //    sql = sql.Replace("@Email", $"'{ user.Email }'");
        //    sql = sql.Replace("@Password", $"'{ user.Password }'");
        //    sql = sql.Replace("@Access", $"{ user.Access }");
        //    /*sql = sql.Replace("@IsStudent", $"{ user.IsStudent }");*/
        //    /*sql = sql.Replace("@TimeStamp", $"{ user.TimeStamp }");*/

        //    _database.SaveData(user, sql);
        //}
        #endregion

        #region UpdateData
        /// <summary>
        /// Update Data in the database
        /// </summary>
        /// <typeparam name="T">Model of data</typeparam>
        /// <param name="sql">sql querry</param>
        public void UpdateData<T>(string sql)
        {
            using (IDbConnection cn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                cn.Execute(sql, new DynamicParameters());
            }
        }

        //Implementation example:
        /* public void UpdateUser<UserMode>(int id,string username)
         {
             string sql = "UPDATE Users SET UserName = @Username WHERE ID = @CategoryID;";
             _database.UpdateData(sql,new {UserName =username, ID=id});
         }*/

        #endregion

        #region LoadConnectionString
        /// <summary>
        /// get the connection string
        /// </summary>
        /// <param name="id">connection string name</param>
        /// <returns></returns>
        public string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        #endregion
    }
}
