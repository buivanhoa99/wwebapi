using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebAPI.Migrations
{
    public partial class addmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Profiles");

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AccountId", "Age", "Fullname", "IdNo" },
                values: new object[,]
                {
                    { 1, 1, 22, "Bui van Hoa", "1233453421321" },
                    { 2, 2, 12, "Nguyen Van A", "12343534521321" },
                    { 3, 3, 42, "Tran Van B", "1321435" },
                    { 4, 4, 22, "Nguyen Thi C", "12325345341321" },
                    { 5, 5, 42, "XXXX YYY ZZZZ", "12334534521321" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
