using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seyahats_Şehirs_ŞehirId1",
                table: "Seyahats");

            migrationBuilder.DropIndex(
                name: "IX_Seyahats_ŞehirId1",
                table: "Seyahats");

            migrationBuilder.DropColumn(
                name: "ŞehirId1",
                table: "Seyahats");

            migrationBuilder.AlterColumn<int>(
                name: "ŞehirId",
                table: "Seyahats",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seyahats_Şehirs_ŞehirId",
                table: "Seyahats");

            migrationBuilder.DropIndex(
                name: "IX_Seyahats_ŞehirId",
                table: "Seyahats");

            migrationBuilder.AlterColumn<string>(
                name: "ŞehirId",
                table: "Seyahats",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ŞehirId1",
                table: "Seyahats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seyahats_ŞehirId1",
                table: "Seyahats",
                column: "ŞehirId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Seyahats_Şehirs_ŞehirId1",
                table: "Seyahats",
                column: "ŞehirId1",
                principalTable: "Şehirs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
