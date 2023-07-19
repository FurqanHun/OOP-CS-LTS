namespace oopA2;

public abstract class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public string publisher { get; set; }
    public int price { get; set; }
    public string datePublished { get; set; }
    public string city{ get; set; }

    public abstract void printDetails();
}

public class ISBN : Book
{
    public string isbn { get; set; }
    public ISBN(string title, string author, string publisher, int price, string datePublished, string city, string isbn)
    {
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.price = price;
        this.datePublished = datePublished;
        this.city = city;
        this.isbn = isbn;
    }
    public void setISBN(string isbn)
    {
        this.isbn = isbn;
    }
    public string getISBN()
    {
        return this.isbn;
    }

    public string getAuthor()
    {
        return this.author;
    }
    public static void setBookTitle(string title)
    {
        title = title;
    }
    public override void printDetails()
    {
        Console.WriteLine("Book Details");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Publisher: " + publisher);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Date Published: " + datePublished);
        Console.WriteLine("City: " + city);
        Console.WriteLine("ISBN: " + isbn);
    }
}