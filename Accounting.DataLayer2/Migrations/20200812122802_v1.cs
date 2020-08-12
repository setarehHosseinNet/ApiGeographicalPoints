using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.DataLayer2.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DbGeographicalPoints",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JPersen = table.Column<int>(nullable: false),
                    Lat1 = table.Column<double>(nullable: false),
                    Lon1 = table.Column<double>(nullable: false),
                    Lat2 = table.Column<double>(nullable: false),
                    Lon2 = table.Column<double>(nullable: false),
                    Gpoint = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbGeographicalPoints", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DbGeographicalPoints_Persen_JPersen",
                        column: x => x.JPersen,
                        principalTable: "Persen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbGeographicalPoints_JPersen",
                table: "DbGeographicalPoints",
                column: "JPersen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbGeographicalPoints");

            migrationBuilder.DropTable(
                name: "Persen");
        }
    }
}
