public static class PizzasService
{
    private static List<Pizza> Pizzas {get;}
    static PizzasService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {Id=1, Name="Napolitana", IsGluetenFree=false},
            new Pizza {Id=2, Name="Veggie", IsGluetenFree=true}
        };
    }
    public static IEnumerable<Pizza> GetAll()
    {
        return Pizzas.OrderBy(p => p.Nome).ToArray();
    }
    public static Pizza? Get(int id)
    {
        return Pizzas.FirstOrDefault( p => p.Id == id);
    }
    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        return PizzasService.Get(id);
    }
}