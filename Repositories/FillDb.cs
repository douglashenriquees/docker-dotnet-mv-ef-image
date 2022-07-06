using Microsoft.EntityFrameworkCore;
using mvc1.Models;

namespace mvc1.Repositories;

public static class FillDb
{
    public static void FillDataDb(IApplicationBuilder app)
    {
        FillDataDb(app);
    }

    private static void FillDataDb(AppDbContext appDbContext)
    {
        appDbContext.Database.Migrate();

        if (!appDbContext.Produtos?.Any() ?? false)
        {
            appDbContext.AddRange(
                new Produto() { ProdutoId = 10, Nome = "Caneta", Categoria = "Material", Preco = 2.0M },
                new Produto() { ProdutoId = 20, Nome = "Borracha", Categoria = "Material", Preco = 1.5M },
                new Produto() { ProdutoId = 30, Nome = "Estojo", Categoria = "Material", Preco = 3.0M }
            );
        }
    }
}