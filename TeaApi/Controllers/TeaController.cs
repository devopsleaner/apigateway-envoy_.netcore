using System;
using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new []
        { "Green", "Assam", "Earl Grey", "English Breakfast", "Camomile", "Chai"};

        [HttpGet]
        public ActionResult Get()
        {

            var rnd = new Random();

            return Ok(Teas[rnd.Next(Teas.Length)]);
        }
    }
}