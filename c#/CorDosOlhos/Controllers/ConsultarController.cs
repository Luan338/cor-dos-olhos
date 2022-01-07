using CorDosOlhos.Data;
using CorDosOlhos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorDosOlhos.Controllers
{
    public class ConsultarController : Controller
    {
        [HttpGet]
        public IActionResult Consultar()
        {
            var dbcontext = new Contexto();

            ViewData["registros"] = dbcontext.Registros.Where(p => p.IdRegistro > 0).ToList();
            return View();
        }

        
    }
}
