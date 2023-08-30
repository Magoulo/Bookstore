using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
//namespace Books.Models;

public class Books 
{
    [Key]
    public int BookId {get; set;}
    public string Name {get; set;}
    public string Author {get; set;}
    public int Pages {get; set;}
    public string ReleaseYear {get; set;}

    public Books()
    {

    }
}