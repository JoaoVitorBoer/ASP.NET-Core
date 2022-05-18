using System.ComponentModel.DataAnnotations;
public class Pessoa
{   
    //[Required(AllowEmptyStrings = true)] 
    public string Nome {get;set;} = null!; // ! -> "Nao me enche o saco com o aviso de null"
    [EmailAddress(ErrorMessage = "Deve ser um formato válido")] //Valida os dados de email no formato de email, caso contrario da bad request
    public string? Email {get;set;} // diz que o email nao é obrigatorio
    [Range(0, 150, ErrorMessage = "Deve estar entre {1} e {2}")]
    public int Idade {get;set;}

}