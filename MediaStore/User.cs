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
        private string _email;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;

        public int Id
        {
            get { return _id; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Password
        {
            get { return _password; }
        }


        public User(int Id, string userName, string password)
        {
            _id = Id;
            _email = userName;
            _password = password;
        }

        public User()
        {
            _id = -1;
            _email = "";
            _password = "";
        }


    }
}
