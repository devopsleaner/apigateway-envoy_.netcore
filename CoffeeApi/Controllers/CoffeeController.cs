using System;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {


        private static readonly string[] Coffees = new []
        { "Flat white", "Long Black", "Latte", "Americano", "Cappuccino", "Espresso"};

        [HttpGet]
        public ActionResult Get(){

            var rnd = new Random();

            return Ok(Coffees[rnd.Next(Coffees.Length)]);
        }
    }
}