using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"), "Admin Test", new DateTime(2023, 10, 25, 23, 29, 24, 21, DateTimeKind.Local).AddTicks(1023), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"), "Admin Test", new DateTime(2023, 10, 25, 23, 29, 24, 21, DateTimeKind.Local).AddTicks(1018), null, null, false, null, null, "ASP .NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), "Admin Test", new DateTime(2023, 10, 25, 23, 29, 24, 21, DateTimeKind.Local).AddTicks(2110), null, null, "images/vstest", "png", false, null, null },
                    { new Guid("ebe97964-530d-435a-9118-5587025ffdee"), "Admin Test", new DateTime(2023, 10, 25, 23, 29, 24, 21, DateTimeKind.Local).AddTicks(2107), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0809dfe2-eacf-4d6d-94a4-64d1fe417d30"), new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"), "Visual Studio Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 10, 25, 23, 29, 24, 20, DateTimeKind.Local).AddTicks(8504), null, null, new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("b1b43207-a328-4907-a140-14bf3409599b"), new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"), "Asp .Net Core Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.", "Admin Test", new DateTime(2023, 10, 25, 23, 29, 24, 20, DateTimeKind.Local).AddTicks(8485), null, null, new Guid("ebe97964-530d-435a-9118-5587025ffdee"), false, null, null, "Asp .Net Core Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0809dfe2-eacf-4d6d-94a4-64d1fe417d30"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b1b43207-a328-4907-a140-14bf3409599b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f927bbb3-6bad-4aa5-be30-a33c5631cafc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdd5e2e3-94d2-4cda-84b4-41952d45390c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a78494da-96ac-4e2f-8c78-bde4677cea26"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ebe97964-530d-435a-9118-5587025ffdee"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
