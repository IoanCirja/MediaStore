using System.Collections.Generic;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using MediaStore;

namespace ExportLibrary
{
    public class ExcelExporter : IExporter
    {
        public void Export(List<Product> products, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Products");
                worksheet.Cell(1, 1).Value = "Name";
                worksheet.Cell(1, 2).Value = "Price";
                worksheet.Cell(1, 3).Value = "Description";
                worksheet.Cell(1, 4).Value = "Type";

                for (int i = 0; i < products.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = products[i].name;
                    worksheet.Cell(i + 2, 2).Value = products[i].price;
                    worksheet.Cell(i + 2, 3).Value = products[i].description;
                    worksheet.Cell(i + 2, 4).Value = products[i].type;
                }

                workbook.SaveAs(filePath);
            }
        }
    }
}
