using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using Model;
using SqlDb;

namespace WebApp.Controller
{
    public class LogInHandler
    {
        public static Customer logIn(string logInEmail, string logInPassword)
        {
            try
            {
                string command = "SELECT customer_ID, first_name, surname, email, male, date_of_birth, phone_no, address FROM ebCustomer WHERE email = @Email AND password = CONVERT(VARCHAR(32), HashBytes('MD5', @Password), 2);";
                SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);

                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar);
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar);

                sqlCommand.Parameters["@Email"].Value = logInEmail;
                sqlCommand.Parameters["@Password"].Value = logInPassword;

                DbConn.getInstance().open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("customer_ID"));
                        string firstName = reader.GetString(reader.GetOrdinal("first_name"));
                        string surname = reader.GetString(reader.GetOrdinal("surname"));
                        string email = reader.GetString(reader.GetOrdinal("email"));
                        bool male = reader.GetBoolean(reader.GetOrdinal("male"));
                        DateTime dateOfBirth = reader.GetDateTime(reader.GetOrdinal("date_of_birth"));
                        string phoneNumber = reader.GetString(reader.GetOrdinal("phone_no"));
                        string address = reader.GetString(reader.GetOrdinal("address"));
                        Customer user = new Customer(id, firstName, surname, email, male, dateOfBirth, phoneNumber, address);
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                DbConn.getInstance().close();
            }
        }

    }
}