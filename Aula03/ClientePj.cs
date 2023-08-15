using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class ClientePj : Cliente
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public ClientePj(string nome, string Cnpj) : base(nome)
        {
            Cnpj = Cnpj;
        }

        public string GerarRelatorio()
        {
            return this.RazaoSocial + " -" + base.Email;
        }


    }
}
