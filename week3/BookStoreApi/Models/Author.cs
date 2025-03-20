using System;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();

}
