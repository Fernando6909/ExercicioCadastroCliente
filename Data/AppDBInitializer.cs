using Exerc01_CadastroCliente.Models;

namespace Exerc01_CadastroCliente.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                if (!context.Cliente.Any())
                {
                    context.Cliente.AddRange(new List<Cliente>()
                    {
                        new Cliente()
                        {
                            Nome = "Sebastião piratinha",
                            Email = "piratinha@sembarco.com.br",
                            Endereco = "Rua do porto, N°121",
                            Telefone = "(55)1234-56789"
                        },
                        new Cliente()
                        {
                            Nome = "Baco deus do vinho",
                            Email = "baco.semvinho@gmail.com.br",
                            Endereco = "Rua sobe e desce, N°6661",
                            Telefone = "(55)1234-561239"
                        },
                        new Cliente()
                        {
                            Nome = "Fernadinho abeira mar",
                            Email = "abeiraMar@yahoo.com.br",
                            Endereco = "Rua desce e sobe. N°666",
                            Telefone = "(55)1234-12349"
                        },
                        new Cliente()
                        {
                            Nome = "Giulia Caneca",
                            Email = "estagiariaTemCaneca@gmail.com.br",
                            Endereco = "Rua do estágio, N°23",
                            Telefone = "(55)1234-12349"
                        },
                        new Cliente()
                        {
                            Nome = "Leonardo Stronda",
                            Email = "Strondaleo@gmail.com.br",
                            Endereco = "Rua 10",
                            Telefone = "(55)1234-56789"
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
