using Helperland.Data;
using Helperland.Models;
using Helperland.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;
using MimeKit.Text;

namespace Helperland.Controllers
{
    public class AccountController : Controller
    {
        HelperlandContext dc = new HelperlandContext();
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult login(createviewmodel model)
        {
            var Password = Crypto.Hash(model.Password);
            User user = dc.Users.Where(x => x.Email == model.Email && x.Password == Password).FirstOrDefault();

            if (user != null)
            {
                HttpContext.Session.SetString("username", model.Email);

                return View("~/views/Home/Index.cshtml");
            }
            else
            {
                ViewBag.error = "Username or password is invalid";
                return View();
            }
        }
        
        //[HttpGet]
        //public IActionResult ForgotPassword()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult ForgotPassword(createviewmodel model)
        {
            var data = (from userlist in dc.Users
                        where userlist.Email == model.Email
                        select new
                        {
                            userlist.UserId,
                            userlist.FirstName,
                            userlist.Email,
                            userlist.Password

                        }).ToList();
            if (data.FirstOrDefault() != null)
            {
                ViewBag.Data = model.Email;
                return View("ResetPassword");
            }
            else
            {
                ViewBag.error = "Invalid Email";
                return View();
            }
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetViewModel model)
        {
            var user = dc.Users.Where(x => x.Email == model.Email).FirstOrDefault();
            if (user != null)
            {
                user.Password = Crypto.Hash(model.newPassword);
                dc.Users.Update(user);
                dc.SaveChanges();
                return View("~/views/Home/Index.cshtml");

            } 
            return View();
        }




        //    MimeMessage message = new MimeMessage();
        //    message.From.Add(new MailboxAddress("sender", "gordaivik52@gmail.com"));
        //    message.To.Add(MailboxAddress.Parse(model.Email));
        //    message.Subject = "Reset Password";

        //    var lnkHref = "<a href= \"http://localhost:http://localhost:6599/" + Url.Action("ResetPassword", "Account") + "/" + emaillink + " \" >Reset Password</a>";
        //    message.Body = new TextPart("html")
        //    {


        //        Text = "<a href=" + lnkHref + ">Reset Password</a>"
        //    };

        //    SmtpClient smtp = new SmtpClient();
        //    try
        //    {
        //        smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        //        smtp.Authenticate("gordaivik52@gmail.com", "Daivik3052000@");
        //        smtp.Send(message);
        //        Console.WriteLine("Email Sent");
        //    }
        //    catch (Exception er)
        //    {
        //        Console.WriteLine(er.Message);
        //    }
        //    finally
        //    {
        //        smtp.Disconnect(true);
        //        smtp.Dispose();
        //    }

        //    //account.ResetPasswordLink = resetlink;


        //    dc.SaveChanges();


        //}

        //else
        //{
        //    ViewBag.msg = "Account not exist";
        //}

        //return View("~/Views/Home/Index.cshtml");
    }
}

  
