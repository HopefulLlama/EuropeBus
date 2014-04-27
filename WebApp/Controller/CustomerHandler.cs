using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SqlDb;

namespace WebApp.Controller
{
    public class CustomerHandler
    {
        public static bool addCustomer(string firstName, string surname, string email, string password, int gender, DateTime dateOfBirth, string phoneNumber, string address)
        {
            string command = "INSERT INTO ebCustomer(first_name, surname, email, password, male, date_of_birth, phone_no, address) VALUES (@FirstName, @Surname, @Email, CONVERT(VARCHAR(32), HashBytes('MD5', @Password), 2), @Male, @DateOfBirth, @PhoneNumber, @Address)";

            SqlCommand sqlCommand = new SqlCommand(command, DbConn.getInstance().Conn);
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Surname", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Male", SqlDbType.Int);
            sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
            sqlCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar);

            sqlCommand.Parameters["@FirstName"].Value = firstName;
            sqlCommand.Parameters["@Surname"].Value = surname;
            sqlCommand.Parameters["@Email"].Value = email;
            sqlCommand.Parameters["@Password"].Value = password;
            sqlCommand.Parameters["@Male"].Value = gender;
            sqlCommand.Parameters["@DateOfBirth"].Value = dateOfBirth;
            sqlCommand.Parameters["@PhoneNumber"].Value = phoneNumber;
            sqlCommand.Parameters["@Address"].Value = address;

            DbConn.getInstance().Conn.Open();
            int affectedRows = sqlCommand.ExecuteNonQuery();
            DbConn.getInstance().Conn.Close();

            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}