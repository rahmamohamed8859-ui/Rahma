namespace EFCore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
    public int Pages { get; set; }
    public int PublishedYear { get; set; }
    public bool IsInStock { get; set; }


    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

   

public class BookStoreContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True"
        );
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookStoreContext())
            {
                context.Database.EnsureCreated();
            }

            Console.WriteLine("Database Created Successfully!");
        }
    }