using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Bookstore.Models;

public class Book 
{
    [Key]
    public int Book_Id {get; set;}
    public string Title {get; set;}
    public string Author {get; set;}
    public int Pages {get; set;}
    public string Release_Year {get; set;}

    public Book()
    {

    }
}