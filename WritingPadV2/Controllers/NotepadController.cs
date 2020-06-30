using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritingPadV2.Data;
using WritingPadV2.Models;
using WritingPadV2.Services;

namespace WritingPadV2.Controllers
{
    public class NotepadController : Controller
    {
        private readonly INotepadItemServis itemService;

        public NotepadController(INotepadItemServis _itemService)//constructor injection
        {
            itemService = _itemService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<NotepadItem> items = await itemService.GetIncompleteItemsAsync();

            NotepadViewModel notepadViewModel = new NotepadViewModel();
            notepadViewModel.Items = items;
            return View(notepadViewModel);
        }
    }
}
