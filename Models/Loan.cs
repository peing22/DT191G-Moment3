using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Loan
{
    public int Id { get; set; }

    [Display(Name = "Bok")]
    public int BookId { get; set; }

    [Display(Name = "Bok")]
    public Book? Book { get; set; }

    [Display(Name = "Låntagare")]
    public int BorrowerId { get; set; }

    [Display(Name = "Låntagare")]
    public Borrower? Borrower { get; set; }

    [Display(Name = "Datum")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Ange datum!")]
    public DateTime Date { get; set; }
}