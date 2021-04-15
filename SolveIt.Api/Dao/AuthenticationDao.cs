using Microsoft.Data.SqlClient;
using SolveIt.Model;
using System;
using System.Data;

namespace SolveIt.Dao
{
    public interface IAuthenticationDao
    {
        bool CreateUser(CreateUser createUser);
        UserModel LoginUser(LoginUser loginUser);
    }
    public class AuthenticationDao : DatabaseSettings, IAuthenticationDao
    {

        public bool CreateUser(CreateUser createUser)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("User_SignUp", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", createUser.Name);
                    cmd.Parameters.AddWithValue("@Email", createUser.EmailId);
                    cmd.Parameters.AddWithValue("@mobile", createUser.MobileNumber);
                    cmd.Parameters.AddWithValue("@password_1", createUser.Password);
                    cmd.Parameters.AddWithValue("@class", createUser.Class);
                    cmd.Parameters.AddWithValue("@Role", "S");

                    cmd.ExecuteReader();
                    return true;
                } 
            }
        }

        public UserModel LoginUser(LoginUser loginUser)
        {
            UserModel user = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("User_Login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Credential", loginUser.MobileNumber ?? loginUser.Email);
                    cmd.Parameters.AddWithValue("@Password_1", loginUser.Password);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            user = new UserModel
                            {
                                Name = (string)rdr["StudentName"],
                                EmailId = (string)rdr["Email"],
                                MobileNumber = (string)rdr["Mobile"],
                                UserId = (int)rdr["StudentId"]
                            };
                        }
                    }
                }
                return user;
            }
        }
    }
}
