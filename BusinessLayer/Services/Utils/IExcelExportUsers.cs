namespace BusinessLayer.Services.Utils;

public interface IExcelExportUsers
{
    Task<MemoryStream> GetUsersInExcel();
}