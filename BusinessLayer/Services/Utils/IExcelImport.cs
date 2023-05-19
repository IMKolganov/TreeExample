using System.Data;

namespace BusinessLayer.Services.Utils;

public interface IExcelImport
{
    DataTable ReadExcelFile(Stream excelFile, bool readFirstRowColumns = true, string readRange = "1:1");
}