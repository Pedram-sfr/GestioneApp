using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestioneApp.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_JobTitles",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_JobTitles", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "tb_PATypes",
                columns: table => new
                {
                    PAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_PATypes", x => x.PAId);
                });

            migrationBuilder.CreateTable(
                name: "tb_WorkTitles",
                columns: table => new
                {
                    WorkTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_WorkTitles", x => x.WorkTitleId);
                });

            migrationBuilder.CreateTable(
                name: "tb_LegislativeAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    References_Law = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applicable = table.Column<bool>(type: "bit", nullable: true),
                    Activity_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Update_Normative = table.Column<bool>(type: "bit", nullable: true),
                    Actions_ToBeCarryOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Responsible_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkDoneDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amb = table.Column<bool>(type: "bit", nullable: true),
                    SS = table.Column<bool>(type: "bit", nullable: true),
                    Actions_ToBeCarriedOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkDoneCheck = table.Column<bool>(type: "bit", nullable: true),
                    Storaged = table.Column<bool>(type: "bit", nullable: true),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Energy = table.Column<bool>(type: "bit", nullable: true),
                    COD = table.Column<int>(type: "int", nullable: true),
                    SPriority = table.Column<bool>(type: "bit", nullable: true),
                    Confidential = table.Column<bool>(type: "bit", nullable: true),
                    WorkTitleId = table.Column<int>(type: "int", nullable: false),
                    pATypeId = table.Column<int>(type: "int", nullable: false),
                    jobTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_LegislativeAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_LegislativeAudits_tb_JobTitles_jobTitleId",
                        column: x => x.jobTitleId,
                        principalTable: "tb_JobTitles",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_LegislativeAudits_tb_PATypes_pATypeId",
                        column: x => x.pATypeId,
                        principalTable: "tb_PATypes",
                        principalColumn: "PAId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_LegislativeAudits_tb_WorkTitles_WorkTitleId",
                        column: x => x.WorkTitleId,
                        principalTable: "tb_WorkTitles",
                        principalColumn: "WorkTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_LegislativeAudits_jobTitleId",
                table: "tb_LegislativeAudits",
                column: "jobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_LegislativeAudits_pATypeId",
                table: "tb_LegislativeAudits",
                column: "pATypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_LegislativeAudits_WorkTitleId",
                table: "tb_LegislativeAudits",
                column: "WorkTitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_LegislativeAudits");

            migrationBuilder.DropTable(
                name: "tb_JobTitles");

            migrationBuilder.DropTable(
                name: "tb_PATypes");

            migrationBuilder.DropTable(
                name: "tb_WorkTitles");
        }
    }
}
