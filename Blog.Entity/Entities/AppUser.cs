using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("EBE97964-530D-435A-9118-5587025FFDEE");
        public Image Image{ get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
