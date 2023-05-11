using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiMarcas.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "marca", "name", "price" },
                values: new object[] { 2L, "bone", "Lindo bone", "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem4.png", "Lacoste", "Bone", 80m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "marca", "name", "price" },
                values: new object[] { 3L, "T-shirt", "Linda camiseta", "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem6.png", "Osklen", "Camiseta", 80m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "marca", "name", "price" },
                values: new object[] { 4L, "Polo", "Linda camisa polo", "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem7.png", "Lacoste", "Camisa polo", 120m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
