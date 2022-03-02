using Helperland.Data;
using Helperland.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Helperland.ViewModel;

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
                    return "false";

                }


            }
            else
            {
                return "login";
            }
        }
        [HttpGet]
        public IActionResult schedule()
        {
            return View();
        }

        [HttpPost]
        public IActionResult schedule(ServiceViewModel model)
        {
            var username = HttpContext.Session.GetString("username");
            var id = dc.Users
                .Where(a => a.Email == username)
                .Select(a => a.UserId).FirstOrDefault();

            var postalcode = dc.UserAddresses
                .Where(a => a.UserId == id)
                .Select(a => a.PostalCode).FirstOrDefault();

            ViewBag.name = id;
            var extra_hrs = (model.ExtraHours) / 2;
            var cost = (decimal)(20 * (model.ServiceHours));

            ServiceRequest Request = new ServiceRequest
            {
                UserId = id,
                ServiceStartDate = model.ServiceStartDate,
                ServiceHourlyRate = 20,
                ServiceHours = model.ServiceHours,
                ExtraHours = extra_hrs,
                Comments = model.Comments,
                HasPets = model.HasPets,
                ZipCode = postalcode,
                SubTotal = cost,
                TotalCost = ((decimal)(20 * (extra_hrs))) + cost,
                ModifiedDate = model.ServiceStartDate,
                Distance = 1
            };
            dc.Add(Request);
            dc.SaveChanges();
            return View("Service");
        }
        [HttpGet]
        public IActionResult Details()
        {
            var username = HttpContext.Session.GetString("username");
            var id = dc.Users
                .Where(a => a.Email == username)
                .Select(a => a.UserId)
                .FirstOrDefault();
            ViewBag.name = username;

            List<UserAddress> add = dc.UserAddresses
                .Where(a => a.UserId == id).ToList();
            return View(add);
        }

        [HttpPost]
        public IActionResult Details(ServiceViewModel model, string Address_radio, string action)
        {
            var username = HttpContext.Session.GetString("username");
            var id = dc.Users
                .Where(a => a.Email == username)
                .Select(a => a.UserId)
                .FirstOrDefault();

            var serviceReqId = dc.ServiceRequests
                   .Where(a => a.UserId == id)
                   .OrderByDescending(a => a)
                   .Select(a => a.ServiceRequestId)
                   .FirstOrDefault();

            if (action == "addSerAdd")
            {
                int Address_id = int.Parse(Address_radio);

                UserAddress newUserAdd = dc.UserAddresses
                                         .Where(a => a.AddressId == Address_id)
                                         .FirstOrDefault();

                ServiceRequestAddress serviceRequestAddress = new ServiceRequestAddress
                {
                    ServiceRequestId = serviceReqId,
                    AddressLine1 = newUserAdd.AddressLine1,
                    AddressLine2 = newUserAdd.AddressLine2,
                    City = newUserAdd.City,
                    State = newUserAdd.State,
                    PostalCode = newUserAdd.PostalCode,
                    Mobile = newUserAdd.Mobile
                };
                dc.Add(serviceRequestAddress);
                dc.SaveChanges();
            }

            else
            {

                UserAddress userAddress = new UserAddress
                {
                    UserId = id,
                    AddressLine1 = model.AddressLine1,
                    AddressLine2 = model.AddressLine2,
                    City = model.City,
                    State = model.State,
                    PostalCode = model.PostalCode,
                    Mobile = model.Mobile,
                    IsDefault = true,
                    IsDeleted = true
                };
                dc.Add(userAddress);
                dc.SaveChanges();
            }

            ViewBag.Msg = serviceReqId;


            return View("bookservice");
        }


    }
}

