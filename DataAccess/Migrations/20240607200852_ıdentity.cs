using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ıdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f509f228-8c38-4ebc-92e7-1bdec3ca17d2", "AQAAAAIAAYagAAAAECKHbhv5jAv6eav2cEFs78AHFX05lw6inCM4rO33A5GtRGFLZOQEeu0QEVbEj8479Q==", "c6897b8c-b3c1-4112-91c2-a24291945c10" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f68010f6-e48d-45c7-b713-ac6db96bbf7c", "AQAAAAIAAYagAAAAECsKX0eILxtLjbl5TgszjTdgaDICPMaNhmr05/uKRcnq07McB7pKbJ+5/mAIQH0lrg==", "8133388c-a2a9-4728-b689-85e2068bdeb1" });
        }
    }
}
