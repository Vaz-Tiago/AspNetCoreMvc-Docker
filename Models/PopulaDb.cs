using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Models
{
    public static class PopulaDb
    {
        public static void IncluiDadosDB(IApplicationBuilder app)
        {
            IncluiDadosDB(app.ApplicationServices.GetRequiredService<AppDbContext>());
        }

        public static void IncluiDadosDB(AppDbContext context)
        {
            System.Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate(); // -> Verifica se tem alguma migration pendente

            if(!context.Produtos.Any())
            {
                System.Console.WriteLine("Criando dados...");
                context.Produtos.AddRange(
                    new Produto("Luvas de goleiro", "Futebol", 25),
                    new Produto("Bola de basquete", "Basquete", 48.95m),
                    new Produto("Bola de futebol", "Futebol", 19.50m),
                    new Produto("Tabela", "Basquete", 500)
                );

                context.SaveChanges();
            }else {
                System.Console.WriteLine("Dados já existem");
            }
        }
    }
}