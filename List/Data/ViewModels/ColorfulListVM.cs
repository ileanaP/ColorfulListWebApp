using ColorfulListWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.ViewModels
{
    public class ColorfulListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BgColor { get; set; }
        public string TextColor { get; set; }
        public string ItemBgColor { get; set; }
        public string ItemTextColor { get; set; }
        public IEnumerable<ListItemVM> ListItems { get; set; }
    }
}
