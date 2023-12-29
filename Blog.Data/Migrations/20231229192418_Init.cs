using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("100774b4-7a30-40ce-9026-62d9197eac09"), "536674bf-4c12-419a-95d4-19b0f462a43b", "Admin", "ADMIN" },
                    { new Guid("53499486-f505-449f-a7bd-86fd41b77552"), "80a430a5-7426-4fa5-b276-700224469742", "SuperAdmin", "SUPERADMIN" },
                    { new Guid("e3b84413-3b6c-4e5b-99bb-312b06def02c"), "704d0fe0-0904-4620-a1e8-d5e64b1e89dc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"), "Admin Test", new DateTime(2023, 12, 29, 22, 24, 18, 63, DateTimeKind.Local).AddTicks(8699), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"), "Admin Test", new DateTime(2023, 12, 29, 22, 24, 18, 63, DateTimeKind.Local).AddTicks(8688), null, null, false, null, null, "ASP .NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), "Admin Test", new DateTime(2023, 12, 29, 22, 24, 18, 63, DateTimeKind.Local).AddTicks(9485), null, null, "images/vstest", "png", false, null, null },
                    { new Guid("ebe97964-530d-435a-9118-5587025ffdee"), "Admin Test", new DateTime(2023, 12, 29, 22, 24, 18, 63, DateTimeKind.Local).AddTicks(9481), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cadbe18-34fc-457f-b398-d5ae01a4e0de"), 0, "2952a2a3-1d3a-4ea3-aa16-d240e7dcda28", "admin@gmail.com", false, "Admin", new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEASVqsfpvVI3IryF76KKgacSqqLhlILzV4iMWDoapgHs1LTFL0WzcCN+1yEo7qBCrA==", "+905439999988", false, "9c44f7fc-3e7b-4b5b-89f6-5b6c6361ba64", false, "admin@gmail.com" },
                    { new Guid("a0d7038f-f97e-4b21-9c4a-488418d1b729"), 0, "e7b8ee98-9c3b-42f2-86f4-bfce1af7f21c", "superadmin@gmail.com", true, "Burak", new Guid("ebe97964-530d-435a-9118-5587025ffdee"), "Tırman", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEG8x+d34H++RQU6mtHiOmBciK93/q1mwWM/WUXKOhrYIJ1OfRdjO+2cy6ybQl/SyHg==", "+905439999999", true, "a19c0914-5d34-4fb5-8973-2f823fea3fa7", false, "superadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0e7d5490-417f-4829-a0c6-8f4a2337c500"), new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"), "Asp .Net Core Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 12, 29, 22, 24, 18, 63, DateTimeKind.Local).AddTicks(7585), null, null, new Guid("ebe97964-530d-435a-9118-5587025ffdee"), false, null, null, "Asp .Net Core Deneme Makalesi 1", new Guid("a0d7038f-f97e-4b21-9c4a-488418d1b729"), 15 },
                    { new Guid("71f295e1-d75e-4dee-94c3-0559f4c83997"), new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"), "Visual Studio Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 12, 29, 22, 24, 18, 63, DateTimeKind.Local).AddTicks(7592), null, null, new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("2cadbe18-34fc-457f-b398-d5ae01a4e0de"), 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("100774b4-7a30-40ce-9026-62d9197eac09"), new Guid("2cadbe18-34fc-457f-b398-d5ae01a4e0de") },
                    { new Guid("53499486-f505-449f-a7bd-86fd41b77552"), new Guid("a0d7038f-f97e-4b21-9c4a-488418d1b729") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

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
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
