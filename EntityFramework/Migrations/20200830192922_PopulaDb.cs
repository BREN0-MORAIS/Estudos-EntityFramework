using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Produtos(nome, preco,estoque) values('teste','19.99','2')");
            mb.Sql("insert into Produtos(nome, preco,estoque) values('teste2','19.99','2')");
            mb.Sql("insert into Produtos(nome, preco,estoque) values('teste2','19.99','2')");
            mb.Sql("insert into Produtos(nome, preco,estoque) values('teste2','19.99','2')");
            mb.Sql("insert into Produtos(nome, preco,estoque) values('teste2','19.99','2')");
            
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Produtos");
        }
    }
}
