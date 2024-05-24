/***************************************************************************
 *                                                                         *
 *  Fisier:      ExcelExporterTests.cs                                     *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:    Acest fișier conține teste unitare pentru clasa           *
 *               ExcelExporter, verificând modul în care exportă date în   *
 *               fișiere Excel în cazul în care lista de produse este      *
 *               goală sau conține date valide.                            *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/


using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using ClosedXML.Excel;
using MediaStore;
using ExportLibrary;
using System.Drawing;

namespace MediaStore
{
    [TestFixture]
    public class ExcelExporterTests
    {
        #region Fields
        /// <summary>
        /// Exportatorul de fișiere Excel utilizat.
        /// </summary>
        private ExcelExporter _excelExporter;
        /// <summary>
        /// Calea către fișierul de lucru sau spre locația fișierului de export.
        /// </summary>
        private string _filePath;
        #endregion

        #region Methods
        /// <summary>
        /// Inițializează resursele necesare pentru testare înainte de fiecare test.
        /// Creează o instanță nouă a clasei ExcelExporter și stabilește calea către fișierul de export temporar.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _excelExporter = new ExcelExporter();
            _filePath = Path.Combine(Path.GetTempPath(), "ProductsExport.xlsx");
        }
        /// <summary>
        /// Eliberează resursele utilizate pentru testare după fiecare test.
        /// Verifică dacă fișierul de export temporar există și, în caz afirmativ, îl șterge.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }
        #endregion

        #region Tests
        /// <summary>
        /// Testează funcția de export din Excel când lista de produse este goală.
        /// Se exportă lista de produse în fișierul specificat și se verifică apoi conținutul acestuia.
        /// </summary>
        /// <returns>True dacă exportarea a reușit.</returns>
        [Test]
        public void Export_WithEmptyProductList_Test()
        {
            var products = new List<Product>();

            _excelExporter.Export(products, _filePath);

            Assert.IsTrue(File.Exists(_filePath), "Excel file should be created.");

            using (var workbook = new XLWorkbook(_filePath))
            {
                var worksheet = workbook.Worksheet("Products");
                Assert.AreEqual("Name", worksheet.Cell(1, 1).Value.ToString());
                Assert.AreEqual("Price", worksheet.Cell(1, 2).Value.ToString());
                Assert.AreEqual("Description", worksheet.Cell(1, 3).Value.ToString());
                Assert.AreEqual("Type", worksheet.Cell(1, 4).Value.ToString());

                Assert.IsTrue(worksheet.Row(2).IsEmpty(), "No data rows should be present.");
            }
        }
        #endregion

    }
}
