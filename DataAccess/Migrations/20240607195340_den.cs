using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class den : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f68010f6-e48d-45c7-b713-ac6db96bbf7c", "AQAAAAIAAYagAAAAECsKX0eILxtLjbl5TgszjTdgaDICPMaNhmr05/uKRcnq07McB7pKbJ+5/mAIQH0lrg==", "8133388c-a2a9-4728-b689-85e2068bdeb1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ad1630-9a76-44bf-be8d-eb5301cc5f17", "AQAAAAIAAYagAAAAEKhiRM7lsGC+rEIemV0tHmJLDbpsC2mgKug/tuFpqD0ZrZL59/TVYb4wZqc5L33RPw==", "ecee1453-c0c9-4615-95f3-b39c48193850" });
        }
    }
}
