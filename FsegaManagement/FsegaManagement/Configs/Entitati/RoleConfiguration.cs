using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FsegaManagement.Configs.Entitati

{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "wefwef2-f2fwfe2f2-fwf23-f23f32f",
                    Name= "Admin",
                    NormalizedName= "ADMIN"
                },
                new IdentityRole
                {
                    Id = "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}