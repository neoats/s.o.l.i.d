using liskovSubstitution.reader.abstracts;

namespace liskovSubstitution.reader;

class Client
{
    public void ReadFiles(IReader reader, string filePath) 
    {
        Console.WriteLine(reader.Read(filePath));
    }
}