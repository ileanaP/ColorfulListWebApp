using ColorfulListWebApp.Data.Base;
using ColorfulListWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.Services
{
    public interface IColorfulListsService : IEntityBaseRepository<ColorfulList>
    {
        public Task<ColorfulList> GetByIdWithListItems(int id);
    }
}
