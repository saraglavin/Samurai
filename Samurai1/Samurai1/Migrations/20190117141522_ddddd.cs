using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class ddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvent_Battle_BattleId",
                table: "BattleEvent");

            migrationBuilder.DropIndex(
                name: "IX_BattleEvent_BattleId",
                table: "BattleEvent");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "BattleEvent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "BattleEvent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BattleEvent_BattleId",
                table: "BattleEvent",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvent_Battle_BattleId",
                table: "BattleEvent",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
