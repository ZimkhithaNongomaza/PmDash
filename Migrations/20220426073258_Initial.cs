using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PmDash.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AquaDevelopments",
                columns: table => new
                {
                    InvestorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Lease = table.Column<string>(nullable: true),
                    DateToBeSigned = table.Column<DateTime>(nullable: false),
                    Asset = table.Column<string>(nullable: true),
                    InvestmentValue = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TeamMembers = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AquaDevelopments", x => x.InvestorID);
                });

            migrationBuilder.CreateTable(
                name: "Desalinations",
                columns: table => new
                {
                    InvestorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Lease = table.Column<string>(nullable: true),
                    DateToBeSigned = table.Column<DateTime>(nullable: false),
                    Asset = table.Column<string>(nullable: true),
                    InvestmentValue = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TeamMembers = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desalinations", x => x.InvestorID);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Pdd = table.Column<string>(nullable: true),
                    BSA = table.Column<string>(nullable: true),
                    Eq = table.Column<string>(nullable: true),
                    FundingApproval = table.Column<string>(nullable: true),
                    Investment = table.Column<int>(nullable: false),
                    FeesAgreement = table.Column<string>(nullable: true),
                    Prc = table.Column<string>(nullable: true),
                    Rmc = table.Column<string>(nullable: true),
                    Frc = table.Column<string>(nullable: true),
                    Exma = table.Column<string>(nullable: true),
                    Converted = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "Investors",
                columns: table => new
                {
                    InvestorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Lease = table.Column<string>(nullable: true),
                    DateToBeSigned = table.Column<DateTime>(nullable: false),
                    Asset = table.Column<string>(nullable: true),
                    InvestmentValue = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    TeamMembers = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investors", x => x.InvestorID);
                });

            migrationBuilder.CreateTable(
                name: "Others",
                columns: table => new
                {
                    InvestorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Lease = table.Column<string>(nullable: true),
                    DateToBeSigned = table.Column<DateTime>(nullable: false),
                    Asset = table.Column<string>(nullable: true),
                    InvestmentValue = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TeamMembers = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Others", x => x.InvestorID);
                });

            migrationBuilder.CreateTable(
                name: "WildCoasts",
                columns: table => new
                {
                    InvestorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Lease = table.Column<string>(nullable: true),
                    DateToBeSigned = table.Column<DateTime>(nullable: false),
                    Asset = table.Column<string>(nullable: true),
                    InvestmentValue = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TeamMembers = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WildCoasts", x => x.InvestorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AquaDevelopments");

            migrationBuilder.DropTable(
                name: "Desalinations");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Investors");

            migrationBuilder.DropTable(
                name: "Others");

            migrationBuilder.DropTable(
                name: "WildCoasts");
        }
    }
}
