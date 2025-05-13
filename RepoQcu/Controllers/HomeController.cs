using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RepoQcu.Models;

namespace RepoQcu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ActionName("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }




        [ActionName("FAQ")]
        public IActionResult FAQ()
        {
            var faqs = new List<Faq>
    {
        new Faq { Id = 1, Question = "How do I enroll at QCU?", Answer = "You can apply online through the QCU admissions portal." },
        new Faq { Id = 2, Question = "What programs are offered?", Answer = "We offer various undergraduate and graduate programs. Visit the Programs page for details." },
        new Faq { Id = 3, Question = "How do I get a student ID?", Answer = "After enrollment, visit the registrar’s office with your enrollment slip." }
    };

            return View(faqs); // Pass list to view
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}