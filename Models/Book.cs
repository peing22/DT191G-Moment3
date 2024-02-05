using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Book
{
    // Unik identifierare
    public int Id { get; set; }

    // Egenskap för titel
    [Display(Name = "Titel")]
    [Required(ErrorMessage = "Ange bokens titel!")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Titel måste anges med 2-50 tecken!")]
    public required string Title { get; set; }

    // Främmandenyckel för att hålla reda på vilken författare boken tillhör
    [Display(Name = "Författare")]
    public int AuthorId { get; set; }

    // Navigationsegenskap
    [Display(Name = "Författare")]
    public Author? Author { get; set; }

    // Navigationsegenskap
    public List<Loan>? Loans { get; set; }
}