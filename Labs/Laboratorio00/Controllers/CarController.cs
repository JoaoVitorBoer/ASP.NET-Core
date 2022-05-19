using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
  
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("GET /car");
        return "Vrum Vrum!";
    }
    [HttpGet("{nome}")]
    public string GetNome(string nome)
    {
        _logger.LogInformation("GET /car/nome");
        return $"Carro: {nome}";
    }

    [HttpPost("attcar")]
    public string AddCar([FromBody] Car car)
    {
        CarServices.Add(car);
        return car.ToString();
    }

    [HttpGet("all")]
    public IEnumerable<Car> GetAll()
    {
        return CarServices.GetAll();
    }
}
