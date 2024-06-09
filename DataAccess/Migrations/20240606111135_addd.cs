using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seyahats_Şehirs_ŞehirId",
                table: "Seyahats");

            migrationBuilder.DropIndex(
                name: "IX_Seyahats_ŞehirId",
                table: "Seyahats");

            migrationBuilder.AddColumn<int>(
                name: "KişiSayısı",
                table: "Seyahats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeyahatId = table.Column<int>(type: "int", nullable: false),
                    KişiSayısı = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropColumn(
                name: "KişiSayısı",
                table: "Seyahats");

            migrationBuilder.CreateIndex(
                name: "IX_Seyahats_ŞehirId",
                table: "Seyahats",
                column: "ŞehirId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seyahats_Şehirs_ŞehirId",
                table: "Seyahats",
                column: "ŞehirId",
                principalTable: "Şehirs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
