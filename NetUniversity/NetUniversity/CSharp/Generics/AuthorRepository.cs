namespace NetUniversity.CSharp.Generics;

public class AuthorRepository : IRepository<Author>
{
    public IEnumerable<Author> List()
    {
        Author[] authors = new Author[7];

        authors[0] = new Author("Daniel", "Cueto");
        authors[1] = new Author("Javier", "Sataolalla");
        authors[2] = new Author("Maria", "Serrano");
        authors[3] = new Author("Fernando", "");
        authors[4] = new Author("Xenia", "Cueto");
        authors[5] = new Author("Yoel", "Matamoros");
        authors[6] = new Author("Aitor", "Santafé");

        return authors;
    }
}
