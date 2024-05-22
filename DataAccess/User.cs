/**************************************************************************
 *                                                                        *
 *  Fisier:      User.cs                                                  *
 *               Functionalitate adaugata de Cîrja Ioan                   *
 *                                           Mihălucă Mădălina-Maria      *
 *                                           Popa Andrei                  *
 *                                           Sandu Delia-Andreea          *
 *  Descriere:   Acest fișier conține clasa User care reprezintă un       *
 *               utilizator din aplicația MediaStore. Clasa include       *
 *               câmpuri private pentru ID, nume de familie, prenume,     *
 *               email, număr de telefon și parolă, precum și proprietăți *
 *               publice pentru a accesa aceste câmpuri și un constructor *
 *               pentru a inițializa un utilizator cu ID, email și parolă.*
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
    public class User
    {
        #region Fields

        /// <summary>
        /// ID-ul utilizatorului
        /// </summary>
        private int _id;

        /// <summary>
        /// Numele de familie al utilizatorului
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Prenumele utilizatorului
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Adresa de email a utilizatorului
        /// </summary>
        private string _email;

        /// <summary>
        /// Numărul de telefon al utilizatorului
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Parola utilizatorului
        /// </summary>
        private string _password;

        #endregion

        #region Getters

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

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor pentru clasa User.
        /// </summary>
        /// <param name="Id">ID-ul utilizatorului.</param>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola utilizatorului.</param>
        public User(int Id, string email, string password)
        {
            _id = Id;
            _email = email;
            _password = password;
        }

        #endregion
    }
}
