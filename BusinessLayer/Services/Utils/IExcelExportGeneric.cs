using System.Data;

namespace BusinessLayer.Services.Utils;

public interface IExcelExportGeneric
{
    DataTable CreateDataTable<T>(IEnumerable<T> entities);
}