using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podium.Migrations
{
    public partial class PodiumCodeTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Lender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanType = table.Column<int>(type: "int", nullable: false),
                    LoanToValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MortgageRequirements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MortgageRequirements_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MortgageProposals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MortgageRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageProposals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MortgageProposals_MortgageRequirements_MortgageRequirementId",
                        column: x => x.MortgageRequirementId,
                        principalTable: "MortgageRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MortgageProposalProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MortgageProposalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageProposalProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MortgageProposalProduct_MortgageProposals_MortgageProposalId",
                        column: x => x.MortgageProposalId,
                        principalTable: "MortgageProposals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MortgageProposalProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InterestRate", "Lender", "LoanToValue", "LoanType" },
                values: new object[] { new Guid("105f98ce-8780-47a0-b503-53d9805a3da7"), 0.02m, "Bank A", 0.6m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InterestRate", "Lender", "LoanToValue", "LoanType" },
                values: new object[] { new Guid("9332c814-4362-4632-a5b9-2bd6f76a5f08"), 0.03m, "Bank B", 0.6m, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InterestRate", "Lender", "LoanToValue", "LoanType" },
                values: new object[] { new Guid("7f9337a8-4ccb-4aae-90d8-47f9eae022b0"), 0.04m, "Bank C", 0.9m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_MortgageProposalProduct_MortgageProposalId",
                table: "MortgageProposalProduct",
                column: "MortgageProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_MortgageProposalProduct_ProductId",
                table: "MortgageProposalProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MortgageProposals_MortgageRequirementId",
                table: "MortgageProposals",
                column: "MortgageRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_MortgageRequirements_ApplicantId",
                table: "MortgageRequirements",
                column: "ApplicantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MortgageProposalProduct");

            migrationBuilder.DropTable(
                name: "MortgageProposals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MortgageRequirements");

            migrationBuilder.DropTable(
                name: "Applicants");
        }
    }
}
