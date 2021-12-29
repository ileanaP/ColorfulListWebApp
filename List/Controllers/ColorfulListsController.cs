using AutoMapper;
using ColorfulListWebApp.Data.Services;
using ColorfulListWebApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Controllers
{
    public class ColorfulListsController : Controller
    {
        private readonly IColorfulListsService _service;
        private readonly IMapper _mapper;

        public ColorfulListsController(IColorfulListsService listService, IMapper mapper)
        {
            _service = listService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var colorfulLists = _service.GetAll();
            var colorfulListsVM = _mapper.Map<IEnumerable<ColorfulListVM>>(colorfulLists);

            return View(colorfulListsVM);
        }

        public async Task<IActionResult> View(int id)
        {
            var colorfulList = await _service.GetByIdWithListItems(id);

            if (colorfulList == null)
            {
                return View("NotFound");
            }

            var colorfulListVM = _mapper.Map<ColorfulListVM>(colorfulList);

            return View(colorfulListVM);
        }
    }
}
