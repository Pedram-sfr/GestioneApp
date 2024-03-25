using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestioneApp.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_edit_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "tb_JobTitles",
                newName: "JobTitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "tb_JobTitles",
                newName: "JobId");
        }
    }
}
