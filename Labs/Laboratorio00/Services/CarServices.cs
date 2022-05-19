
public static class CarServices
{
    private static List<Car> Carros {get;}

    static CarServices()
    {
        Carros = new List<Car>{
            new Car {Nome="Gallardo",Marca="Lamborghini", VelMax=350M, Preco=2100000M},
            new Car {Nome="Gol",Marca="Volkswagen", VelMax=200M, Preco=60000M}
        };
    }

    public static void Add(Car car)
    {
        Carros.Add(car);
    }
    public static void RemovebyName(string nome)
    {
        
    }

    public static Car ?GetByName(string nome)
    {
        return Carros.Find(c => c.Nome == nome);
    }

    public static IEnumerable<Car> GetAll()
    {
        return Carros.OrderBy(c => c.VelMax).ToArray();
    }

    
    
}