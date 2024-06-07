using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gemicle.MarketerTool.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Deposite = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsNewCustomer = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Age", "City", "Deposite", "Gender", "IsNewCustomer" },
                values: new object[,]
                {
                    { 1L, 53, "London", 104m, 1, false },
                    { 2L, 44, "New York", 209m, 0, true },
                    { 3L, 36, "New York", 208m, 1, true },
                    { 4L, 87, "London", 134m, 0, false },
                    { 5L, 54, "Paris", 123m, 1, true },
                    { 6L, 45, "New York", 210m, 0, true },
                    { 7L, 49, "Tel-Aviv", 174m, 0, false },
                    { 8L, 35, "Paris", 52m, 1, true },
                    { 9L, 61, "Tel-Aviv", 151m, 1, false },
                    { 10L, 78, "Paris", 57m, 1, false },
                    { 11L, 41, "New York", 131m, 0, false },
                    { 12L, 32, "Tel-Aviv", 154m, 0, true },
                    { 13L, 62, "Paris", 135m, 0, false },
                    { 14L, 67, "Tel-Aviv", 153m, 1, true },
                    { 15L, 68, "London", 241m, 0, true },
                    { 16L, 41, "London", 134m, 1, false },
                    { 17L, 46, "London", 212m, 0, false },
                    { 18L, 77, "Tel-Aviv", 97m, 0, true },
                    { 19L, 51, "London", 141m, 1, true },
                    { 20L, 80, "Paris", 189m, 1, false },
                    { 21L, 31, "Tel-Aviv", 134m, 0, true },
                    { 22L, 80, "Tel-Aviv", 81m, 0, false },
                    { 23L, 36, "London", 237m, 0, true },
                    { 24L, 65, "Tel-Aviv", 119m, 0, false },
                    { 25L, 72, "Tel-Aviv", 139m, 1, false },
                    { 26L, 64, "Tel-Aviv", 128m, 1, true },
                    { 27L, 29, "London", 76m, 1, true },
                    { 28L, 25, "London", 203m, 1, true },
                    { 29L, 77, "New York", 54m, 1, true },
                    { 30L, 79, "Paris", 165m, 0, true },
                    { 31L, 26, "Paris", 143m, 0, true },
                    { 32L, 74, "London", 61m, 0, false },
                    { 33L, 74, "New York", 103m, 1, false },
                    { 34L, 46, "New York", 121m, 0, true },
                    { 35L, 47, "New York", 214m, 0, false },
                    { 36L, 78, "New York", 111m, 0, false },
                    { 37L, 46, "New York", 223m, 0, true },
                    { 38L, 26, "New York", 78m, 0, true },
                    { 39L, 49, "Tel-Aviv", 60m, 0, false },
                    { 40L, 74, "New York", 53m, 0, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
