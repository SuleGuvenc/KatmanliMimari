using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class selfJoinForKategori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 19, 30, 45, 150, DateTimeKind.Local).AddTicks(7914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 25, 21, 14, 43, 493, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.AddColumn<int>(
                name: "UstKategoriId",
                table: "Kategoriler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Kategoriler_UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 25, 21, 14, 43, 493, DateTimeKind.Local).AddTicks(7875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 19, 30, 45, 150, DateTimeKind.Local).AddTicks(7914));
        }
    }
}
