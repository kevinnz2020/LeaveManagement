using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",/// same Id from AspNetUsers
                    Email = "kevin@gmail.com",
                    NormalizedEmail = "KEVIN@GMAIL.COM",
                    NormalizedUserName = "KEVIN@GMAIL.COM",
                    UserName = "kevin@gmail.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null,"P@ssword1"),
                    EmailConfirmed = true
                });

        }
    }
}