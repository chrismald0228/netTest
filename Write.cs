// See https://aka.ms/new-console-template for more information
// Console.WriteLine("333");

using System;
using System.IO;

using OfficeOpenXml;
using OfficeOpenXml.Style;


//This is a test to write into an excel file
class Write
{
    void WriteExcel()
    {
        var Articles = new[] {
            new {
                Id = "1", Name = "A"
            },
            new {
                Id = "2", Name = "B"
            },
            new {
                Id = "3", Name = "C"
            }
        };

        var filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "WriteTest.xlsx"
        );
        var fileInfo = new FileInfo(filePath);

        using (ExcelPackage e = new ExcelPackage(fileInfo))
        {
            var worksheet = e.Workbook.Worksheets.Add("Test3");

            worksheet.Cells[1, 1].Value = "Loc";
            worksheet.Cells[1, 2].Value = "ID";
            worksheet.Cells[1, 3].Value = "value";

            int start_col = 2;

            foreach (var art in Articles)
            {
                worksheet.Cells[start_col, 1].Value = (start_col - 1).ToString();
                worksheet.Cells[start_col, 2].Value = art.Id;
                worksheet.Cells[start_col, 3].Value = art.Name;
                start_col++;
            }

            worksheet.Column(1).AutoFit();
            worksheet.Column(2).AutoFit();
            worksheet.Column(3).AutoFit();

            e.Save();

        }

    }

}

