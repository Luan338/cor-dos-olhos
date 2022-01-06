using CorDosOlhos.Data;
using CorDosOlhos.Models;
using CorDosOlhos.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;


namespace CorDosOlhos.Controllers
{
    //rota
    
    public class EditarcontatoController : Controller
    {
        //vai listar todos clientes cadastrados
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["contatos"] = dbcontext.Contatos.Where(p => p.IdContato > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contato contato)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(contato);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var dbcontext = new Contexto();

            var contatoDelete = dbcontext.Contatos.Find(contato.IdContato);
            dbcontext.Remove(contatoDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Contato novosDadosContato)
        {
            var dbcontext = new Contexto();

            var antigosDadosContato = dbcontext.Contatos.Find(novosDadosContato.IdContato);

            antigosDadosContato.NomeContato = novosDadosContato.NomeContato;
            antigosDadosContato.EmailContato = novosDadosContato.EmailContato;
            antigosDadosContato.MsgContato = novosDadosContato.MsgContato;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
