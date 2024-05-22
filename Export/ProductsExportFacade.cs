/***************************************************************************
 *                                                                         *
 *  Fisier:      DataAccess.cs                                             *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține clasa DataAccess care gestionează     *
 *              interacțiunea cu bazele de date SQLite pentru aplicația    *
 *              MediaStore. Clasa oferă funcționalități pentru obținerea   *
 *              utilizatorilor, autentificare, înregistrare și gestionarea *
 *              favoritelor utilizatorilor.                                *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/

using System.Collections.Generic;
using DocumentFormat.OpenXml.Bibliography;
using MediaStore;

namespace ExportLibrary
{
    public class ProductExportFacade
    {
        #region Fields

        /// <summary>
        /// Exportator pentru formatul Excel.
        /// </summary>
        private readonly IExporter excelExporter;

        /// <summary>
        /// Exportator pentru formatul PDF.
        /// </summary>
        private readonly IExporter pdfExporter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructorul clasei ProductExportFacade.
        /// </summary>
        /// <param name="excelExporter">Instanța exportatorului pentru formatul Excel.</param>
        /// <param name="pdfExporter">Instanța exportatorului pentru formatul PDF.</param>
        public ProductExportFacade(IExporter excelExporter, IExporter pdfExporter)
        {
            this.excelExporter = excelExporter;
            this.pdfExporter = pdfExporter;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metodă care exportă lista de produse într-un fișier Excel.
        /// </summary>
        /// <param name="products">Lista de produse de exportat.</param>
        /// <param name="filePath">Calea fișierului Excel de generat.</param>
        public void ExportToExcel(List<Product> products, string filePath)
        {
            excelExporter.Export(products, filePath);
        }

        /// <summary>
        /// Metodă care exportă lista de produse într-un fișier PDF.
        /// </summary>
        /// <param name="products">Lista de produse de exportat.</param>
        /// <param name="filePath">Calea fișierului PDF de generat.</param>
        public void ExportToPdf(List<Product> products, string filePath)
        {
            pdfExporter.Export(products, filePath);
        }
        
        #endregion
    }
}
