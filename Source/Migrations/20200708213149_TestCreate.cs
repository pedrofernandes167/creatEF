using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Source.Migrations
{
    public partial class TestCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_acceleration_challenge_ChallengeId",
                table: "acceleration");

            migrationBuilder.DropForeignKey(
                name: "FK_candidate_acceleration_AccelerationId",
                table: "candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_candidate_company_CompanyId",
                table: "candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_submission_challenge_ChallengeId",
                table: "submission");

            migrationBuilder.DropIndex(
                name: "IX_submission_ChallengeId",
                table: "submission");

            migrationBuilder.DropIndex(
                name: "IX_candidate_AccelerationId",
                table: "candidate");

            migrationBuilder.DropIndex(
                name: "IX_candidate_CompanyId",
                table: "candidate");

            migrationBuilder.DropIndex(
                name: "IX_acceleration_ChallengeId",
                table: "acceleration");

            migrationBuilder.DropColumn(
                name: "ChallengeId",
                table: "submission");

            migrationBuilder.DropColumn(
                name: "AccelerationId",
                table: "candidate");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "candidate");

            migrationBuilder.DropColumn(
                name: "ChallengeId",
                table: "acceleration");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "submission",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "company",
                newName: "Company_Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "challenge",
                newName: "Challenge_Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "candidate",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "acceleration",
                newName: "Acceleration_Id");

            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "submission",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "candidate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Challenge_Id",
                table: "acceleration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Full_Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Created_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.User_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_submission_Challenge_Id",
                table: "submission",
                column: "Challenge_Id");

            migrationBuilder.CreateIndex(
                name: "IX_submission_User_Id",
                table: "submission",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_Acceleration_Id",
                table: "candidate",
                column: "Acceleration_Id");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_Company_Id",
                table: "candidate",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_User_Id",
                table: "candidate",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_acceleration_Challenge_Id",
                table: "acceleration",
                column: "Challenge_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_acceleration_challenge_Challenge_Id",
                table: "acceleration",
                column: "Challenge_Id",
                principalTable: "challenge",
                principalColumn: "Challenge_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_candidate_acceleration_Acceleration_Id",
                table: "candidate",
                column: "Acceleration_Id",
                principalTable: "acceleration",
                principalColumn: "Acceleration_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_candidate_company_Company_Id",
                table: "candidate",
                column: "Company_Id",
                principalTable: "company",
                principalColumn: "Company_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_candidate_user_User_Id",
                table: "candidate",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_submission_challenge_Challenge_Id",
                table: "submission",
                column: "Challenge_Id",
                principalTable: "challenge",
                principalColumn: "Challenge_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_submission_user_User_Id",
                table: "submission",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_acceleration_challenge_Challenge_Id",
                table: "acceleration");

            migrationBuilder.DropForeignKey(
                name: "FK_candidate_acceleration_Acceleration_Id",
                table: "candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_candidate_company_Company_Id",
                table: "candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_candidate_user_User_Id",
                table: "candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_submission_challenge_Challenge_Id",
                table: "submission");

            migrationBuilder.DropForeignKey(
                name: "FK_submission_user_User_Id",
                table: "submission");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropIndex(
                name: "IX_submission_Challenge_Id",
                table: "submission");

            migrationBuilder.DropIndex(
                name: "IX_submission_User_Id",
                table: "submission");

            migrationBuilder.DropIndex(
                name: "IX_candidate_Acceleration_Id",
                table: "candidate");

            migrationBuilder.DropIndex(
                name: "IX_candidate_Company_Id",
                table: "candidate");

            migrationBuilder.DropIndex(
                name: "IX_candidate_User_Id",
                table: "candidate");

            migrationBuilder.DropIndex(
                name: "IX_acceleration_Challenge_Id",
                table: "acceleration");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "submission");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "candidate");

            migrationBuilder.DropColumn(
                name: "Challenge_Id",
                table: "acceleration");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "submission",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Company_Id",
                table: "company",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Challenge_Id",
                table: "challenge",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "candidate",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Acceleration_Id",
                table: "acceleration",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "ChallengeId",
                table: "submission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccelerationId",
                table: "candidate",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "candidate",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChallengeId",
                table: "acceleration",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_submission_ChallengeId",
                table: "submission",
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
                name: "IX_acceleration_ChallengeId",
                table: "acceleration",
                column: "ChallengeId");

            migrationBuilder.AddForeignKey(
                name: "FK_acceleration_challenge_ChallengeId",
                table: "acceleration",
                column: "ChallengeId",
                principalTable: "challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_candidate_acceleration_AccelerationId",
                table: "candidate",
                column: "AccelerationId",
                principalTable: "acceleration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_candidate_company_CompanyId",
                table: "candidate",
                column: "CompanyId",
                principalTable: "company",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_submission_challenge_ChallengeId",
                table: "submission",
                column: "ChallengeId",
                principalTable: "challenge",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
