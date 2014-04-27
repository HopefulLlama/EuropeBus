using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {

        private int id;
        private string email, firstName, surname, phoneNumber, address;
        private DateTime dateOfBirth;
        private bool male;

        #region Customer Getters and Setters
        public int Id
        {
            get { return id; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public bool Male
        {
            get { return male; }
            set { male = value; }
        }
        #endregion

        public Customer(int id, string firstName, string surname, string email, bool male, DateTime dateOfBirth, string phoneNumber, string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.surname = surname;
            this.email = email;
            this.male = male;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
    }
}
