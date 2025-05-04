namespace NetUniversity.CSharp.Generics;

public class AuthorPrinterService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorPrinterService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void PrintAuthors()
    {
        Author[] authors = _authorRepository.List();
        Array.Sort(authors);

        Console.WriteLine($"\nPrinting Author List from method {nameof(PrintAuthors)}\n");

        for (int i = 0; i < authors.Length; i++)
        {
            Console.WriteLine(authors[i]);
        }
    }
}
