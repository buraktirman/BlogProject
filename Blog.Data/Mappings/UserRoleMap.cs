using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("A0D7038F-F97E-4B21-9C4A-488418D1B729"),
                RoleId = Guid.Parse("53499486-F505-449F-A7BD-86FD41B77552")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("2CADBE18-34FC-457F-B398-D5AE01A4E0DE"),
                RoleId = Guid.Parse("100774B4-7A30-40CE-9026-62D9197EAC09")
            });
        }
    }
}
