using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Source.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "challenge",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Created_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_challenge", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Created_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "acceleration",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Created_At = table.Column<DateTime>(nullable: false),
                    ChallengeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acceleration", x => x.id);
                    table.ForeignKey(
                        name: "FK_acceleration_challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "challenge",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "submission",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Challenge_Id = table.Column<int>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    Created_At = table.Column<DateTime>(nullable: false),
                    ChallengeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submission", x => x.id);
                    table.ForeignKey(
                        name: "FK_submission_challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "challenge",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "candidate",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Acceleration_Id = table.Column<int>(nullable: false),
                    Company_Id = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Created_At = table.Column<DateTime>(nullable: false),
                    AccelerationId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate", x => x.id);
                    table.ForeignKey(
                        name: "FK_candidate_acceleration_AccelerationId",
                        column: x => x.AccelerationId,
                        principalTable: "acceleration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidate_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_acceleration_ChallengeId",
                table: "acceleration",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_AccelerationId",
                table: "candidate",
                column: "AccelerationId");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_CompanyId",
                table: "candidate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_submission_ChallengeId",
                table: "submission",
                column: "ChallengeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidate");

            migrationBuilder.DropTable(
                name: "submission");

            migrationBuilder.DropTable(
                name: "acceleration");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "challenge");
        }
    }
}
