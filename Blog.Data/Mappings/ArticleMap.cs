using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp .Net Core Deneme Makalesi 1",
                Content = "Asp .Net Core Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.",
                ViewCount = 15,
                CategoryId = Guid.Parse("FDD5E2E3-94D2-4CDA-84B4-41952D45390C"),
                ImageId = Guid.Parse("EBE97964-530D-435A-9118-5587025FFDEE"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Content = "Visual Studio Nullam dui lorem, ultrices nec finibus ac, efficitur id nisi. Fusce lobortis tempus ligula a lacinia. Sed commodo augue eget diam fringilla accumsan. Fusce ac eros tristique, sagittis erat et, finibus arcu. Aenean cursus varius purus laoreet aliquam. Duis semper, libero et vulputate gravida, lacus ante egestas mauris, vel laoreet nulla nisl ut orci. Mauris placerat eros non libero consequat consectetur. Vivamus sed efficitur eros. Curabitur mollis tellus a hendrerit mattis. Vestibulum malesuada ullamcorper urna, sed malesuada ante. Pellentesque tempus augue ac varius vestibulum. Vestibulum tortor arcu, condimentum in auctor in, faucibus a orci. Praesent pharetra dolor in sollicitudin fermentum. Proin lobortis, ante volutpat pellentesque lacinia, purus felis commodo nisl, ac sollicitudin purus purus vitae velit. Nullam faucibus nunc gravida elit efficitur, a facilisis ex malesuada.\r\n\r\nAenean nec nulla ipsum. Nunc laoreet nunc at est lobortis, quis convallis lacus consequat. In vel felis sem. Vivamus arcu quam, pharetra vel ornare non, lacinia quis magna. Fusce pulvinar ante tempus ante pharetra finibus. Aenean consectetur leo quam, sit amet euismod magna ornare in. Vestibulum turpis nisi, tristique nec dolor non, dapibus molestie tortor. Maecenas molestie non purus venenatis scelerisque. Aenean aliquet orci justo, ut consequat eros vulputate at. Nulla ultricies elit felis, id pulvinar mauris pellentesque ac. Proin dictum vehicula volutpat. Sed lobortis vitae dui ac laoreet. Fusce imperdiet ultrices hendrerit.\r\n\r\nMaecenas lacinia et nisi id pharetra. Phasellus nisi nisl, eleifend in ultrices id, pellentesque at nisl. Fusce sit amet ante vitae diam pellentesque aliquet eget id orci. Morbi nulla ipsum, porta sit amet varius eu, ullamcorper id enim. Duis mi tellus, eleifend sed fermentum cursus, convallis non enim. Phasellus at mi ut tortor molestie fringilla vitae euismod odio. Ut consequat vulputate ligula nec lobortis. Vestibulum aliquet, orci vitae tincidunt pretium, tellus augue varius risus, in lobortis purus ligula interdum mauris. Vivamus at purus at diam varius dictum et ut nisi.",
                ViewCount = 15,
                CategoryId = Guid.Parse("F927BBB3-6BAD-4AA5-BE30-A33C5631CAFC"),
                ImageId = Guid.Parse("A78494DA-96AC-4E2F-8C78-BDE4677CEA26"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }

            );
        }
    }
}
