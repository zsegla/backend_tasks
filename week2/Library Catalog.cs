// This is C# task for week 2 @ a2sv by Fikreselassie Solomon


using System;
using System.Collections.Generic;

class Library
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; }
    public List<MediaItem> MediaItems { get; }

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void AddMediaItem(MediaItem item)
    {
        MediaItems.Add(item);
    }

    public void RemoveMediaItem(MediaItem item)
    {
        MediaItems.Remove(item);
    }

    public void PrintCatalog()
    {
        Console.WriteLine($"Library: {Name}, Address: {Address}\n");

        Console.WriteLine("Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Year: {book.PublicationYear}");
        }

        Console.WriteLine("\nMedia Items:");
        foreach (var item in MediaItems)
        {
            Console.WriteLine($"Title: {item.Title}, Type: {item.MediaType}, Duration (min): {item.Duration}");
        }
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
}

class MediaItem
{
    public string Title { get; set; }
    public string MediaType { get; set; }
    public int Duration { get; set; }

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }
}

class Program
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
