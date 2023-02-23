using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FsegaManagement.Models
{
    public class TipConcediuViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tip de Concediu")]

        [Required]
        public string Nume { get; set; }

        [Display(Name = "Numar de Zile")]
        [Required]
        public int ZileStandard { get; set; }
    }
}
