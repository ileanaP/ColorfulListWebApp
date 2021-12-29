using ColorfulListWebApp.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Controllers
{
    public class ListItemsController
    {
        private readonly IListItemsService _service;

        public ListItemsController(IListItemsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("ListItems/ListItemCheckedToggle/{id:int}/{checkedValue}")]
        public async Task<int> ListItemCheckedToggle(int id, string checkedValue)
        {
            var listItem = await _service.GetById(id);

            if (listItem == null) return 0;

            //var listItem = listItemDetails.Result;

            listItem.Checked = checkedValue == "true" ? true : false;

            await _service.Update(id, listItem);

            return 1;
        }
    }
}
