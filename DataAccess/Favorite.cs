/**************************************************************************
 *                                                                        *
 *  Fisier:      Favorite.cs                                              *
 *               Functionalitate adaugata de Cîrja Ioan                   *
 *                                           Mihălucă Mădălina-Maria      *
 *                                           Popa Andrei                  *
 *                                           Sandu Delia-Andreea          * 
 *  Descriere:   Acest fișier conține clasa Favorite care reprezintă      *
 *               un element favorit din aplicația MediaStore.             *
 *               Clasa include câmpuri pentru nume, preț, descriere și    *
 *               utilizator, precum și un constructor pentru a inițializa *
 *               aceste câmpuri.                                          *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public class Favorite
    {
        #region Fields

        /// <summary>
        /// Numele elementului favorit
        /// </summary>
        public string name;

        /// <summary>
        /// Prețul elementului favorit
        /// </summary>
        public string price;

        /// <summary>
        /// Descrierea elementului favorit
        /// </summary>
        public string description;

        /// <summary>
        /// Utilizatorul care a adăugat elementul favorit
        /// </summary>
        public string user;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor pentru clasa Favorite.
        /// </summary>
        /// <param name="name">Numele elementului favorit.</param>
        /// <param name="price">Prețul elementului favorit.</param>
        /// <param name="description">Descrierea elementului favorit.</param>
        /// <param name="user">Utilizatorul care a adăugat elementul favorit.</param>
        public Favorite(string name, string price, string description, string user)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.user = user;
        }

        #endregion
    }
}

