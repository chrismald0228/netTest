using OfficeOpenXml;


class Program
{
    public static void PrintData(string[] data) {
        foreach (string lin in data)
        {
            Console.WriteLine(lin);
        }
    }
    public static void Main(String[] args)
    {
        ExcelPackage.License.SetNonCommercialPersonal("Chris");


        Console.WriteLine("Reading");
        var read = new Read();
        string[] data = read.ReadExcel(@"C:\Users\cmaldonado\OneDrive - CTL Global Solutions\Documents\FileTest\ReadTest.xlsx");
        PrintData(data);
        Console.WriteLine("Finished Reading");


        Console.WriteLine("Start Writing");
        Text2File t2f = new Text2File();
        t2f.CreateFile(data);
        Console.WriteLine("FInished");
    }
}