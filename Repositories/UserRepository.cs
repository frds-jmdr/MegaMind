using System.Data.SqlClient;
using System.Data.Sql;
using Dapper;
using  System.Data.SqlTypes;
using MegaMind.Repositories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using MegaMind.Models;



namespace MegaMind.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionStrings;

        public UserRepository(IConfiguration configuration)
        {
            SqlConnection _connectionStrings = configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            using (var connection = new SqlConnection(_connectionStrings))
            {
                return connection.Query<UserModel>("SELECT * FROM users");
            }
        }

        public UserModel GetUserById(int id)
        {
            using (var connection = new SqlConnection(_connectionStrings))
            {
                return connection.QuerySingleOrDefault<UserModel>("spGetUserById", new { Id = id }, commandType: CommandType.StoredProcedure);
            }
        }

        public void AddUser(UserModel user)
        {
            using (var connection = new SqlConnection(_connectionStrings))
            {
                connection.Execute("spInsertUser", user, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUser(UserModel user)
        {
            using (var connection = new SqlConnection(_connectionStrings))
            {
                connection.Execute("spUpdateUser", user, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteUser(int id)
        {
            using (var connection = new SqlConnection(_connectionStrings))
            {
                connection.Execute("spDeleteUser", new { Id = id }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}