using System.ComponentModel.DataAnnotations;
public class Pizza
{
    public int Id {get;set;}
    [StringLenght(20)]
    public string Name {get;set;}
    public bool IsGluetenFree {get;set;}
    public override string ToString()
    {
        return base.ToString() + $"{Id}, {Name}, {IsGlutenFree}";
    }

}