using Microsoft.AspNetCore.Mvc;
using BJSS.BenchManagement.UI.Data;
using BJSS.BenchManagement.UI.Models;

namespace BJSS.BenchManagement.UI.Controllers
{
    [ApiController]
    [Route("bench")]
    public class BenchController : Controller
    {
        public BenchContext _benchContext { get; }

        public BenchController(BenchContext benchContext)
        {
            _benchContext = benchContext;
        }

        [HttpGet]
        public ActionResult<List<BenchPlayer>> GetAll() => new List<BenchPlayer> 
        { 
            new BenchPlayer() 
            { 
                FullName = "Damásio Sabino", 
                Role = "Software Engineer"
            },
            new BenchPlayer() 
            { 
                FullName = "Josué Costa", 
                Role = "Software Engineer"
            } 
        };
            // _benchContext.BenchPlayer.ToList();

    }
}