using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
           

            mb.Sql("Insert into Categorias(Nome, ImagemUrl)Values ('Bebidas','bebidas.jpg')");
            mb.Sql("Insert into Categorias(Nome, ImagemUrl)Values ('Lanches','lanches.jpg')");
            mb.Sql("Insert into Categorias(Nome, ImagemUrl)Values ('Sobremesas','sobremesas.jpg')");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
              "Values('Coca-Cola Diet','Refligerante de Cola 350 ml' , 5.45,'cocacola.jpg',50,GETDATE(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
               "Values('Lanche de Atum','Lanche de Atum com maionese' , 8.50,'atum.jpg',10,GETDATE(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
               "Values('Pudim 100g','Pudim de leite condensado 100g' ,6.75,'pudim.jpg',20,GETDATE(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
