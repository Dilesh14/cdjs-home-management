using Microsoft.EntityFrameworkCore.Migrations;

namespace cdjshomemanagement.Migrations
{
    public partial class initialBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false),
            //        EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
            //        Password = table.Column<string>(nullable: false),
            //        UserName = table.Column<string>(nullable: true),
            //        Role = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.ID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
