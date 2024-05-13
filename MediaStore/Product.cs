using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public class Product
    {
        public Image image;
        public string name;
        public string price;
        public string description;
        public string type;


        public Product(Image image, string? name, string? price, string description, string type)
        {
            this.image = image;
            this.name = name;
            this.price = price;
            this.description = description;
            this.type = type;
        }

    }
}
