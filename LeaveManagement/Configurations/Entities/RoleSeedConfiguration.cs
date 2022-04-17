using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                });
        }
    }
}