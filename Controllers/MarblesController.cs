using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using marblesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace marblesApi.Controllers
{
    [Route("api/[controller]")]
    public class MarblesController : Controller
    {   
        [Route("/api/Input")]
        public IActionResult Index()
        {
            return View("Index");
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<MarblesModel> Get()
        {
            var Marbles = new MarblesModel();
            List<MarblesModel> MarbleBag = Marbles.MarbleBag();
            return MarbleBag;
        }

        [HttpGet("/api/Random")]
        public MarblesModel Marbles()
        {
            var Marbles = new MarblesModel();
            List<MarblesModel> MarbleBag = Marbles.MarbleBag();

            Random rnd = new Random();
            Marbles = MarbleBag[rnd.Next(0, MarbleBag.Count())];
            return Marbles;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MarblesModel Get(int id)
        {
            var Marbles = new MarblesModel();
            List<MarblesModel> MarbleBag = Marbles.MarbleBag();
            return MarbleBag[id - 1];
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromForm]int id, string color)
        {
            var Marbles = new MarblesModel();
            List<MarblesModel> MarbleBag = Marbles.MarbleBag();
            var newMarble = new MarblesModel
            {
                Id = MarbleBag.Count()+1, 
                Color = color
            };

            MarbleBag.Add(newMarble);
            Console.WriteLine(newMarble);
            return RedirectToAction("Get");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
