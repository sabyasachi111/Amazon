using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class UserModeltablecreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephonePrim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneSec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreUsers", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "StoreUsers",
                columns: new[] { "UserID", "Email", "TelephonePrim", "TelephoneSec", "Title", "UserFirstName", "UserLastName" },
                values: new object[] { 1, "nayaksabyasachi@gmail.com", "9083889959", null, null, "Sabyasachi_Host", "Nayak" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreUsers");
        }
    }
}
