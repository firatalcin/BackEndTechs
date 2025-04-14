using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotnetStore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainPage = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "IsActive", "MainPage", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "1.jpeg", false, true, "Apple Watch 7", 10000.0 },
                    { 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "2.jpeg", true, true, "Apple Watch 8", 20000.0 },
                    { 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "3.jpeg", true, true, "Apple Watch 9", 30000.0 },
                    { 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "4.jpeg", false, false, "Apple Watch 10", 40000.0 },
                    { 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "5.jpeg", true, true, "Apple Watch 11", 50000.0 },
                    { 6, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "6.jpeg", false, false, "Apple Watch 12", 60000.0 },
                    { 7, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "7.jpeg", false, false, "Apple Watch 14", 70000.0 },
                    { 8, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", "8.jpeg", true, true, "Apple Watch 15", 80000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
