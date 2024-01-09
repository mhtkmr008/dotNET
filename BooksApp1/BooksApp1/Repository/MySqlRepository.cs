using BooksApp1.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using MySql.Data.MySqlClient;

namespace BooksApp1.Repository;

public class MySqlRepository{
    public MySqlRepository()
    {
        Console.WriteLine("In MySqlRepository");
    }

    public List<Books> GetAll(){
        List<Books> bookList=new List<Books>();
        
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=@"server=localhost; port=3306; user=root; password=root123; database=library";
        
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText="select * from library";
        try{
            con.Open();
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                string? name=reader["name"].ToString();
                string? authorName=reader["AuthorName"].ToString();
                int price=int.Parse(reader["price"].ToString());
                string? genere=reader["genre"].ToString();
                Books book=new Books();
                book.Name=name;
                book.AuthorName=authorName;
                book.Price=price;
                book.Genere=genere;
                bookList.Add(book);
            }
        }catch(Exception e){
Console.WriteLine(e.Message);
        }finally{con.Close();}
        return bookList;
    }   
    
    

}