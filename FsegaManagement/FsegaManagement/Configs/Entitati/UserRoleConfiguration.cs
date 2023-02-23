using FsegaManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Policy;

namespace FsegaManagement.Configs.Entitati
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "wefwef2-f2fwfe2f2-fwf23-f23f32f",
                    UserId = "20d1c8e9-ca29-4244-9b86-9735008371f8"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f",
                    UserId = "f4fd1c8e9-ca29-4244-9b86-9735008f31f8"
                }
                );
        }
    }
}