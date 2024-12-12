using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOLID.CleanArchitecture_.NET.Identity.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7903f84a-565f-4cff-84d6-d0239ceb8642", "AQAAAAIAAYagAAAAEBTq4B7MjLDwDPCa3v9Yp77JYYo0AxKn+osEvBKWMuoBpp4q7MN4y1y3k0xYXM/gIQ==", "65449201-a2e2-4e2b-84cc-fea4a0c3832c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "777a668a-180a-4877-8a43-0be13f88ef67", "AQAAAAIAAYagAAAAEIfSOJtetUhbp9oNGFtqlZhZCkN9YQqHWScuyTDgu9L53M1f01Rz3/mehZ2LxDu9bw==", "bd8c4dbc-495f-4b12-92dd-86be5fecee92" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f20aeba4-e939-40ae-ac1b-f5f41817bc09", "AQAAAAIAAYagAAAAEHDrGdEM9K3RFCRQFDRb3Oy5ualQ/Kqtwil1YT34gghxwIhaM69NOOJ74rFbdNU0ww==", "a0906c40-9694-4630-ba73-7c352f49315a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9d6dc1e-63ef-4d91-a459-67cd0bc91759", "AQAAAAIAAYagAAAAEJi2eNKUVjTShrcI4RFncpX1fpNEryRl0Qpish8xGheuw3ZyViiQfr0YOanz2ks2ow==", "7280a9c6-5ffc-4a88-91fc-5d31fea117b4" });
        }
    }
}
