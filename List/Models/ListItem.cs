using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ColorfulListWebApp.Data.Base;
using ColorfulListWebApp.Data.enums;

namespace ColorfulListWebApp.Models
{
    public class ListItem : IEntityBase
    {
        public ListItem()
        {
            Checked = false;
        }

        public int Id { get; set; }
        public int ListId { get; set; }
        [ForeignKey("ListId")]
        public ColorfulList ColorfulList { get; set; }
        public string Text { get; set; }
        public bool Checked { get; set; }
    }
}
