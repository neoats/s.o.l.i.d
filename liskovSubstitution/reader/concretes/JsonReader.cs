namespace liskovSubstitution.reader.abstracts;

class JsonReader : IReader
{
    public string Read(string filePath)
    {
        string json = "";

        try
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                json = streamReader.ReadToEnd();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        return json;
    }
}