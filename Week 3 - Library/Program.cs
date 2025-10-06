
using System;

class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {


        //create a new object of the book class
        Book book = new Book();

        //This is a book within the library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        //creating a 2nd book class

        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";



        book.DisplayInfo();
        book1.DisplayInfo();
    }
}