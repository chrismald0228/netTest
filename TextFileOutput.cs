using System.IO;
using Microsoft.Extensions.FileSystemGlobbing;

class Text2File
{
    private string GetFilePath()
    {
        var path = @"C:\Docs";
        return path;
    }

    public void CreateFile(Read data)
    {
        var fp = GetFilePath();

        if (!File.Exists(fp))
        {
            File.WriteAllText(fp, )
        }
    }
}
