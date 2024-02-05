using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Borrower
{
    // Unik identifierare
    public int Id { get; set; }

    // Egenskap för namn
    [Display(Name = "Namn")]
    [Required(ErrorMessage = "Ange låntagarens namn!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "Namn måste anges med 2-30 tecken!")]
    public required string Name { get; set; }

    // Navigationsegenskap som representerar en lista av lån
    // Används för att etablera relationen mellan boken och lånen
    public List<Loan>? Loans { get; set; }
}