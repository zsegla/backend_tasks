public class Program
{
    static void Main(string[] args)
    {
        Library library = new Library("My Library", "123 Main Street");

        
        Book book1 = new Book("The Alchemist", "Paulo Coelho", "ISBN1", 2020);
        Book book2 = new Book("Tell Me Your Dreams", "Sidney Sheldon", "ISBN2", 2015);
        Book book3 = new Book("Miteralion", "Dr. Alemayehu Wase", "ISBN2", 2014);
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        
        MediaItem mediaItem1 = new MediaItem("DVD 1", "DVD", 120);
        MediaItem mediaItem2 = new MediaItem("CD 1", "CD", 60);
        library.AddMediaItem(mediaItem1);
        library.AddMediaItem(mediaItem2);

        library.PrintCatalog();
    }
}