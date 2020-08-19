using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helpers;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpGet]
        public string App(int numero)
        {
            string cadena = Conversores.NumeroALetras(numero);
            return cadena;
        }
        [HttpPost]
        public string App1([FromHeader]int numero)
        {
            string cadena = Conversores.NumeroALetras(numero);
            return cadena;
        }
    }
}
