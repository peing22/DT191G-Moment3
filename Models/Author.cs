using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Author
{
    public int Id { get; set; }

    [Display(Name = "Namn")]
    [Required(ErrorMessage = "Ange författarens namn!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "Namn måste anges med 2-30 tecken!")]
    public required string Name { get; set; }

    public List<Book>? Books { get; set; }
}