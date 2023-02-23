using FsegaManagement.Data;
using FsegaManagement.Interfaces;

namespace FsegaManagement.Repos
{
    public class ManagementTypeRepo : GenericRepo<TipConcediu>, IManagementTypeRepo
    {
        public ManagementTypeRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}