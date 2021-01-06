using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyAndHappy.Migrations
{
    public partial class init : Migration
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
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
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
                name: "History",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Larder",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Larder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Larder_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PreprationTime = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false),
                    imageByteArray = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipe_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipe_AspNetUsers_MakerId",
                        column: x => x.MakerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alcohol",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alcohol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alcohol_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alcohol_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "breadAndNoodle",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breadAndNoodle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_breadAndNoodle_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_breadAndNoodle_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diary_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diary_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drink",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drink_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drink_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DryGood",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DryGood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DryGood_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DryGood_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FishAndSeafood",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishAndSeafood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishAndSeafood_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishAndSeafood_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fruit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fruit_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fruit_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Meat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meat_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meat_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Nut",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nut_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nut_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OilAndFat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilAndFat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OilAndFat_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilAndFat_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sauce",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sauce_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sauce_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Special",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Special_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Special_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Spice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spice_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spice_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vegetable",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    Chain = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PortionSize = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vegetable_Larder_Id",
                        column: x => x.Id,
                        principalTable: "Larder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vegetable_Recipe_Id",
                        column: x => x.Id,
                        principalTable: "Recipe",
                        principalColumn: "Id");
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
                name: "IX_Recipe_MakerId",
                table: "Recipe",
                column: "MakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alcohol");

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
                name: "breadAndNoodle");

            migrationBuilder.DropTable(
                name: "Diary");

            migrationBuilder.DropTable(
                name: "Drink");

            migrationBuilder.DropTable(
                name: "DryGood");

            migrationBuilder.DropTable(
                name: "FishAndSeafood");

            migrationBuilder.DropTable(
                name: "Fruit");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Meat");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Nut");

            migrationBuilder.DropTable(
                name: "OilAndFat");

            migrationBuilder.DropTable(
                name: "Sauce");

            migrationBuilder.DropTable(
                name: "Special");

            migrationBuilder.DropTable(
                name: "Spice");

            migrationBuilder.DropTable(
                name: "Vegetable");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Larder");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
