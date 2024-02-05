using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Author
{
    // Unik identifierare
    public int Id { get; set; }

    // Egenskap för namn
    [Display(Name = "Namn")]
    [Required(ErrorMessage = "Ange författarens namn!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "Namn måste anges med 2-30 tecken!")]
    public required string Name { get; set; }

    // Navigationsegenskap som representerar en lista av böcker
    // Används för att etablera relationen mellan författaren och böckerna
    public List<Book>? Books { get; set; }
}