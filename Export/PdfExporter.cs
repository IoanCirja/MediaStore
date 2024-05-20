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
        public void Export(List<Product> products, string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(4);
            table.AddCell("Name");
            table.AddCell("Price");
            table.AddCell("Description");
            table.AddCell("Type");

            foreach (var product in products)
            {
                table.AddCell(product.name);
                table.AddCell(product.price);
                table.AddCell(product.description);
                table.AddCell(product.type);
            }

            document.Add(table);
            document.Close();
        }
    }
}
