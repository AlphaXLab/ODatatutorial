using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using ODataTutorial.Models;
using ODataTutorial.Data;

namespace ODataTutorial.Controllers
{
    public class CustomController : ODataController
    {
        private readonly DataContext _db;

        private readonly ILogger<TodosController> _logger;

        public CustomController(DataContext dbContext, ILogger<TodosController> logger)
        {
            _logger = logger;
            _db = dbContext;
        }


    }
}