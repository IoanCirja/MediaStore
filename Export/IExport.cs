/***************************************************************************
 *                                                                         *
 *  Fisier:      IExporter.cs                                              *
 *               Funcționalitate adăugată de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține interfața IExporter care definește    *
 *              metoda Export pentru exportarea unei liste de produse în   *
 *             tr-un format specific, utilizat în biblioteca de export.    *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/

using System.Collections.Generic;
using MediaStore;

namespace ExportLibrary
{
    /// <summary>
    /// Interfața IExporter definește metoda Export pentru exportarea unei liste de produse
    /// într-un format specific.
    /// </summary>
    public interface IExporter
    {
        #region Methods

        /// <summary>
        /// Exportă o listă de produse într-un fișier specificat.
        /// </summary>
        /// <param name="products">Lista de produse de exportat.</param>
        /// <param name="filePath">Calea fișierului în care să fie exportate produsele.</param>
        void Export(List<Product> products, string filePath);

        #endregion
    }
}
