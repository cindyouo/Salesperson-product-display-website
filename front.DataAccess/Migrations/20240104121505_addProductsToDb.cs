using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace front.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "毛茸茸的小獅子穿著那套大紅衣裳，戴起了那可愛的毛絨帽，那條翹著的尾巴，像鐘擺一樣。", "獅子座", 750.0 },
                    { 2, "以希臘的維納斯女神為設計靈感整體色調以白色為主，金色、亮黃色突出天秤座的優雅大方。", "天秤座", 1040.0 },
                    { 3, "仙女閣裡，淡淡一抹胭脂，著一身粉嫩花裙，花苞般的裙子，宛如含羞待放的花朵，出尘如仙。", "處女座", 1270.0 },
                    { 4, "夏天開始的第一個星座，以螃蟹可愛的蟹鉗和鮮豔的橙黃色為主為靈感來源，融入古風元素。", "巨蟹座", 790.0 },
                    { 5, "这些兔兔帶給人們放鬆、開心和充滿溫馨感的感覺，營造出一種歡樂和愉悅的氛圍，讓人感受到無憂無慮的野餐時光。", "野餐兔兔", 300.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
