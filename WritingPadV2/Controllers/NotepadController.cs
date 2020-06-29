using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WritingPadV2.Controllers
{
    public class NotepadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
