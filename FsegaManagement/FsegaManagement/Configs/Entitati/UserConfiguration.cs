using FsegaManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FsegaManagement.Configs.Entitati
{
    public class UserConfiguration : IEntityTypeConfiguration<Angajat>
    {
        public void Configure(EntityTypeBuilder<Angajat> builder)
        {
            var hash = new PasswordHasher<Angajat>();
            builder.HasData(
                new Angajat
                {
                    Id = "20d1c8e9-ca29-4244-9b86-9735008371f8",
                    Email = "igabriel76@yahoo.com",
                    NormalizedEmail = "IGABRIEL76@YAHOO.COM",
                    NormalizedUserName = "IGABRIEL76@YAHOO.COM",
                    UserName = "IGABRIEL76@YAHOO.COM",
                    Nume = "Ichim",
                    Prenume = "Gabriel",
                    PasswordHash = hash.HashPassword(null, "P@@ssword4"),
                    EmailConfirmed = true
                },
                new Angajat
                {
                    Id = "f4fd1c8e9-ca29-4244-9b86-9735008f31f8",
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    NormalizedUserName = "USER@GMAIL.COM",
                    UserName = "USER@GMAIL.COM",
                    Nume = "User",
                    Prenume = "User",
                    PasswordHash = hash.HashPassword(null, "P@@ssword5"),
                    EmailConfirmed = true
                }
                );
        }
    }
}