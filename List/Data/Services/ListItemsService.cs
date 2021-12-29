using ColorfulListWebApp.Data.Base;
using ColorfulListWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.Services
{
    public class ListItemsService : EntityBaseRepository<ListItem>, IListItemsService
    {
        private AppDbContext _context;

        public ListItemsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task UpdateListItemCheckedToggle(int id, bool checkedValue)
        {
            throw new NotImplementedException();
        }
    }
}
