using Helperland.Data;
using Helperland.Models;
using Helperland.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class becomehelperController : Controller
    {
        private string message;
        private readonly HelperlandContext _HelperlandContext;

        public becomehelperController(HelperlandContext HelperlandContext)
        {
            _HelperlandContext = HelperlandContext;
        }

        [HttpGet]
        public IActionResult BecomeHelper()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BecomeHelper(createviewmodel model)
        {
            if (ModelState.IsValid)
            {
                var isExist = IsEmailExist(model.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist");
                    return View(model);
                }
                var user = new User
                {
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Mobile = model.Mobile,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Password = Crypto.Hash(model.Password),
                    UserTypeId = 1,
                };
                _HelperlandContext.Add(user);
                _HelperlandContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                message = "Invalid Request";
            }
            return View(model);
        }

        [NonAction]
        public bool IsEmailExist(string email)
        {
            using (HelperlandContext dc = new HelperlandContext())
            {
                var v = dc.Users.Where(a => a.Email == email).FirstOrDefault();
                return v != null;
            }

        }
    }
}
