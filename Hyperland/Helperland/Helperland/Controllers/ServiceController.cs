using Helperland.Data;
using Helperland.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace Helperland.Controllers
{
    public class ServiceController : Controller
    {
        readonly HelperlandContext dc = new HelperlandContext();
        public IActionResult bookservice()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult SetupService()
        //{
        //    return View();
        //}
        [HttpGet]
        public string searchzipcode(string zipcode)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                var zipcode1 = dc.Zipcodes.Where(z => z.ZipcodeValue == zipcode).FirstOrDefault();
                var zipcode2 = dc.Users.Where(z => z.ZipCode == zipcode && z.UserTypeId == 2).FirstOrDefault();

                if (zipcode1 != null)
                {
                    return "true";
                }
                else
                {
                    return "false" ;

                }
                

            }
            else
            {
                return "login";
            }
        }
    }
}
