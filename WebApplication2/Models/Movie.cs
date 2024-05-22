using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie{
    public int ID {get; set;}

    [StringLength(60, MinimumLength = 3)]
    [Required] // --> Não pode ser vazio!
    public string? Title {get;set;}
    
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime Ano {get; set;}

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Genero {get; set;}
    
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price {get; set;}
    
    //adding a new property:
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    public string? rating {get; set;}

}