using System;
using System.Collections.Generic;

public class Library
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