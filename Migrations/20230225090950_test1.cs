using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Members_InstrumentId",
                table: "Members",
                column: "InstrumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Instruments_InstrumentId",
                table: "Members",
                column: "InstrumentId",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Instruments_InstrumentId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_InstrumentId",
                table: "Members");
        }
    }
}
