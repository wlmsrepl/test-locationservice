using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.LocationService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationRecords",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Altitude = table.Column<float>(type: "float4", nullable: false),
                    Latitude = table.Column<float>(type: "float4", nullable: false),
                    Longitude = table.Column<float>(type: "float4", nullable: false),
                    MemberID = table.Column<Guid>(type: "uuid", nullable: false),
                    Timestamp = table.Column<long>(type: "int8", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationRecords", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationRecords");
        }
    }
}
