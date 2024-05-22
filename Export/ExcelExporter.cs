/***************************************************************************
 *                                                                         *
 *  Fisier:      ExcelExporter.cs                                          *
 *               Funcționalitate adăugată de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține clasa ExcelExporter care implementează *
 *              interfața IExporter și furnizează funcționalitatea pentru  *
 *              exportul unei liste de produse în format Excel.            *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/

using System.Collections.Generic;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using MediaStore;

namespace ExportLibrary
{
    public class ExcelExporter : IExporter
    {
        #region Methods

        /// <summary>
        /// Metodă care exportă o listă de produse într-un fișier Excel specificat.
        /// </summary>
        /// <param name="products">Lista de produse de exportat.</param>
        /// <param name="filePath">Calea fișierului Excel în care să fie exportate produsele.</param>
        public void Export(List<Product> products, string filePath)
        {
            // Utilizează biblioteca ClosedXML pentru a crea un nou workbook Excel
            using (var workbook = new XLWorkbook())
            {
                // Adaugă un nou worksheet cu numele "Products"
                var worksheet = workbook.Worksheets.Add("Products");
                
                // Adaugă antetele coloanelor în prima rând a worksheet-ului
                worksheet.Cell(1, 1).Value = "Name";
                worksheet.Cell(1, 2).Value = "Price";
                worksheet.Cell(1, 3).Value = "Description";
                worksheet.Cell(1, 4).Value = "Type";

                // Iterează prin fiecare produs și îl adaugă în worksheet
                for (int i = 0; i < products.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = products[i].name;
                    worksheet.Cell(i + 2, 2).Value = products[i].price;
                    worksheet.Cell(i + 2, 3).Value = products[i].description;
                    worksheet.Cell(i + 2, 4).Value = products[i].type;
                }

                // Salvează workbook-ul în fișierul specificat
                workbook.SaveAs(filePath);
            }
        }

        #endregion
    }
}
