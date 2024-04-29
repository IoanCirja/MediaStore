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
        private string _userName;
        private string _password;

        public User(int Id, string userName, string password)
        {
            _id = Id;
            _userName = userName;
            _password = password;
        }
    }
}
