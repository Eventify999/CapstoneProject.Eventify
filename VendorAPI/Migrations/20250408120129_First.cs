using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendorAPI.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "BusinessName", "Email", "PasswordHash" },
                values: new object[] { 1, "zzz", "asd@epic.com", "nothing@epic420" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
