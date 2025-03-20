using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Models;

public class Book
{
    [Key]
    public string BoookId { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public int AuthorId { get; set; }
    [ForeignKey("AuthorId")]
    public Author Author { get; set; }


    public int PublisherId { get; set; }
    [ForeignKey("PublisherId")]
    public Publisher publisher{ get; set; }


}
