
namespace NetUniversity.CSharp.CollectionsAndLists;

public static class Lists
{
    public static void RunLists()
    {
        // array => Limited definied size and not modifiable. Not for managing data in our app/software. Just for communicating with other platforms to manage a generic data structure
        string[] arrayPersons = { "Juan", "David", "Iker", "Jaime", "Don Juan Manuel de Lezo" };
        
        // List Collection => Not limited size and modifible. Great for managing data in our software.
        // Creation
        List<string> listPersons = new List<string>();

        // Add data to List from array string[]
        listPersons.AddRange(arrayPersons);

        // Add an element to List
        listPersons.Add("Carla");
        listPersons.Add("Sofia");

        // Count elements in List
        Console.WriteLine($"The List has this quantity of elements: {listPersons.Count}");
        PrintList(listPersons);
        
        // Get an element list
        Console.WriteLine($"Prints first element of the list: {listPersons[0]}");

        // Removes an element list
        listPersons.RemoveAt(3);
        listPersons.Remove("Iker");
        PrintList(listPersons);

        // Sorted alphabetically
        Console.WriteLine("Sorted alphabetically");
        listPersons.Sort();
        PrintList(listPersons);

        // Checks if an element exists in a list
        Console.WriteLine($"¿Carla exists in the List? Answer: {listPersons.Contains("Carla")}");

        // Checks if exists an element with more than 10 characters
        var existsMoreThan10 = listPersons.Exists(p => p.Length > 10);
        Console.WriteLine($"¿Do exists a name with more than 10 characters? Answer: {existsMoreThan10}");

        // Search a name which starts with letter D
        var elementStartsWithD = listPersons.Find(p => p.StartsWith("D"));
        Console.WriteLine($"The name which starts with letter D is {elementStartsWithD}");
    }

    public static void PrintList(List<string> strings)
    {
        foreach(string s in strings) Console.WriteLine(s);
    }

    public static void RunLinkedLists()
    {
        string[] songs = {
            "Imagine",
            "One",
            "Billie Jean",
            "Hey Jude",
            "God Save The Queen",
            "Born to Run",
            "Creep",
            "My name is",
            "Yesterday",
            "My Generation",
            "Respect"
        };

        // Init LinkedList with data passed as an argument
        LinkedList<string> songsLinkedList = new LinkedList<string>(songs);

        // Inserting one element at the beggining and at end of the LinkedList
        songsLinkedList.AddFirst("My first song");
        songsLinkedList.AddLast("My last song");

        foreach(string song in songsLinkedList) Console.WriteLine(song);

        // Getting first and last element in a LinkedList
        LinkedListNode<string> firstSong = songsLinkedList.First!;
        LinkedListNode<string> lastSong = songsLinkedList.Last!;

        Console.WriteLine($"First song: {firstSong.Value} \nLast song: {lastSong.Value}");

        // Inserting a new element after an existing element
        songsLinkedList.AddAfter(firstSong, "My second song");
        foreach (string song in songsLinkedList) Console.WriteLine(song);

        // Checking if element exists with .Contains()
        Console.WriteLine($"Looking for the song Imagine: {songsLinkedList.Contains("Imagine")}");

        // Accessing data using next and previous methods
        Console.WriteLine($"Next song that continues from the first one is: {firstSong.Next?.Value}");
        Console.WriteLine($"Previous song that goes before from the last one is: {lastSong.Previous?.Value}");
    }

    public static void RunStacks()
    {
        // Stack Collection
        Stack<string> stack = new Stack<string>();

        // Insert elements in Stack
        stack.Push("one");
        stack.Push("two");
        stack.Push("three");
        stack.Push("four");
        stack.Push("five");
        stack.Push("six");

        foreach(string el in stack) Console.WriteLine(el);

        // Get first element
        string topEl = stack.Peek();
        Console.WriteLine($"This is the first element: {topEl}");

        // Remove an element at top
        string elementRemoved = stack.Pop();
        Console.WriteLine($"This element has been deleted: {elementRemoved}");
        foreach (string el in stack) Console.WriteLine(el);

        // Search element with method .Contains
        Console.WriteLine($"Do the 'three' element exists? Answer: {stack.Contains("three")}");
    }

    public static void RunQueues()
    {
        // Queue Collection
        Queue<string> myQueue = new Queue<string>();

        // Add elements
        myQueue.Enqueue("one");
        myQueue.Enqueue("two");
        myQueue.Enqueue("three");
        myQueue.Enqueue("four");
        myQueue.Enqueue("five");
        myQueue.Enqueue("six");

        foreach(string el in myQueue) Console.WriteLine(el);

        // Look for the first element of the queue
        var firstElement = myQueue.Peek();
        Console.WriteLine($"First element is: {firstElement}");

        // Remove the first element from a queue
        string elementRemoved = myQueue.Dequeue();
        Console.WriteLine($"The element: {elementRemoved}, has been removed");
        foreach (string el in myQueue) Console.WriteLine(el);

        // Search if an element exists
        Console.WriteLine($"Do the 'four' element exists? Answer: {myQueue.Contains("four")}");
    }
}
