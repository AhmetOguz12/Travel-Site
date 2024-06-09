using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e43c16-f1e2-400c-aaac-04b3c754b5a1", "AQAAAAIAAYagAAAAEB9br2tcsfNlGk9pE9z5FhwfSBHCfj1Eorf2BMT/El9S+69beAhsoxAe9hB5gV7h7A==", "47242777-5d04-4613-bb8d-8fbabac16144" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48163cde-c1d1-4c02-a765-2cb2455d3a37", "AQAAAAIAAYagAAAAEGWYBUud7NLgqQGPZ6I4vdDPkTvywTvtZKC9I8dI566iqfohY37FN0Ei168Uz+URUA==", "c9fd87c5-40d3-4b68-b16c-bd8a265f584b" });
        }
    }
}
