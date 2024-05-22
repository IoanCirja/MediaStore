/***************************************************************************
 *                                                                         *
 *  Fisier:      Product.cs                                                *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 *  Descriere:   Acest fișier conține clasa Product care reprezintă        *
 *               un produs din aplicația MediaStore. Clasa include câmpuri *
 *               pentru imagine, nume, preț, descriere și tipul produsului,*
 *               precum și un constructor pentru a inițializa aceste       *
 *               câmpuri.                                                  *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MediaStore
{
    public class Product
    {
        #region Fields

        /// <summary>
        /// Imaginea produsului
        /// </summary>
        public Image image;

        /// <summary>
        /// Numele produsului
        /// </summary>
        public string name;

        /// <summary>
        /// Prețul produsului
        /// </summary>
        public string price;

        /// <summary>
        /// Descrierea produsului
        /// </summary>
        public string description;

        /// <summary>
        /// Tipul produsului
        /// </summary>
        public string type;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor pentru clasa Product.
        /// </summary>
        /// <param name="image">Imaginea produsului.</param>
        /// <param name="name">Numele produsului.</param>
        /// <param name="price">Prețul produsului.</param>
        /// <param name="description">Descrierea produsului.</param>
        /// <param name="type">Tipul produsului.</param>
        public Product(Image image, string? name, string? price, string description, string type)
        {
            this.image = image;
            this.name = name;
            this.price = price;
            this.description = description;
            this.type = type;
        }
        #endregion
    }
}
