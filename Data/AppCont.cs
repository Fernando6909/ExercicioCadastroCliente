using Exerc01_CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace Exerc01_CadastroCliente.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }
        
        public DbSet<Cliente> Cliente { get; set; }
    }
}
