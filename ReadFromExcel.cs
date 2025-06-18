using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using OfficeOpenXml;
using OfficeOpenXml.Packaging;
using OfficeOpenXml.Style;

class Read

{
    public string[] ReadExcel(string filePath)
    {
        var fileInfo = new FileInfo(filePath);
        List<string> data = new List<string>();

        using (var e = new ExcelPackage(fileInfo))
        {
            var worksheet = e.Workbook.Worksheets["Sheet1"];

            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            for (int row = 1; row <= rowCount; row++)
            {
                string loc = worksheet.Cells[row, 1].Text;
                string id = worksheet.Cells[row, 2].Text;
                string val = worksheet.Cells[row, 3].Text;

                // Console.WriteLine($"{loc}\t{id}\t{val}");

                string newLine = $"{loc}\t{id}\t{val}";
                data.Add(newLine);
            }
        }
        string[] finalData = data.ToArray();
        return finalData;
        // Console.WriteLine("Pased");
    }
}