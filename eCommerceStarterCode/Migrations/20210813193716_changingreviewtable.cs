using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class changingreviewtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ReviewUserId_ReviewMerchId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewUserId_ReviewMerchId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewMerchId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewUserId",
                table: "Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewMerchId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewUserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewUserId_ReviewMerchId",
                table: "Reviews",
                columns: new[] { "ReviewUserId", "ReviewMerchId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviews_ReviewUserId_ReviewMerchId",
                table: "Reviews",
                columns: new[] { "ReviewUserId", "ReviewMerchId" },
                principalTable: "Reviews",
                principalColumns: new[] { "UserId", "MerchId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
