using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class updatetableschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Merches",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2781a968-244a-4cea-88bb-761320587bde", "74d37397-fdc4-4d76-bb8e-15de6590e397", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68cb4b22-bfdf-44ca-80a1-ae15e9f187bd", "3863d774-8802-4f7a-b510-95ec5bb33a13", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Merches_UserId",
                table: "Merches",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Merches_AspNetUsers_UserId",
                table: "Merches",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Merches_AspNetUsers_UserId",
                table: "Merches");

            migrationBuilder.DropIndex(
                name: "IX_Merches_UserId",
                table: "Merches");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2781a968-244a-4cea-88bb-761320587bde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68cb4b22-bfdf-44ca-80a1-ae15e9f187bd");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Merches");
        }
    }
}
