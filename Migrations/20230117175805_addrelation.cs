using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CosinusApp.Migrations
{
    /// <inheritdoc />
    public partial class addrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Requests_KnownHostId",
                table: "Requests",
                column: "KnownHostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_KnownHosts_KnownHostId",
                table: "Requests",
                column: "KnownHostId",
                principalTable: "KnownHosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_KnownHosts_KnownHostId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_KnownHostId",
                table: "Requests");
        }
    }
}
