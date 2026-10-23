
using Microsoft.AspNetCore.Mvc;
using practical7.Models;

namespace practical7.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Success", feedback);
            }

            return View(feedback);
        }
    }
}
