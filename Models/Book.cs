using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Book
{
    public int Id { get; set; }

    [Display(Name = "Titel")]
    [Required(ErrorMessage = "Ange bokens titel!")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Titel måste anges med 2-50 tecken!")]
    public required string Title { get; set; }

    [Display(Name = "Författare")]
    public int AuthorId { get; set; }

    [Display(Name = "Författare")]
    public Author? Author { get; set; }

    public List<Loan>? Loans { get; set; }
}