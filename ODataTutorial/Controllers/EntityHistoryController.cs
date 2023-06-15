using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ODataTutorial.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EntityHistoryController : ControllerBase
{
    private readonly DbContext _db;

    public EntityHistoryController(DbContext db)
    {
        _db = db;
    }

    [HttpGet("{id}/history")]
    public IActionResult GetEntityHistory(int id)
    {
        var history = _db.Set<AutoHistory>()
             .Where(h => h.TableName == "AutoHistories" && h.Id == id)
             .ToList();

        return Ok(history);
    }
}
