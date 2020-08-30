using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
     class SeedDataBase
    {
        public static void SeedProdutos(AppDbContext contexto)
        {
            //se não existe dados  contexto.Produtos.Any()
            if (!contexto.Produtos.Any())
            {
                //vamos inserir os dados
                //cria uma variavel adiciona um list no modelo Produto 
                var produtos = new List<Produto>
                {
                new Produto {Nome = "Compasso" , Preco = 17, Estoque = 5},
                new Produto { Nome = "Relogio", Preco = 17, Estoque = 5 },
                new Produto { Nome = "Boneco", Preco = 17, Estoque = 5 },
                };
                //como esta incluindo mais de um produto na tabela , utiliza-se o AddRange
                //se fosse somente um poderia utilizar somente  Add
                //depois adicione como parametro a lista de produtos, estão na memoria
                contexto.AddRange(produtos);//esta n memoria

                //para inserir os dados é so chamar o SaveChanges
                contexto.SaveChanges();
            }

        }
    }
}
