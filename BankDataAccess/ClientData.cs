using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Data;

namespace BankDataAccess
{
    public class clsClientData
    {
        public static bool GetInfoClient(string AccountNumber, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string Password, ref double Balance)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from Clients where AccountNumber = @Acc ";

            SqlCommand command = new SqlCommand(query, connection);
           command.Parameters.AddWithValue("@Acc", AccountNumber);

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
                    Balance =  Convert.ToDouble( reader["Balance"] );

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
    
        public static bool AddNewClient(string AccountNumber, string FirstName, string LastName, string Email, string Phone, string Password, double Balance)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"INSERT INTO Clients
                             VALUES
                             (@Acc, @firstname, @lastname, @email, @phone, @password, @balance)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Acc", AccountNumber);
            command.Parameters.AddWithValue("@firstname", FirstName);
            command.Parameters.AddWithValue("@lastname", LastName);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@phone", Phone);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@balance", Balance);

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

        public static bool DeleteClient(string AccountNumber)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"Delete From Clients where AccountNumber = @Acc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Acc", AccountNumber);

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

        public static bool UpdateClient(string AccountNumber, string FirstName, string LastName, string Email, string Phone, string Password, double Balance)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"UPDATE Clients
                             SET
                                FirstName = @firstname
                                ,LastName = @lastname
                                ,Email = @email
                                ,Phone = @phone
                                ,Password = @password
                                ,Balance = @balance
                                
                           WHERE AccountNumber = @Acc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Acc", AccountNumber);
            command.Parameters.AddWithValue("@firstname", FirstName);
            command.Parameters.AddWithValue("@lastname", LastName);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@phone", Phone);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@balance", Balance);


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
        
        public static DataTable GetListsClient()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from Clients ";

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

        public static bool SaveTransferLog(string SenderAccountNumber, string ReceiverAccountNumber, double SenderBalance, double ReceiverBalance, double Amount, string username)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);
            string query = @"INSERT INTO TransfersLog
                             VALUES
                             (GetDate() , @AccFrom, @AccTo, @amount, @senBalance, @recBalance, @username)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccFrom", SenderAccountNumber);
            command.Parameters.AddWithValue("@AccTo", ReceiverAccountNumber);
            command.Parameters.AddWithValue("@amount", Amount);
            command.Parameters.AddWithValue("@senBalance", SenderBalance);
            command.Parameters.AddWithValue("@recBalance", ReceiverBalance);
            command.Parameters.AddWithValue("@username", username);


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

        public static DataTable GetListsTransferLog()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionstring);

            string query = "select * from TransfersLog ";

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
