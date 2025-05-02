
namespace NetUniversity.CSharp.CollectionsAndLists;

public static class Dictionaries
{
    public static void RunDictionaries()
    {
        // Create Dictionary
        Dictionary<string, string> fileFormats = new Dictionary<string, string>();

        // Add values
        fileFormats.Add(".doc", "Word Document");
        fileFormats.Add(".txt", "Note block");
        fileFormats.Add(".html", "Hypertext Markup Language");
        fileFormats.Add(".jpg", "File image");

        // Trying to insert an element with an existing key
        if ( fileFormats.TryAdd(".doc", "Word doc 2") ) 
        {
            fileFormats.Add(".doc", "Word doc 2");
        }
        else
        {
            Console.WriteLine("An element couldn't be inserted as the key already exists");
        }

        foreach (KeyValuePair<string, string> format in fileFormats)
            Console.WriteLine($"Print element: {format.Key} - {format.Value}");

        // Access to a dictionary element
        var htmlValue = fileFormats[".html"];
        Console.WriteLine($"The value of .html is: {htmlValue}");

        // Update dictionary element value
        fileFormats[".txt"] = "Text file";

        foreach (KeyValuePair<string, string> format in fileFormats)
            Console.WriteLine($"Print element: {format.Key} - {format.Value}");

        // Search element by key or value
        Console.WriteLine($"Searching an element with a key '.jpg': {fileFormats.ContainsKey(".jpg")}");
        Console.WriteLine($"Searching en element with a value 'Text file': {fileFormats.ContainsValue("Text file")}");

        // Remove an element
        fileFormats.Remove(".jpg");
        Console.WriteLine($"The element '.jpg' has been deleted");

        foreach (KeyValuePair<string, string> format in fileFormats)
            Console.WriteLine($"Print element: {format.Key} - {format.Value}");
    }
}