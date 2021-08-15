using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class addedreviewid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2781a968-244a-4cea-88bb-761320587bde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68cb4b22-bfdf-44ca-80a1-ae15e9f187bd");

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f47cacab-9b84-46c2-9c5b-54ffa2fdaf01", "95b64bd5-0064-4563-9ce8-f6c6dac8238f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce86c0f2-6774-4537-97d4-d0b2a148062b", "c0159f35-dc85-43c1-9bd5-d3b81d331eb4", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce86c0f2-6774-4537-97d4-d0b2a148062b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f47cacab-9b84-46c2-9c5b-54ffa2fdaf01");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2781a968-244a-4cea-88bb-761320587bde", "74d37397-fdc4-4d76-bb8e-15de6590e397", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68cb4b22-bfdf-44ca-80a1-ae15e9f187bd", "3863d774-8802-4f7a-b510-95ec5bb33a13", "Admin", "ADMIN" });
        }
    }
}
