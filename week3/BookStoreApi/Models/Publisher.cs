using System;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models;

public class Publisher
{
    [Key]
    public int PublisherId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();

}
