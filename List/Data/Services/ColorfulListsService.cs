using ColorfulListWebApp.Data.Base;
using ColorfulListWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.Services
{
    public class ColorfulListsService : EntityBaseRepository<ColorfulList>, IColorfulListsService
    {
        private readonly AppDbContext _context;
        public ColorfulListsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ColorfulList> GetByIdWithListItems(int id)
        {
            var colorfulList = await _context.ColorfulLists
                .Include(l => l.ListItems)
                .FirstOrDefaultAsync(n => n.Id == id);

            return colorfulList;
        }
    }
}
