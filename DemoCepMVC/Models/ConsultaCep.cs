using System.ComponentModel.DataAnnotattions;
namespace DemoCepMVC.Services;


public class ConsultaCep
{   
    [Required]
    [StringLenght(100)]
    public string Logradouro {get;set;} = null!;
    [Required]
    [StringLenght(30)]
    public string Bairro {get;set;} = null!;

    [Required]
    [StringLenght(50)]
    public string Cidade {get;set;} = null!;

    [Required]
    [RegularExpression(@"^[A-Z]{2}$")]
    public string Estado {get;set;} = null!;

    [Required]
    [RegularExpression(@"^\d{8}$")]
    public string Cep {get;set;} = null!;
}