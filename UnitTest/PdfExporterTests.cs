/***************************************************************************
 *                                                                         *
 *  Fisier:      PdfExporterTests.cs                                       *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:    Acest fișier conține teste unitare pentru clasa           *
 *               PdfExporter, verificând modul în care exportă date în     *
 *               fișiere PDF în cazul în care lista de produse este        *
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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MediaStore;
using ExportLibrary;
using System.Text;
using Path = System.IO.Path;

namespace MediaStore
{
    [TestFixture]
    public class PdfExporterTests
    {
        #region Fields
        /// <summary>
        /// Exportatorul de fișiere PDF utilizat.
        /// </summary>
        private PdfExporter _pdfExporter;
        /// <summary>
        /// Calea către fișierul de lucru sau spre locația fișierului de export.
        /// </summary>
        private string _filePath;
        #endregion

        #region Methods
        /// <summary>
        /// Inițializează resursele necesare pentru testare înainte de fiecare test.
        /// Creează o instanță nouă a clasei PdfExporter și stabilește calea către fișierul de export temporar.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _pdfExporter = new PdfExporter();
            _filePath = Path.Combine(Path.GetTempPath(), "ProductsExport.pdf");
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
        /// <summary>
        /// Verifică conținutul unui fișier PDF în funcție de produsele așteptate.
        /// </summary>
        /// <param name="filePath">Calea către fișierul PDF de verificat.</param>
        /// <param name="expectedProducts">Lista de produse așteptate pentru verificare în conținutul PDF.</param>
        /// <returns>True dacă fișierul PDF conține toate informațiile și produsele așteptate, altfel False.</returns>
        private bool VerifyPdfContent(string filePath, List<Product> expectedProducts)
        {
            // Utilizează un cititor PDF pentru a extrage textul din fișierul specificat
            using (var reader = new PdfReader(filePath))
            {
                var text = new StringBuilder();
                // Iterează prin fiecare pagină a fișierului PDF și adaugă textul extras la StringBuilder
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                // Convertște textul într-o singură variabilă de tip string
                var content = text.ToString();
                if (!content.Contains("Name") || !content.Contains("Price") || !content.Contains("Description") || !content.Contains("Type"))
                {
                    return false;
                }
                // Verifică fiecare produs din lista așteptată în conținutul PDF
                foreach (var product in expectedProducts)
                {
                    if (product.name != null && !content.Contains(product.name)) return false;
                    if (product.price != null && !content.Contains(product.price)) return false;
                    if (product.description != null && !content.Contains(product.description)) return false;
                    if (product.type != null && !content.Contains(product.type)) return false;
                }

                return true;
            }
        }
        #endregion

        #region Tests
        /// <summary>
        /// Testează funcția de export în format PDF atunci când lista de produse este goală.
        /// Exportă lista de produse într-un fișier PDF și verifică dacă acesta este creat corect și conține informațiile așteptate.
        /// </summary>
        /// <returns>True dacă exportarea a reușit.</returns>
        [Test]
        public void Export_WithEmptyProductList_Test()
        {
            var products = new List<Product>();

            _pdfExporter.Export(products, _filePath);

            Assert.IsTrue(File.Exists(_filePath), "PDF file should be created.");
            Assert.IsTrue(VerifyPdfContent(_filePath, products));
        }

        #endregion
    }
}
