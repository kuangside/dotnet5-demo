using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet5_demo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbUser",
                columns: table => new 
                {
                    UserID = table.Column<string>(type: "nvarchar(10)", nullable: false).Annotation("Sqlserver:Identity", "1,1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    CreateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    UpdateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserID", x => x.UserID);
                }
            );

            migrationBuilder.CreateTable(
                name: "tbPartTarget",
                columns: table => new 
                {
                    PartTargetID = table.Column<int>(type: "int", nullable: false).Annotation("Sqlserver:Identity", "1,1"),
                    PartTargetNo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PartTargetName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BlockCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    UpdateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTargetID", x => x.PartTargetID);
                    table.UniqueConstraint("IX_PartTargetBlockCode", x=> new {x.PartTargetNo,x.BlockCode} );
                }
            );

            migrationBuilder.CreateTable(
                name: "tbBlock",
                columns: table => new 
                {
                    BlockID = table.Column<int>(type: "int", nullable: false).Annotation("Sqlserver:Identity", "1,1"),
                    BlockCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LocationList = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    UpdateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockID", x => x.BlockID);
                    table.UniqueConstraint("IX_BlockCode", x=>x.BlockCode);
                }
            );

            migrationBuilder.CreateTable(
                name: "tbScanHistory",
                columns: table => new 
                {
                    ScanHistoryID = table.Column<int>(type: "int", nullable: false).Annotation("Sqlserver:Identity", "1,1"),
                    PartTargetNo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BlockCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    UpdateData = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanHistoryID", x => x.ScanHistoryID);
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "tbUser");
            migrationBuilder.DropTable(name: "tbPartTarget");
            migrationBuilder.DropTable(name: "tbBlockCode");
            migrationBuilder.DropTable(name: "tbScanHistory");
        }
    }
}
