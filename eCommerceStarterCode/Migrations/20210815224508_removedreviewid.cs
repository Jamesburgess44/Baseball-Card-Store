using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class removedreviewid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ce50c102-43e6-4c11-94fb-a9a92df6bcd9", "255316fd-f6d9-4efb-b8dd-53aaa7d29289", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a98ad73b-c7f5-4f69-bd54-c9b293f4eb31", "8d28aded-642a-4649-879e-31e8d8318445", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a98ad73b-c7f5-4f69-bd54-c9b293f4eb31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce50c102-43e6-4c11-94fb-a9a92df6bcd9");

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
    }
}
