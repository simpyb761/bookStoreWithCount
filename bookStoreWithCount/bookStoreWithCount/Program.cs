using System;
using static System.Console;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book bookOne = new book();
            bookOne.SetID(10);
            bookOne.SetTitle("Ruination");
            bookOne.SetAuthor("James");
            bookOne.SetTrans();

            book bookTwo = new book();
            WriteLine("Please enter the book ID: ");
            bookTwo.SetID(int.Parse(ReadLine()));
            WriteLine("Please enter the books Title: ");
            bookTwo.SetTitle(ReadLine());
            WriteLine("Please enter the books Author: ");
            bookTwo.SetAuthor(ReadLine());
            bookTwo.SetTrans();

            book bookThree = new book(30, "Fairy Tale", "Steven King");
            bookThree.SetTrans();

            WriteLine("Please enter the book ID: ");
            int id = int.Parse(ReadLine());
            WriteLine("Please enter the books Title: ");
            string title = ReadLine();
            WriteLine("Please enter the books Author: ");
            string author = ReadLine();
            book bookFour = new book(id, title, author);
            bookFour.SetTrans();

            WriteLine($"The book store has {bookOne.GetTrans()} books!");
            displayBooks(bookOne);
            displayBooks(bookTwo);
            displayBooks(bookThree);
            displayBooks(bookFour);
        }

        static void displayBooks(book bookNumber)
        {
            WriteLine("Here is your books information!");
            WriteLine($"Book ID: {bookNumber.GetID}");
            WriteLine($"Book Title: {bookNumber.Title}");
            WriteLine($"Book Author: {bookNumber.Author}");
        }


    }
}
class book
{
    private int _Id;
    private string _Title;
    private string _Author;
    private static int _transactions = 0;

    public book()
    {
        _Id = 0;
        _Title = "";
        _Author = "";
    }

    public book(int id, string title, string author)
    {
        _Id = id;
        _Title = title;
        _Author = author;
    }

    public int GetID { get { return _Id; } }
    public void SetID(int id) { _Id = id; }
    public string Title { get { return _Title; } }
    public void SetTitle(string title) { _Title = title; }
    public string Author { get { return _Author; } }
    public void SetAuthor(string author) { _Author = author; }

    public void SetTrans() { _transactions++; }
    public int GetTrans() { return _transactions;}

}