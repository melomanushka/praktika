using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Models
{
    internal class DataBaseModel
    {
        public static readonly string Connect = "Data Source=_MELOMANUSHKA_;Initial Catalog=Praktika;Integrated Security=True";
        public DataBaseModel(){ }

        public bool IsValidLogin(string login, string password)
        {
            bool validUser;

            using (var connection = new SqlConnection(Connect))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM [User] WHERE Login=@Login AND Password=@Password";
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                validUser = command.ExecuteScalar() != null;
            }

            return validUser;
        }
        public bool LoginExists(string login)
        {
            bool exists;

            using (var connection = new SqlConnection(Connect))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "SELECT COUNT(*) FROM [Users] WHERE Login=@Login";
                command.Parameters.AddWithValue("@Login", login);

                exists = (int)command.ExecuteScalar() > 0;
            }

            return exists;
        }

        public void CreateUser(string login, string password, string firstName, string lastName)
        {
            using (var connection = new SqlConnection(Connect))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO [User] (Login, Password, FirstName, LastName, AccessLevel) " +
                                      "VALUES (@Login, @Password, @FirstName, @LastName, 2)";
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);

                command.ExecuteNonQuery();
            }
        }
        public void UpdateUser(UserModel user)
        {
            using (var connection = new SqlConnection(Connect))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "UPDATE [User] SET Login=@Login, Password=@Password, FirstName=@FirstName, " +
                                      "LastName=@LastName, MiddleName=@MiddleName, AccessLevel=@AccessLevel WHERE Id=@UserId";
                command.Parameters.AddWithValue("@UserId", user.Id);
                command.Parameters.AddWithValue("@Login", user.Login);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@AccessLevel", user.AccessLevel);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(Connect))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "DELETE FROM [User] WHERE Id=@UserId";
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
        public UserModel GetUserByLogin(string login)
        {
            UserModel user = null;

            using (var connection = new SqlConnection(Connect))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM [User] WHERE Login=@Login";
                command.Parameters.AddWithValue("@Login", login);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Password = reader["Password"].ToString(),
                            Login = reader["Login"].ToString(),
                            AccessLevel = Convert.ToInt32(reader["AccessLevel"])
                        };
                    }
                }
            }

            return user;
        }
    }
}
