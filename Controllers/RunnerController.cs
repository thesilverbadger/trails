using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using trails.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<Runner> Get()
        {
            return new List<Runner>()
            {
                new Runner()
                {
                    Id = 1,
                    Firstname = "Tom",
                    Lastname = "Wire",
                    Age = 34,
                    FavouriteBeer = "Sierra Nevada"
                },
                new Runner()
                {
                    Id = 2,
                    Firstname = "Julia",
                    Lastname = "Wire",
                    Age = 33,
                    FavouriteBeer = "Kirin Ichiban"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().FirstOrDefault(x => x.Id == id);
        }

        
    }
}
