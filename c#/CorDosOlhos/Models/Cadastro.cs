using CorDosOlhos.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorDosOlhos.Models
{
    public class Cadastro
    {
        public int IdC { get; set; }
        public string NomeC { get; set; }
        public string SobrenomeC { get; set; }
        public DateTime NasC { get; set; }
        public string CPFC { get; set; }
        public Etnia Etnia { get; set; }
        public Genero Genero { get; set; }
        public string CidadeC { get; set; }
        public string UFC { get; set; }
        public string CEPC { get; set; }
        public string BairroC { get; set; }
        public string EnderecoC { get; set; }
        public int NumeroC { get; set; }
        public int TelefoneC { get; set; }
        public string EmailC { get; set; }


    }
}
