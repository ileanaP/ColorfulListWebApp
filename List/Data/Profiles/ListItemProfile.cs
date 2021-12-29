using AutoMapper;
using ColorfulListWebApp.Data.ViewModels;
using ColorfulListWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.Profiles
{
    public class ListItemProfile : Profile
    {
        public ListItemProfile()
        {
            CreateMap<ListItem, ListItemVM>()
                .ForMember(dest =>
                    dest.CheckedStr,
                    opt => opt.MapFrom(src => (src.Checked ? "checked" : "") ))
                .ForMember(dest =>
                    dest.StyleStr,
                    opt => opt.MapFrom(src => "background-color:" + src.ColorfulList.ItemBgColor + ";color:" + src.ColorfulList.ItemTextColor ));
        }
    }
}
