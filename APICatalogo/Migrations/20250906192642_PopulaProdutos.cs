using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "values ('Coca-Cola', 'Refrigerante de cola 350 ml', 5.45, 'coca_cola.jpg',50, now(), 1)");

            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "values ('Lanche de Atum', 'Lanche de Atum grelhado', 8.50, 'lanche_Atum.jpg',20, now(), 2)");

            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "values ('Pudim 100g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg',15, now(), 3)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            //mb.Sql("Delete from Produtos");
        }
    }
}
