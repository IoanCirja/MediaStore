using System.Collections.Generic;
using MediaStore;

namespace ExportLibrary
{
    public interface IExporter
    {
        void Export(List<Product> products, string filePath);
    }
}
