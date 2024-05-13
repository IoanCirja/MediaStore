using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public class User
    {
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _email;
        private string _phoneNumber;
        private string _password;
        
        public int Id
        {
            get { return _id; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public string FirstName
        {
            get { return _firstName; }
        }
        public string Email
        {
            get { return _email; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }
        public string Password
        {
            get { return _password; }
        }


        public User(int Id, string email, string password)
        {
            _id = Id;
            _email = email;
            _password = password;
        }
    }
}
