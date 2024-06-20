using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.UI
{
    public class PersonalData
    {
        public static int IdUser { get; set; }
        public static string Password { get;  set; }
        public static string Login { get;  set; }
        public static bool IsAdmin { get; set; }

        public bool SetPersonalData(string login, string password)
        {
            var db = new DB();

            string sqlExpression = "SELECT TOP 1 * FROM Users WHERE Login = @Login AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(db.stringCon()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            IdUser = (int)reader["Id"];
                            Login = reader["Login"].ToString();
                            Password = reader["Password"].ToString();
                            IsAdmin = (bool)reader["IsAdmin"];
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}
