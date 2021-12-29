using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ColorfulListWebApp.Data.Base;
using ColorfulListWebApp.Data.enums;

namespace ColorfulListWebApp.Models
{
    public class ColorfulList : IEntityBase
    {
        public ColorfulList()
        {
            DateCreated = DateTime.Now;
            BgColor = Color.DefaultBlue.Value;
            TextColor = Color.DefaultDarkBlue.Value;
            ItemBgColor = Color.White.Value;
            ItemTextColor = Color.DirtyBlue.Value;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string BgColor { get; set; }
        public string TextColor { get; set; }
        public string ItemBgColor { get; set; }
        public string ItemTextColor { get; set; }
        public IEnumerable<ListItem> ListItems { get; set; }
    }
}
