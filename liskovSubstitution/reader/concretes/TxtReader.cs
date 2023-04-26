using System;

namespace liskovSubstitution.reader.abstracts;

public class TxtReader : IReader
{
    public string Read(string filePath)
    {
        string[] lines = null;
        try
        {
            lines = File.ReadAllLines(filePath);
        }
        catch (IOException e)
        {
            Console.WriteLine($"Hata oluştu: {e.Message}");
        }

        return string.Join("\n", lines);
    }
}
