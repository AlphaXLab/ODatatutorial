using Microsoft.AspNetCore.Mvc;
using ODataTutorial.Data;

namespace ODataTutorial.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomController : ControllerBase
{
    private readonly DataContext _db;

    private readonly ILogger<TodosController> _logger;

    public CustomController(DataContext dbContext, ILogger<TodosController> logger)
    {
        _logger = logger;
        _db = dbContext;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public String Get()
    {
        // business logic
        return "Business logic applied api return example";
    }
}
