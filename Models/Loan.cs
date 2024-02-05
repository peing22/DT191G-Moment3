using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Loan
{
    // Unik identifierare
    public int Id { get; set; }

    // Främmandenyckel för att hålla reda på vilken låntagare lånet tillhör
    [Display(Name = "Låntagare")]
    public int BorrowerId { get; set; }

    // Navigationsegenskap
    [Display(Name = "Låntagare")]
    public Borrower? Borrower { get; set; }

    // Främmandenyckel för att hålla reda på vilken bok lånet gäller
    [Display(Name = "Bok")]
    public int BookId { get; set; }

    // Navigationsegenskap
    [Display(Name = "Bok")]
    public Book? Book { get; set; }

    // Egenskap för datum
    [Display(Name = "Datum")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Ange datum!")]
    public DateTime Date { get; set; }
}