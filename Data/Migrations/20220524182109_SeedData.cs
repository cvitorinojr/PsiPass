using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserSpecialty",
                columns: new[] { "Id", "CreateAt", "Description", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8274), "Educacional", null },
                    { 2, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8276), "Jurídica", null },
                    { 3, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8277), "Esportiva", null },
                    { 4, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8279), "Hospitalar", null },
                    { 5, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8280), "Social", null },
                    { 6, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8282), "Neuropsicologia", null },
                    { 7, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8284), "Clínica", null },
                    { 8, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8285), "Idoso", null },
                    { 9, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8287), "Trânsito", null },
                    { 10, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8288), "Comportamental", null },
                    { 11, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8290), "Psicopedagogia", null },
                    { 12, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8291), "Avaliação Psicológica", null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "Id", "CreateAt", "Description", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8047), "Paciente", null },
                    { 2, new DateTime(2022, 5, 24, 15, 21, 9, 628, DateTimeKind.Local).AddTicks(8049), "Profissional", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserSpecialty",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
