using System.ComponentModel.DataAnnotations.Schema;

namespace FsegaManagement.Data
{
    public class ConcediuAlocat : PartialEntity
    {
        public int NumarZile { get; set; }

        [ForeignKey("TipConcediuId")]
        public TipConcediu TipConcediu { get; set; }
        public int TipConcediuId { get; set; }

        public string AngajatId { get; set; }
    }
}
