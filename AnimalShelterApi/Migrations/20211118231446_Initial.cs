using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Color = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Color", "Description", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "Brown", "Ralph is a 3 year old male dog. He is brown in color and as lovable as they come!", "Male", "Ralph", "Canine" },
                    { 2, 9, "Orange", "Suzy is an older 9 year old female cat. She is orange in color, gentle and nurturing -- great for an older person with plenty of patience.", "Female", "Suzy", "Feline" },
                    { 3, 5, "Black", "Terry is a 5 year old female dog. Terry is black in color, energetic and ready to meet her new active family!", "Female", "Terry", "Canine" },
                    { 4, 4, "Tabby", "Jake is a 4 year old male cat. Jake is a tabby cat, and quite playful. He'd be a great addition to a younger family.", "Male", "Jake", "Feline" },
                    { 5, 8, "Yellow", "Dino is an 8 year old male dog. Dino is Yellow in color. Don't let his age fool you; this happy dog's best days are still in front of him.", "Male", "Dino", "Canine" },
                    { 6, 1, "Grey", "Lambert is a 1 year old female kitten, grey in color. Lambert is as cute and cuddly as they come, and is sure to warm even the coldest of hearts.", "Female", "Lambert", "Feline" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
