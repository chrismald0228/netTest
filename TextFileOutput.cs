using System.IO;
using Microsoft.Extensions.FileSystemGlobbing;

class Text2File
{
    private string GetFileFolder()
    {
        string path = @"C:\WriteTest";
        return path;
    }

    public void CreateFile(string[] data)
    {
        string ff = GetFileFolder();
        string time = DateTime.Now.ToString();
        string fn = $"Test.txt";
        string fp = Path.Combine(ff, fn);


        foreach (string line in data)
        {
            File.AppendAllText(fp, line+"\n");
        }
    }
}
