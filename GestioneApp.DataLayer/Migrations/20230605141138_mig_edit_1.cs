using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestioneApp.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_edit_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DaysNotice",
                table: "tb_LegislativeAudits",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysNotice",
                table: "tb_LegislativeAudits");
        }
    }
}
