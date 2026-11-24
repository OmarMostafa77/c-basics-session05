using System;

enum Genre
{
    Fiction,

    NonFiction,

    Science
}

class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;

    public Genre Genre;
}

class Program
{
    static void Main()
    {
        Book book = new Book();

        /*===Q1=== Console.WriteLine(book.password); == can't access password
        as it is private inside book class*/

        //===Q2=== can access it as it's internal within the whole project
        Console.WriteLine(book.copiesInStock);

        //===Q3===
        book.Title = "Special One";
        Console.WriteLine(book.Title);

        //====Q4====
        book.Genre = Genre.Science;
        Console.WriteLine(book.Genre);

        //====Q5====
        Console.WriteLine((int) Genre.Fiction);
        Console.WriteLine((int) Genre.NonFiction);
        Console.WriteLine((int) Genre.Science);

        //====Q6====
        int genreNumber = 1;
        Genre g = (Genre) genreNumber;
        Console.WriteLine(g);

        //====Q7====
        Genre genre = Genre.Fiction;
        string text = genre.ToString();
        Console.WriteLine(text);

        //====q8===
        string genreText = "Science";
        Genre parsed = (Genre)Enum.Parse(typeof(Genre), genreText);
        Console.WriteLine(parsed);

        //====Q9====
        string genreText2 = "Mystery";
        if (Enum.TryParse(genreText2, out Genre result))

            Console.WriteLine(result);
        else
            Console.WriteLine("Unknown genre");


    }
}