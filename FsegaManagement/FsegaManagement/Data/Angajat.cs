using Microsoft.AspNetCore.Identity;

namespace FsegaManagement.Data
{
    public class Angajat : IdentityUser
    {
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public string? TaxId { get; set; }
        public DateTime ZiDeNastere { get; set; }
        public DateTime DataAngajare { get; set; }
    }
}
