
using System.ComponentModel.DataAnnotations;
public class Car
{
    public string? Nome { get; set; }

    public string? Marca {get;set;}

    public decimal? VelMax { get; set; }

    public decimal? Preco  { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"{Nome}, {Marca}, {VelMax}, {Preco}";
    }
}
