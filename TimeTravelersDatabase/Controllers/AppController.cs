using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data;
using TimeTravelersDatabase.Services;
using TimeTravelersDatabase.ViewModels;

namespace TimeTravelersDatabase.Controllers
{
	public class AppController : Controller
    {
		private readonly IArrivalWindowsRepository _awRepository;
		private readonly IMailService _mailService;

		public AppController(IArrivalWindowsRepository awRepository, IMailService mailService)
		{
            _awRepository = awRepository;
            _mailService = mailService;
		}

        public IActionResult Index()
        {
            var windows = _awRepository.GetAll();
            return View(windows);
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send the Email
                _mailService.SendMessage("admin@cre9.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent...";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
