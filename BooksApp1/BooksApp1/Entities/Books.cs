namespace BooksApp1.Entities;

public class Books{
    public string? Name{get;set;}
    public string? AuthorName{get;set;}
    public int Price{get;set;}
    public string? Genere{get;set;}

    public Books()
    {
        Console.WriteLine("In Default Constructor of books Entities");
    }
    // public Books(string Name,string AuthorName,int Price,string Genere)
    // {
    //     this.Name=Name;
    //     this.AuthorName=AuthorName;
    //     this.Price=Price;
    //     this.Genere=Genere;
    // }

}