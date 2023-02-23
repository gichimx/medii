using AutoMapper;
using FsegaManagement.Data;
using FsegaManagement.Models;

namespace FsegaManagement.Configs
{
    public class ConfigMapper : Profile
    {
     public ConfigMapper() 
        {
            CreateMap<TipConcediu, TipConcediuViewModel>().ReverseMap();
        }
    }
}
