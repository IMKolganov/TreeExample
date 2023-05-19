using System.Data;

namespace BusinessLayer.Services.Utils;

public class ExcelExportGeneric : IExcelExportGeneric
{
    public DataTable CreateDataTable<T>(IEnumerable<T> entities)
    {
        var dt = new DataTable();
        dt.TableName = "Objects";

        //creating columns
        foreach (var prop in typeof(T).GetProperties())
        {
            dt.Columns.Add(prop.Name, prop.PropertyType);
        }

        //creating rows
        foreach (var entity in entities)
        {
            var values = GetObjectValues(entity);
            dt.Rows.Add(values);
        }
        return dt;
    }

    private object[] GetObjectValues<T>(T entity)
    {
        var values = new List<object>();
        foreach (var prop in typeof(T).GetProperties())
        {
            values.Add(prop.GetValue(entity));
        }

        return values.ToArray();
    }
}