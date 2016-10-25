using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using MVCTask1.BLL.DTO;
using MVCTask1.DAL;

namespace MVCTask1.BLL.Mapping
{
    public class DomainToViewMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Game, GameDTO>().ReverseMap();
        }
    }
}
