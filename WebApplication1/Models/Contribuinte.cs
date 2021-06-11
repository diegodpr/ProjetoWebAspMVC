using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Contribuinte
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime AnoNascimento { get; set; }
        public string Cidade { get; set; }

        public Contribuinte(int id, string nome, DateTime anoNascimento, string cidade)
        {
            Id = id;
            Nome = nome;
            AnoNascimento = anoNascimento;
            Cidade = cidade;
        }
    }
}
