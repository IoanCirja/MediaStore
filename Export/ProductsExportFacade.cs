using System.Collections.Generic;
using DocumentFormat.OpenXml.Bibliography;
using MediaStore;

namespace ExportLibrary
{
    public class ProductExportFacade
    {
        private readonly IExporter excelExporter;
        private readonly IExporter pdfExporter;

        public ProductExportFacade(IExporter excelExporter, IExporter pdfExporter)
        {
            this.excelExporter = excelExporter;
            this.pdfExporter = pdfExporter;
        }

        public void ExportToExcel(List<Product> products, string filePath)
        {
            excelExporter.Export(products, filePath);
        }

        public void ExportToPdf(List<Product> products, string filePath)
        {
            pdfExporter.Export(products, filePath);
        }
    }
}
