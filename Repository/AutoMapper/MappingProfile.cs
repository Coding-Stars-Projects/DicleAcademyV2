using AutoMapper;
using Entities.Models;
using Entities.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<AboutUsDto, AboutUs>();
        }
    }
}
