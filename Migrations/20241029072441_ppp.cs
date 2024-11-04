using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.Migrations
{
    /// <inheritdoc />
    public partial class ppp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PCategory = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.PId);
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
