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
        private PdfExporter _pdfExporter;
        private string _filePath;

        [SetUp]
        public void Setup()
        {
            _pdfExporter = new PdfExporter();
            _filePath = Path.Combine(Path.GetTempPath(), "ProductsExport.pdf");
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }

        
        [Test]
        public void Export_WithEmptyProductList_Test()
        {
            var products = new List<Product>();

            _pdfExporter.Export(products, _filePath);

            Assert.IsTrue(File.Exists(_filePath), "PDF file should be created.");
            Assert.IsTrue(VerifyPdfContent(_filePath, products));
        }


        private bool VerifyPdfContent(string filePath, List<Product> expectedProducts)
        {
            using (var reader = new PdfReader(filePath))
            {
                var text = new StringBuilder();
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                var content = text.ToString();
                if (!content.Contains("Name") || !content.Contains("Price") || !content.Contains("Description") || !content.Contains("Type"))
                {
                    return false;
                }

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
    }
}
