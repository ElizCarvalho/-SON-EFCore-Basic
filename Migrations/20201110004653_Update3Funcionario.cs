﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class Update3Funcionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Funcionarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Funcionarios");
        }
    }
}
