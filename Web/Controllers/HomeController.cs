using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolio;

        public HomeController(
            IUnitOfWork<Owner> owner,
            IUnitOfWork<PortfolioItem> portfolio)
        {
            _owner = owner;
            _portfolio = portfolio;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
            };

            return View(homeViewModel);
        }

        public IActionResult Food()
        {
            var foodModel = new FoodModel
            {
                
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };

            return View(foodModel);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel contact)
        {
            var mail = new MailMessage();
            var loginInfo = new NetworkCredential("arabicFood55@gmail.com", "Ff&123456");
            mail.From = new MailAddress(contact.Email);
            mail.To.Add(new MailAddress("arabicFood55@gmail.com"));
            mail.Subject = contact.Subject;
            mail.IsBodyHtml = true;
            string body = "اسم المرسل :" + contact.Name + "<br>" +
                         "بريد المرسل :" + contact.Email + "<br>" +
                          "رقم الجوال :" + contact.Phone + "<br>" +
                         "عنوان الرسالة :" + contact.Subject + "<br>" +
                         "نص الرسالة : <b>" + contact.Massege + "</b>";


            mail.Body = body;

            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(mail);

            ViewBag.msg = "Sent succesfully";
            return View("Contact");
             
           
        }

    }
}