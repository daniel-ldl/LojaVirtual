using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public string sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
