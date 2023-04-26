using liskovSubstitution.reader.abstracts;

namespace liskovSubstitution.reader.concretes;

public class XmlReader : IReader
{
    public string Read(string filePath)
    {
        string content = "";
        try
        {
            content = string.Join("\n", File.ReadAllLines(filePath));
        }
        catch (IOException e)
        {
            Console.WriteLine($"Hata oluştu: {e.Message}");
        }

        return content;
    }
}
