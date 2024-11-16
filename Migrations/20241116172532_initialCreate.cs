using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nama = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TanggalLahir = table.Column<DateTime>(name: "Tanggal Lahir", type: "TEXT", nullable: false),
                    Domisili = table.Column<string>(type: "TEXT", nullable: true),
                    Alamat = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    dataByte = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Education_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TingkatPendidikan = table.Column<int>(name: "Tingkat Pendidikan", type: "INTEGER", nullable: true),
                    InstansiPendidikan = table.Column<string>(name: "Instansi Pendidikan", type: "TEXT", nullable: true),
                    Lembaga = table.Column<string>(type: "TEXT", nullable: true),
                    Mulai = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Lulus = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Profile_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Education_Id);
                    table.ForeignKey(
                        name: "FK_Education_Profile_Profile_Id",
                        column: x => x.Profile_Id,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Project_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NamaProject = table.Column<string>(name: "Nama Project", type: "TEXT", nullable: true),
                    Deskripsi = table.Column<string>(type: "TEXT", nullable: true),
                    WaktuMulai = table.Column<DateTime>(name: "Waktu Mulai", type: "TEXT", nullable: true),
                    WaktuSelesai = table.Column<DateTime>(name: "Waktu Selesai", type: "TEXT", nullable: true),
                    Profile_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Project_Id);
                    table.ForeignKey(
                        name: "FK_Project_Profile_Profile_Id",
                        column: x => x.Profile_Id,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_Profile_Id",
                table: "Education",
                column: "Profile_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Profile_Id",
                table: "Project",
                column: "Profile_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
