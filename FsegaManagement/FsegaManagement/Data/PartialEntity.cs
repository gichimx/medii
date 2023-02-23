namespace FsegaManagement.Data
{
    public abstract class PartialEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DataModificata { get; set; }
    }
}
