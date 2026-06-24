using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Quality_Checker.Migrations
{
    /// <inheritdoc />
    public partial class AddDomainEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValidationConfiguration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    EnabledRules = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thresholds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValidationRuns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    EntityType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationRuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidationRuns_ValidationConfiguration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "ValidationConfiguration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValidationRunId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecordId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueType = table.Column<int>(type: "int", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActualValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Issue_ValidationRuns_ValidationRunId",
                        column: x => x.ValidationRunId,
                        principalTable: "ValidationRuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_ValidationRunId",
                table: "Issue",
                column: "ValidationRunId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuns_ConfigurationId",
                table: "ValidationRuns",
                column: "ConfigurationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");

            migrationBuilder.DropTable(
                name: "ValidationRuns");

            migrationBuilder.DropTable(
                name: "ValidationConfiguration");
        }
    }
}
