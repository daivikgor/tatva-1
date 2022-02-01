using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class CreateaccountController : Controller
    {
        public IActionResult createuser()
        {
            return View();
        }
    }
}
