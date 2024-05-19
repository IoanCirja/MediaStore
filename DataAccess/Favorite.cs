using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public class Favorite
    {
        public string name;
        public string price;
        public string description;
        public string user;


        public Favorite(string name, string price, string description, string user)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.user = user;
        }

    }
}

