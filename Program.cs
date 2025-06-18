using OfficeOpenXml;


class Program
{
    public static void Main(String[] args)
    {
        ExcelPackage.License.SetNonCommercialPersonal("Chris");
        Console.WriteLine("Reading");
        var read = new Read();
        read.ReadExcel(@"C:\Users\chris\Documents\ReadTest.xlsx");
        Console.WriteLine("Finished Reading");

        Console.WriteLine("Start Writing");
    }
}