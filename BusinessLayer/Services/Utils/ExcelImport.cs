using System.Data;
using ClosedXML.Excel;

namespace BusinessLayer.Services.Utils;

public class ExcelImport : IExcelImport
{
    public DataTable ReadExcelFile(Stream excelFile, bool readFirstRowColumns = true, string readRange = "1:1")
    {
        var dt = new DataTable();
        using (var workbook = new XLWorkbook(excelFile))
        {
            var worksheet = workbook.Worksheet(1);
            foreach (var row in worksheet.RowsUsed())
            {
                if (readFirstRowColumns)
                {
                    ReadExcelColumns(dt, row, readRange);
                    readFirstRowColumns = false;
                }
                else
                {
                    ReadExcelRow(dt, row, readRange);
                }
            }
        }

        return dt;
    }

    private void ReadExcelColumns(DataTable dt, IXLRow row, string readRange)
    {
        //Checking the Last cellused for column generation in datatable  
        readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
        foreach (var cell in row.Cells(readRange)) {
            dt.Columns.Add(cell.Value.ToString());
        }
    }

    private void ReadExcelRow(DataTable dt, IXLRow row, string readRange) {
        //Adding a Row in datatable
        dt.Rows.Add();
        int cellIndex = 0;
        //Updating the values of datatable
        foreach (var cell in row.Cells(readRange))
        {
            dt.Rows[dt.Rows.Count - 1][cellIndex] = cell.Value.ToString();
            cellIndex++;
        }
    }
}