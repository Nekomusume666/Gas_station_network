using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gasstationnetwork.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    UserRole = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Login);
                });


            migrationBuilder.CreateTable(
                name: "GasStations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasStations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Column",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    NameFuel = table.Column<string>(type: "TEXT", nullable: false),
                    VolumeFuel = table.Column<int>(type: "INTEGER", nullable: false),
                    GasStationID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Column", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Column_GasStations_GasStationID",
                        column: x => x.GasStationID,
                        principalTable: "GasStations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Column_GasStationID",
                table: "Column",
                column: "GasStationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");


            migrationBuilder.DropTable(
                name: "Column");

            migrationBuilder.DropTable(
                name: "GasStations");
        }
    }
}
