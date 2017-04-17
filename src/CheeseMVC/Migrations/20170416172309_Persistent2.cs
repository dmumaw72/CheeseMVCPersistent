using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeseMVC.Migrations
{
    public partial class Persistent2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cheeses_Categories_CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.DropIndex(
                name: "IX_Cheeses_CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.DropColumn(
                name: "CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cheeses");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Cheeses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cheeses_CategoryID",
                table: "Cheeses",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cheeses_Categories_CategoryID",
                table: "Cheeses",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cheeses_Categories_CategoryID",
                table: "Cheeses");

            migrationBuilder.DropIndex(
                name: "IX_Cheeses_CategoryID",
                table: "Cheeses");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Cheeses");

            migrationBuilder.AddColumn<int>(
                name: "CheeseCategoryID",
                table: "Cheeses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Cheeses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cheeses_CheeseCategoryID",
                table: "Cheeses",
                column: "CheeseCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cheeses_Categories_CheeseCategoryID",
                table: "Cheeses",
                column: "CheeseCategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
