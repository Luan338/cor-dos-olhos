using CorDosOlhos.Data;
using CorDosOlhos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorDosOlhos.Controllers
{
    public class EditarcadastroController : Controller
    {
        //vai listar todos clientes cadastrados
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["cadastros"] = dbcontext.Cadastros.Where(p => p.IdC > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cadastro cadastro)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cadastro);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Deletar(Cadastro cadastro)
        {
            var dbcontext = new Contexto();

            var cadastroDelete = dbcontext.Cadastros.Find(cadastro.IdC);
            dbcontext.Remove(cadastroDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Cadastro novosDadosCadastro)
        {
            var dbcontext = new Contexto();

            var antigosDadosCadastro = dbcontext.Cadastros.Find(novosDadosCadastro.IdC);

            antigosDadosCadastro.NomeC = novosDadosCadastro.NomeC;
            antigosDadosCadastro.SobrenomeC = novosDadosCadastro.SobrenomeC;
            antigosDadosCadastro.NasC = novosDadosCadastro.NasC;
            antigosDadosCadastro.CPFC = novosDadosCadastro.CPFC;
            antigosDadosCadastro.Etnia = novosDadosCadastro.Etnia;
            antigosDadosCadastro.Genero = novosDadosCadastro.Genero;
            antigosDadosCadastro.CidadeC = novosDadosCadastro.CidadeC;
            antigosDadosCadastro.UFC = novosDadosCadastro.UFC;
            antigosDadosCadastro.CEPC = novosDadosCadastro.CEPC;
            antigosDadosCadastro.BairroC = novosDadosCadastro.BairroC;
            antigosDadosCadastro.EnderecoC = novosDadosCadastro.EnderecoC;
            antigosDadosCadastro.NumeroC = novosDadosCadastro.NumeroC;
            antigosDadosCadastro.TelefoneC = novosDadosCadastro.TelefoneC;
            antigosDadosCadastro.EmailC = novosDadosCadastro.EmailC;
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}