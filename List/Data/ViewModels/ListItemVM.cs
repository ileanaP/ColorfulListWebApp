using ColorfulListWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.ViewModels
{
    public class ListItemVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Checked { get; set; }
        public string CheckedStr { get; set; }
        public string StyleStr { get; set; }
    }
}
