using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest.Migrations
{
    /// <inheritdoc />
    public partial class groupId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InstrumentId",
                table: "Members",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Members",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Members");

            migrationBuilder.AlterColumn<string>(
                name: "InstrumentId",
                table: "Members",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
