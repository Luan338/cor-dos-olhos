using CorDosOlhos.Data;
using CorDosOlhos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorDosOlhos.Controllers
{
    public class RegistroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["registros"] = dbcontext.Registros.Where(p => p.IdRegistro > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Registro registro)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(registro);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Deletar(Registro registro)
        {
            var dbcontext = new Contexto();

            var registroDelete = dbcontext.Registros.Find(registro.IdRegistro);
            dbcontext.Remove(registroDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Registro novosDadosRegistro)
        {
            var dbcontext = new Contexto();

            var antigosDadosRegistro = dbcontext.Registros.Find(novosDadosRegistro.IdRegistro);

            antigosDadosRegistro.CidadeRegistro = novosDadosRegistro.CidadeRegistro;
            antigosDadosRegistro.CEPRegistro = novosDadosRegistro.CEPRegistro;
            antigosDadosRegistro.BairroRegistro = novosDadosRegistro.BairroRegistro;
            antigosDadosRegistro.EnderecoRegistro = novosDadosRegistro.EnderecoRegistro;
            antigosDadosRegistro.NumeroRegistro = novosDadosRegistro.NumeroRegistro;
            antigosDadosRegistro.PontoRefRegistro = novosDadosRegistro.PontoRefRegistro;
            antigosDadosRegistro.DescricaoRegistro = novosDadosRegistro.DescricaoRegistro;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
