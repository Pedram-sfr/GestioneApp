using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestioneApp.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_LegislativeAudits_tb_JobTitles_jobTitleId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_LegislativeAudits_tb_PATypes_pATypeId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_LegislativeAudits_tb_WorkTitles_WorkTitleId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropTable(
                name: "tb_JobTitles");

            migrationBuilder.DropTable(
                name: "tb_PATypes");

            migrationBuilder.DropTable(
                name: "tb_WorkTitles");

            migrationBuilder.DropIndex(
                name: "IX_tb_LegislativeAudits_jobTitleId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropIndex(
                name: "IX_tb_LegislativeAudits_pATypeId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropIndex(
                name: "IX_tb_LegislativeAudits_WorkTitleId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropColumn(
                name: "WorkTitleId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropColumn(
                name: "jobTitleId",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropColumn(
                name: "pATypeId",
                table: "tb_LegislativeAudits");

            migrationBuilder.AlterColumn<string>(
                name: "References_Law",
                table: "tb_LegislativeAudits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "tb_LegislativeAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "tb_LegislativeAudits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PAType",
                table: "tb_LegislativeAudits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkTitle",
                table: "tb_LegislativeAudits",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropColumn(
                name: "PAType",
                table: "tb_LegislativeAudits");

            migrationBuilder.DropColumn(
                name: "WorkTitle",
                table: "tb_LegislativeAudits");

            migrationBuilder.AlterColumn<string>(
                name: "References_Law",
                table: "tb_LegislativeAudits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "tb_LegislativeAudits",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "WorkTitleId",
                table: "tb_LegislativeAudits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "jobTitleId",
                table: "tb_LegislativeAudits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pATypeId",
                table: "tb_LegislativeAudits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_JobTitles",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_JobTitles", x => x.JobTitleId);
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

            migrationBuilder.AddForeignKey(
                name: "FK_tb_LegislativeAudits_tb_JobTitles_jobTitleId",
                table: "tb_LegislativeAudits",
                column: "jobTitleId",
                principalTable: "tb_JobTitles",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_LegislativeAudits_tb_PATypes_pATypeId",
                table: "tb_LegislativeAudits",
                column: "pATypeId",
                principalTable: "tb_PATypes",
                principalColumn: "PAId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_LegislativeAudits_tb_WorkTitles_WorkTitleId",
                table: "tb_LegislativeAudits",
                column: "WorkTitleId",
                principalTable: "tb_WorkTitles",
                principalColumn: "WorkTitleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
