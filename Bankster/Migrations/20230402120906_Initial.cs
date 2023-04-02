using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bankster.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sediste = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banke", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Polovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Forma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoviRacuna",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviRacuna", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rodjenje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Klijenti_Polovi_PolId",
                        column: x => x.PolId,
                        principalTable: "Polovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racuni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Broj = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    KontrolniBroj = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipRacunaId = table.Column<int>(type: "int", nullable: false),
                    KlijentId = table.Column<int>(type: "int", nullable: false),
                    BankaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racuni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racuni_Banke_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Banke",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racuni_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racuni_TipoviRacuna_TipRacunaId",
                        column: x => x.TipRacunaId,
                        principalTable: "TipoviRacuna",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transakcije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UplatilacRacunId = table.Column<int>(type: "int", nullable: false),
                    PrimalacRacunId = table.Column<int>(type: "int", nullable: false),
                    Iznos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hitno = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcije_Racuni_PrimalacRacunId",
                        column: x => x.PrimalacRacunId,
                        principalTable: "Racuni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transakcije_Racuni_UplatilacRacunId",
                        column: x => x.UplatilacRacunId,
                        principalTable: "Racuni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Banke",
                columns: new[] { "Id", "Kod", "Naziv", "Sediste" },
                values: new object[,]
                {
                    { 1, 105, "AIK BANKA, AD", "NIŠ" },
                    { 31, 908, "NARODNA BANKA SRBIJE", "BEOGRAD" },
                    { 30, 380, "MIRABANK, AD", "BEOGRAD" },
                    { 29, 375, "VTB BANKA, AD", "BEOGRAD" },
                    { 28, 370, "OPPORTUNITY BANKA, AD", "NOVI SAD" },
                    { 27, 365, "JUGOBANKA JUGBANKA, AD", "KOSOVSKA MITROVICA" },
                    { 26, 360, "DUNAV BANKA, AD", "BEOGRAD" },
                    { 25, 355, "VOJVOĐANSKA BANKA, AD", "NOVI SAD" },
                    { 24, 340, "ERSTE BANK, AD", "NOVI SAD" },
                    { 23, 330, "RBA SRBIJA, AD", "NOVI SAD" },
                    { 22, 325, "OTP BANKA SRBIJA, AD", "NOVI SAD" },
                    { 21, 310, "NLB BANKA, AD", "BEOGRAD" },
                    { 20, 295, "SRPSKA BANKA, AD", "BEOGRAD" },
                    { 18, 275, "SOCIETE GENERALE BANKA SRBIJA, AD", "BEOGRAD" },
                    { 17, 265, "RAIFFEISEN BANKA, AD", "BEOGRAD" },
                    { 19, 285, "SBERBANK SRBIJA, AD", "BEOGRAD" },
                    { 15, 240, "FINDOMESTIC BANKA, AD", "BEOGRAD" },
                    { 2, 115, "TELENOR BANKA, AD", "BEOGRAD" },
                    { 3, 125, "PIRAEUS BANK, AD", "BEOGRAD" },
                    { 4, 145, "MARFIN BANK, AD", "BEOGRAD" },
                    { 5, 150, "KBM BANKA, AD", "KRAGUJEVAC" },
                    { 16, 250, "EUROBANK, AD", "BEOGRAD" },
                    { 7, 160, "BANCA INTESA, AD", "BEOGRAD" },
                    { 8, 165, "HYPO ALPE – ADRIA – BANK, AD", "BEOGRAD" },
                    { 6, 155, "ČAČANSKA BANKA, AD", "ČAČAK" },
                    { 10, 180, "ALPHA BANK SRBIJA, AD", "BEOGRAD" },
                    { 11, 190, "JUBMES BANKA, AD", "BEOGRAD" },
                    { 12, 200, "BANKA POŠTANSKA ŠTEDIONICA, AD", "BEOGRAD" },
                    { 13, 205, "KOMERCIJALNA BANKA, AD", "BEOGRAD" },
                    { 14, 220, "PROCREDIT BANK, AD", "BEOGRAD" },
                    { 9, 170, "UNICREDIT BANK SRBIJA, AD", "BEOGRAD" }
                });

            migrationBuilder.InsertData(
                table: "Polovi",
                columns: new[] { "Id", "Forma", "Naziv" },
                values: new object[,]
                {
                    { 1, "G-din", "Muski" },
                    { 2, "G-dja", "Zenski" },
                    { 3, "G-din/G-dja", "Neizjasnjen" }
                });

            migrationBuilder.InsertData(
                table: "TipoviRacuna",
                columns: new[] { "Id", "Tip" },
                values: new object[,]
                {
                    { 3, "Kreditni" },
                    { 1, "Tekuci" },
                    { 2, "Devizni" },
                    { 4, "Stedni" }
                });

            migrationBuilder.InsertData(
                table: "Klijenti",
                columns: new[] { "Id", "Ime", "PolId", "Prezime", "Rodjenje" },
                values: new object[,]
                {
                    { 1, "Bojan", 1, "Adzic", new DateTime(1981, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pera", 1, "Peric", new DateTime(1976, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Petra", 2, "Petric", new DateTime(1964, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Jelena", 2, "Jelic", new DateTime(1998, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Vanja", 3, "Bulic", new DateTime(2000, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Racuni",
                columns: new[] { "Id", "BankaId", "Broj", "KlijentId", "KontrolniBroj", "Saldo", "TipRacunaId" },
                values: new object[,]
                {
                    { 1, 8, "0000034567143", 1, 97, 34584.58m, 1 },
                    { 3, 25, "1400560700343", 1, 22, 13584.58m, 2 },
                    { 4, 15, "5671003400043", 2, 54, 4584.39m, 2 },
                    { 5, 13, "0500670013443", 3, 79, 131984.38m, 4 },
                    { 2, 21, "1030506040743", 4, 57, 86344.22m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Transakcije",
                columns: new[] { "Id", "Datum", "Hitno", "Iznos", "PrimalacRacunId", "UplatilacRacunId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2139.38m, 3, 1 },
                    { 3, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1239.88m, 1, 4 },
                    { 4, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2319.17m, 5, 3 },
                    { 2, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3912.29m, 2, 5 },
                    { 5, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3192.01m, 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_PolId",
                table: "Klijenti",
                column: "PolId");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_BankaId",
                table: "Racuni",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_KlijentId",
                table: "Racuni",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_TipRacunaId",
                table: "Racuni",
                column: "TipRacunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcije_PrimalacRacunId",
                table: "Transakcije",
                column: "PrimalacRacunId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcije_UplatilacRacunId",
                table: "Transakcije",
                column: "UplatilacRacunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Transakcije");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Racuni");

            migrationBuilder.DropTable(
                name: "Banke");

            migrationBuilder.DropTable(
                name: "Klijenti");

            migrationBuilder.DropTable(
                name: "TipoviRacuna");

            migrationBuilder.DropTable(
                name: "Polovi");
        }
    }
}
