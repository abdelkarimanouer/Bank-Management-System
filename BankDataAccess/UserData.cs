using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public class clsUserData
    {
        public static bool GetInfoUser(string UserName, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string Password, ref int Permissions)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from Users where UserName = @Usname ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Usname", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permission"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static bool GetInfoUserByUserNameAndPassword(string UserName, ref string FirstName, ref string LastName, ref string Email, ref string Phone, string Password, ref int Permissions)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from Users where UserName = @Usname and Password = @ps ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Usname", UserName);
            command.Parameters.AddWithValue("@ps", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Permissions = (int)reader["Permission"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;
        }

        public static bool AddNewUser(string UserName, string FirstName, string LastName, string Email, string Phone, string Password, int Permissions)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"INSERT INTO Users
                             VALUES
                             (@usname, @firstname, @lastname, @email, @phone, @password, @perm)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@usname", UserName);
            command.Parameters.AddWithValue("@firstname", FirstName);
            command.Parameters.AddWithValue("@lastname", LastName);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@phone", Phone);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@perm", Permissions);

            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (RowEffected > 0);
        }

        public static bool DeleteUser(string UserName)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"Delete From Users where UserName = @usname";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@usname", UserName);

            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (RowEffected > 0);
        }

        public static bool UpdateUser(string UserName, string FirstName, string LastName, string Email, string Phone, string Password, int Permissions)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"UPDATE Users
                             SET
                                FirstName = @firstname
                                ,LastName = @lastname
                                ,Email = @email
                                ,Phone = @phone
                                ,Password = @password
                                ,Permission = @Permissions
                                
                           WHERE UserName = @usname";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@usname", UserName);
            command.Parameters.AddWithValue("@firstname", FirstName);
            command.Parameters.AddWithValue("@lastname", LastName);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@phone", Phone);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);


            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }



            return (RowEffected > 0);
        }

        public static DataTable GetListsUser()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from Users ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public static bool SaveLoginRegisters(string username, string Password, int permissions)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"INSERT INTO LoginsRegisters
                             VALUES
                             (GetDate(), @username, @pw, @permissions)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@pw", Password);
            command.Parameters.AddWithValue("@permissions", permissions);


            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (RowEffected > 0);
        }

        public static DataTable GetListsLoginRegisters()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from LoginsRegisters ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

    }
}
