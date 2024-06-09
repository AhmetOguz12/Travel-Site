using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49212296-d06a-4896-9bf2-7f3409a5b882", "AQAAAAIAAYagAAAAEIEZgoQ7z0+Tx6S138JxgGl+Q1u8hCp53ZSZSTXEdvX7ltiOCq88av36hf/+k8CZtQ==", "9761744d-bc68-4921-a6e2-23bcec3f557c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e43c16-f1e2-400c-aaac-04b3c754b5a1", "AQAAAAIAAYagAAAAEB9br2tcsfNlGk9pE9z5FhwfSBHCfj1Eorf2BMT/El9S+69beAhsoxAe9hB5gV7h7A==", "47242777-5d04-4613-bb8d-8fbabac16144" });
        }
    }
}
