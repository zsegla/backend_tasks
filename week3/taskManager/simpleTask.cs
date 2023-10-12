using System;
using System.Collections.Generic;

class Library
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }
    public List<MediaItem> MediaItems { get; set; }

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
        Console.WriteLine($"Library: {Name} ({Address})");
        Console.WriteLine("Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Year: {book.PublicationYear}");
        }
        Console.WriteLine("Media Items:");
        foreach (var item in MediaItems)
        {
            Console.WriteLine($"Title: {item.Title}, Type: {item.MediaType}, Duration: {item.Duration} minutes");
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
