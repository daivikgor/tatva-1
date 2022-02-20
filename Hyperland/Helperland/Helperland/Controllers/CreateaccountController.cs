using Helperland.Data;
using Helperland.Models;
using Helperland.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class CreateaccountController : Controller
    {
       
        private string message;
        private readonly HelperlandContext _HelperlandContext;

        public CreateaccountController(HelperlandContext HelperlandContext)
        {
            _HelperlandContext = HelperlandContext;
        }



        [HttpGet]
        public IActionResult createuser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult createuser(createviewmodel model)
        {
            if (ModelState.IsValid)
            {
                //region //Email is already Exist 
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
                    ModifiedDate=DateTime.Now,
                    Password=Crypto.Hash(model.Password),
                    UserTypeId=1,
                };
                _HelperlandContext.Add(user);
                _HelperlandContext.SaveChanges();
                TempData["Message"] = "Registered Successfull";

                return RedirectToAction("createuser");
            }

            else
            {
                message = "Invalid Request";
                return View(model);
            }
           
        }

        [NonAction]
        public bool IsEmailExist(string email)
        {
            using (HelperlandContext dc=new HelperlandContext())
            {
                var v = dc.Users.Where(a => a.Email == email).FirstOrDefault();
                return v != null;
            }

        }
    }
}
