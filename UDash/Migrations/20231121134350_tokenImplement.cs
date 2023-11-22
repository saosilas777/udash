using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDash.Migrations
{
    /// <inheritdoc />
    public partial class tokenImplement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Login_UserId",
                table: "Login",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Login_Users_UserId",
                table: "Login",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Login_Users_UserId",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Login_UserId",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");
        }
    }
}
