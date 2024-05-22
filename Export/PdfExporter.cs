/***************************************************************************
 *                                                                         *
 *  Fisier:      PdfExporter.cs                                            *
 *               Funcționalitate adăugată de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține clasa PdfExporter care implementează  *
 *              interfața IExporter și furnizează funcționalitatea pentru  *
 *              exportul unei liste de produse în format PDF.              *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/

using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Bibliography;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MediaStore;

namespace ExportLibrary
{
    public class PdfExporter : IExporter
    {
        #region Methods

        /// <summary>
        /// Metodă care exportă o listă de produse într-un fișier PDF specificat.
        /// </summary>
        /// <param name="products">Lista de produse de exportat.</param>
        /// <param name="filePath">Calea fișierului PDF în care să fie exportate produsele.</param>
        public void Export(List<Product> products, string filePath)
        {
            // Crează un document PDF
            Document document = new Document();

            // Inițializează un nou flux de fișier pentru documentul PDF
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Deschide documentul PDF

            document.Open();

            // Creează o tabelă PDF cu 4 coloane
            PdfPTable table = new PdfPTable(4);
            // Adaugă antetele coloanelor în tabel
            table.AddCell("Name");
            table.AddCell("Price");
            table.AddCell("Description");
            table.AddCell("Type");

            // Adaugă fiecare produs în tabel
            foreach (var product in products)
            {
                table.AddCell(product.name);
                table.AddCell(product.price);
                table.AddCell(product.description);
                table.AddCell(product.type);
            }

            // Adaugă tabela în documentul PDF
            document.Add(table);
            // Închide documentul PDF
            document.Close();
        }

        #endregion
    }
}
