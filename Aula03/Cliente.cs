using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        Cliente() { }
        public Cliente(string nome) 
        {
            Nome = nome;
        }

        public String GerarRelatorio()
        {
            return this.Nome + " -" + this.Email;
        }

    }
}
