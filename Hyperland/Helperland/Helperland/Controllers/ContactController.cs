using Helperland.Data;
using Microsoft.AspNetCore.Mvc;
using Helperland.Models;
using Helperland.ViewModel;
using System;

namespace Helperland.Controllers
{
    public class ContactController : Controller
    {
        private readonly HelperlandContext _HelperlandContext;

        public ContactController(HelperlandContext HelperlandContext)
        {
            _HelperlandContext = HelperlandContext;
        }

 
        public IActionResult Contact()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {

            ContactU newContact = new ContactU
            {
                Name = @model.FirstName + model.LastName,
                Email=model.Email,
                Subject=model.Subject,
                PhoneNumber=model.PhoneNumber,
                Message = model.Message,
                CreatedOn=DateTime.Now
            };
            _HelperlandContext.Add(newContact);
            _HelperlandContext.SaveChanges();


            return RedirectToAction("Contact");

        }
    }
}
