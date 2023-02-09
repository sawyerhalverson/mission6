using Microsoft.EntityFrameworkCore.Migrations;

namespace mission6.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Fantasy", "JK Rowling", false, "No one", "This was a great film", "PG", "Harry Potter", 2007 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Fantasy", "JK Rowling", false, "No one", "This was a great film as well", "PG-13", "Harry Potter: The Chamber of Secrets", 2010 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Fantasy", "JK Rowling", false, "No one", "This was a great film too!", "PG-13", "Harry Potter: The Prisoner of Azkaban", 2012 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
