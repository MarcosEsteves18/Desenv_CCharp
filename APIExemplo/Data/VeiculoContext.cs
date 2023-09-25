using APIExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIExemplo.Data
{
    public class VeiculoContext: DbContext
    {
        //Construtor
        public VeiculoContext(
            DbContextOptions<VeiculoContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
