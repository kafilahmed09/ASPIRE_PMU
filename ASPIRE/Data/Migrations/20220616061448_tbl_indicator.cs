using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class tbl_indicator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schools");

            migrationBuilder.AlterColumn<string>(
                name: "DistanceOfNearestWaterSource",
                schema: "master",
                table: "School",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Indicator",
                schema: "master",
                columns: table => new
                {
                    IndicatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndicatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMultiple = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicator", x => x.IndicatorId);
                });

            migrationBuilder.CreateTable(
                name: "IndicatorEvidence",
                schema: "Schools",
                columns: table => new
                {
                    IndicatorEvidenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndicatorId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfUpload = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicatorEvidence", x => x.IndicatorEvidenceId);
                    table.ForeignKey(
                        name: "FK_IndicatorEvidence_Indicator_IndicatorId",
                        column: x => x.IndicatorId,
                        principalSchema: "master",
                        principalTable: "Indicator",
                        principalColumn: "IndicatorId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_IndicatorEvidence_School_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "master",
                        principalTable: "School",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorEvidence_IndicatorId",
                schema: "Schools",
                table: "IndicatorEvidence",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorEvidence_SchoolId",
                schema: "Schools",
                table: "IndicatorEvidence",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicatorEvidence",
                schema: "Schools");

            migrationBuilder.DropTable(
                name: "Indicator",
                schema: "master");

            migrationBuilder.AlterColumn<decimal>(
                name: "DistanceOfNearestWaterSource",
                schema: "master",
                table: "School",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
