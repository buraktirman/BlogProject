using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2c64fb72-198b-4a68-86e1-6961d04002ee"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("596137cf-21f0-4bce-9097-340e60e56a4c"));

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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b193231f-4e41-4237-8354-590e515028a8"), new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"), "Asp .Net Core Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 12, 28, 0, 32, 42, 511, DateTimeKind.Local).AddTicks(508), null, null, new Guid("ebe97964-530d-435a-9118-5587025ffdee"), false, null, null, "Asp .Net Core Deneme Makalesi 1", 15 },
                    { new Guid("cc80638f-6599-4a46-9a93-0ee161b417eb"), new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"), "Visual Studio Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 12, 28, 0, 32, 42, 511, DateTimeKind.Local).AddTicks(517), null, null, new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("100774b4-7a30-40ce-9026-62d9197eac09"), "28a54942-79f0-42e5-abfa-73b24e88f1c1", "Admin", "ADMIN" },
                    { new Guid("53499486-f505-449f-a7bd-86fd41b77552"), "6d7051b3-6697-49ea-b07d-64e1a9dc768f", "SuperAdmin", "SUPERADMIN" },
                    { new Guid("e3b84413-3b6c-4e5b-99bb-312b06def02c"), "c440620c-d1e8-4c36-87f0-8d463b5321d7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cadbe18-34fc-457f-b398-d5ae01a4e0de"), 0, "fea69963-9f91-4270-9702-8581e7374f0d", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEGiCST84tzKlhNycKF98kZttBnOwtQnriWeSiISvNGZ4Sl0iLaNlgAjKoPW7NzNgEg==", "+905439999988", false, "fdde710c-cadd-4dd5-9493-7a4752628fb2", false, "admin@gmail.com" },
                    { new Guid("a0d7038f-f97e-4b21-9c4a-488418d1b729"), 0, "d5ed3235-ddfc-4735-87f7-5a1ed45837cc", "superadmin@gmail.com", true, "Burak", "Tırman", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAECP+xmbFA2sHZ7dDotsUvOr/TmSj6X572tE6/Zvh44fwMV5D7JRlncgX5XcMYfje6w==", "+905439999999", true, "5ee5b1cd-3f8f-495b-9ecb-7e8d00b67242", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 28, 0, 32, 42, 511, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 28, 0, 32, 42, 511, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 28, 0, 32, 42, 511, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ebe97964-530d-435a-9118-5587025ffdee"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 28, 0, 32, 42, 511, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("100774b4-7a30-40ce-9026-62d9197eac09"), new Guid("2cadbe18-34fc-457f-b398-d5ae01a4e0de") },
                    { new Guid("53499486-f505-449f-a7bd-86fd41b77552"), new Guid("a0d7038f-f97e-4b21-9c4a-488418d1b729") }
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
        }

        /// <inheritdoc />
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b193231f-4e41-4237-8354-590e515028a8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cc80638f-6599-4a46-9a93-0ee161b417eb"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2c64fb72-198b-4a68-86e1-6961d04002ee"), new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"), "Visual Studio Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 12, 17, 13, 12, 46, 472, DateTimeKind.Local).AddTicks(4598), null, null, new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("596137cf-21f0-4bce-9097-340e60e56a4c"), new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"), "Asp .Net Core Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 12, 17, 13, 12, 46, 472, DateTimeKind.Local).AddTicks(4593), null, null, new Guid("ebe97964-530d-435a-9118-5587025ffdee"), false, null, null, "Asp .Net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 12, 46, 472, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 12, 46, 472, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 12, 46, 472, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ebe97964-530d-435a-9118-5587025ffdee"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 17, 13, 12, 46, 472, DateTimeKind.Local).AddTicks(6218));
        }
    }
}
