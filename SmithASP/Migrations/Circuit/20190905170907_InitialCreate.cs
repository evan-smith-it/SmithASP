using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Circuit
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Current",
                columns: table => new
                {
                    CurrentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amps = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current", x => x.CurrentId);
                });

            migrationBuilder.CreateTable(
                name: "Voltage",
                columns: table => new
                {
                    VoltageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Volts = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voltage", x => x.VoltageId);
                });

            migrationBuilder.CreateTable(
                name: "Resistance",
                columns: table => new
                {
                    ResistanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ohms = table.Column<double>(nullable: false),
                    CircuitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resistance", x => x.ResistanceId);
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    CircuitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentId = table.Column<int>(nullable: true),
                    SourceVoltsVoltageId = table.Column<int>(nullable: true),
                    TotalResistanceResistanceId = table.Column<int>(nullable: true),
                    ElectronsPerSecond = table.Column<double>(nullable: false),
                    RunTime = table.Column<double>(nullable: false),
                    JoulesPerSecond = table.Column<double>(nullable: false),
                    ComponentCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.CircuitId);
                    table.ForeignKey(
                        name: "FK_Circuits_Current_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "Current",
                        principalColumn: "CurrentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Circuits_Voltage_SourceVoltsVoltageId",
                        column: x => x.SourceVoltsVoltageId,
                        principalTable: "Voltage",
                        principalColumn: "VoltageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Circuits_Resistance_TotalResistanceResistanceId",
                        column: x => x.TotalResistanceResistanceId,
                        principalTable: "Resistance",
                        principalColumn: "ResistanceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_CurrentId",
                table: "Circuits",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_SourceVoltsVoltageId",
                table: "Circuits",
                column: "SourceVoltsVoltageId");

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_TotalResistanceResistanceId",
                table: "Circuits",
                column: "TotalResistanceResistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resistance_CircuitId",
                table: "Resistance",
                column: "CircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resistance_Circuits_CircuitId",
                table: "Resistance",
                column: "CircuitId",
                principalTable: "Circuits",
                principalColumn: "CircuitId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Circuits_Current_CurrentId",
                table: "Circuits");

            migrationBuilder.DropForeignKey(
                name: "FK_Circuits_Voltage_SourceVoltsVoltageId",
                table: "Circuits");

            migrationBuilder.DropForeignKey(
                name: "FK_Circuits_Resistance_TotalResistanceResistanceId",
                table: "Circuits");

            migrationBuilder.DropTable(
                name: "Current");

            migrationBuilder.DropTable(
                name: "Voltage");

            migrationBuilder.DropTable(
                name: "Resistance");

            migrationBuilder.DropTable(
                name: "Circuits");
        }
    }
}
