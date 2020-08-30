using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFramework
{
    #region 01- Modelos das Entidades
    //01-entidade onde fica os Modelos
    class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }

    #endregion

    #region 02 - Contexto , onde se mapeia o Modelo eConfigura a Conexão 
    //02-classe de Contexto onde se mapei o modelo e define a string de Conexão
      class AppDbContext : DbContext
    {
        //mapeamento da entidade para a tabela

        /*
         * por padrão mapea a tabela que vai ser criada no banco no db contexto sempre no Plural
         * pois tem vairios atributos envolvidos
         */
        public DbSet<Produto> Produtos { get; set; }

        //definir o provedor e a string de conexão para o banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //o construtor optionsBuilder chama o Provedor de Conexão
            /*
             
             */
            optionsBuilder.UseSqlServer(
                @$"Data Source=DESKTOP-FUH39GV\BFMSERVER;
                   User ID=sa;
                   Password=BRENOMORAIS2930;
                   Initial Catalog=GerenInfo;
                   ");
        }
    }
    #endregion

    #region 03 - Programa Principal Onde Mostra os Dados e entre outros
    public static  class Program
    {
      public  static void Main(string[] args)
        {

            /*app context representa uma sessão com o banco de dados e para pegar os dados
             * da tabela desejada chama o using e passa um objeto;
            */
            using (var db = new AppDbContext()) {
                /*depois cria uma variavel referente a tabela chama o produto em lista para pegar os
                 * dados
                */

                //basta colocar a instancia do contexto para persistir os dados wue é o db
                SeedDataBase.SeedProdutos(db);

                var Produtos = db.Produtos.ToList();

                //para percorrer a lista basta usar um foreach ou for


                foreach(var p in Produtos)
                {
                    //apartir que cria é so chamar a variavel mais o Nome da coluna que qur mostrar
                    //por exemplo chamamos o nome 

                        Console.WriteLine($"Nome: {p.Nome} Preço: {p.Preco} Estoque: {p.Estoque}");
         
                   
                }

            }
            Console.ReadLine();
        }
    }

    #endregion

}
