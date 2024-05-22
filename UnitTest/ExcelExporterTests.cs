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
        private ExcelExporter _excelExporter;
        private string _filePath;

        [SetUp]
        public void Setup()
        {
            _excelExporter = new ExcelExporter();
            _filePath = Path.Combine(Path.GetTempPath(), "ProductsExport.xlsx");
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

        
    }
}
