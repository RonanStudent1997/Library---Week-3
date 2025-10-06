using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3___Library
{
    class Book
    {
        private string title; //variable
        private string author; //variable
        private string isbn; //variable

        //title property allows acces to the private title variable
        public string Title
        {
            get { return title; } //get method
            set { title = value; } //set method
        }
        public string Author
        {
            get { return author; } //get method
            set { author = value; } //set method
        }
        public string ISBN
        {
            get { return isbn; } //get method
            set { isbn = value; } //set method
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

    }
}
