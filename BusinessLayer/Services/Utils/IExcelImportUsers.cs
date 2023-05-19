using System.Data;

namespace BusinessLayer.Services.Utils;

public interface IExcelImportUsers
{
    Task<DataTable> ImportUsersFromExcel(Stream excelFile);
}