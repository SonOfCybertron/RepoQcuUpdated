using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RepoQcu.Models;
using System.Collections.Generic;
using YourNamespace.Models;

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
            var model = new AboutUsViewModel
            {
                Title = "About QCU Repo",
                Mission = "Our mission is to streamline the learning process by providing a modern, digital library and repository system that evolves with the needs of students and educators.", 
                Description = "QCU Repo is a centralized platform designed to make information, research, and academic materials easily accessible to students and faculty at Quezon City University. This system is developed and maintained by passionate individuals committed to enhancing education through technology.",
                Developers = new List<Developer>
                {
                    new Developer
                    {
                        ImageUrl = "/images/Ayuyang.png",
                        Name = "Elizar Y. Ayuyang",
                        CourseTitle = "Information Technology"
                    },
                    new Developer
                    {
                        ImageUrl = "/images/Broncano.png",
                        Name = "Elijah C. Regan ",
                        CourseTitle = "Information Technology"
                    },
                    new Developer
                    {
                        ImageUrl = "/images/Carpeso.jpg",
                        Name = "Kurt Francis O. Carpeso",
                        CourseTitle = "Information Technology"
                    },
                    new Developer
                    {
                        ImageUrl = "/images/Cayocob.jpg",
                        Name = "Janelle A. Cayocob",
                        CourseTitle = "Information Technology"
                    },
                    new Developer
                    {
                        ImageUrl = "/images/Dexisne.jpg",
                        Name = "Michael Joshua S. Dexisne",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Dizon.jpg",
                        Name = "Princess Carmella G. Dizon",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Ecawat.jpg",
                        Name = "Jobert A. Ecawat",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Edillor.jpg",
                        Name = "Jestony F. Edillor",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Fernandez.jpg",
                        Name = "Seanne Paula R. Fernandez",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Flores.jpg",
                        Name = "Donita B. Flores",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Dexisne.jpg",
                        Name = "Michael Joshua S. Dexisne",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Malaluan.jpg",
                        Name = "Marwyn James R. Malaluan",
                        CourseTitle = "Information Technology"
                    },
                     new Developer
                    {
                        ImageUrl = "/images/Dexisne.jpg",
                        Name = "Jonalyn M. Rivamonte",
                        CourseTitle = "Information Technology"
                    },

                }
            };

            return View(model);
        }

        [ActionName("FAQ")]
        public IActionResult FAQ()
        {
            var faqs = new List<Faq>
            {
                new Faq { Id = 1, Question = "How to navigate to the QCU REPO", Answer = "In the Home Page click the Learn more button to transport you to the Repo itself." },
                new Faq { Id = 2, Question = "Does the resources in the repository are Opensource or Freeware?", Answer = "It depends on the Developers if their Applications are Open Source and Freeware it would be noted by the Repository if its the latter or not." },
                new Faq { Id = 3, Question = "Is your Repository Multi-Platform?", Answer = "Yes, It supports Mobile & Tablet, Computers, and Web." }
            };

            return View(faqs);
        }

        // GET: ContactUs
        [HttpGet]
        [ActionName("ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        // POST: ContactUs
        [HttpPost]
        [ActionName("ContactUs")]
        public IActionResult ContactUsPost(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Success = "Thank you for contacting us. We’ll get back to you soon!";
                ModelState.Clear(); // Reset form fields
            }

            return View("ContactUs");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
