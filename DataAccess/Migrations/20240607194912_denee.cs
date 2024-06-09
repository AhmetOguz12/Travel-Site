using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class denee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ad1630-9a76-44bf-be8d-eb5301cc5f17", "AQAAAAIAAYagAAAAEKhiRM7lsGC+rEIemV0tHmJLDbpsC2mgKug/tuFpqD0ZrZL59/TVYb4wZqc5L33RPw==", "ecee1453-c0c9-4615-95f3-b39c48193850" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F740C69-F4D4-4057-B149-53414E36BC69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49212296-d06a-4896-9bf2-7f3409a5b882", "AQAAAAIAAYagAAAAEIEZgoQ7z0+Tx6S138JxgGl+Q1u8hCp53ZSZSTXEdvX7ltiOCq88av36hf/+k8CZtQ==", "9761744d-bc68-4921-a6e2-23bcec3f557c" });
        }
    }
}
