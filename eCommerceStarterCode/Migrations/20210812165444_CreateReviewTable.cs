using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class CreateReviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MerchId = table.Column<int>(type: "int", nullable: false),
                    UserReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewMerchId = table.Column<int>(type: "int", nullable: true),
                    ReviewUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.UserId, x.MerchId });
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Merches_MerchId",
                        column: x => x.MerchId,
                        principalTable: "Merches",
                        principalColumn: "MerchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Reviews_ReviewUserId_ReviewMerchId",
                        columns: x => new { x.ReviewUserId, x.ReviewMerchId },
                        principalTable: "Reviews",
                        principalColumns: new[] { "UserId", "MerchId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MerchId",
                table: "Reviews",
                column: "MerchId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewUserId_ReviewMerchId",
                table: "Reviews",
                columns: new[] { "ReviewUserId", "ReviewMerchId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
