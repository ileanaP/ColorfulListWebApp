using AutoMapper;
using ColorfulListWebApp.Data.ViewModels;
using ColorfulListWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.Profiles
{
    public class ColorfulListProfile : Profile
    {
        public ColorfulListProfile()
        {
            CreateMap<ColorfulList, ColorfulListVM>();
        }
    }
}
