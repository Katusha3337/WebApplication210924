using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication210924.Models;

namespace WebApplication210924.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Создаем объект пользователя
            var user = new User
            {
                Name = "Иван Иванов",
                Age = 30,
                Email = "ivan.ivanov@example.com"
            };

            // Передаем данные с помощью ViewBag
            ViewBag.UserName = user.Name;
            ViewBag.UserAge = user.Age;
            ViewBag.UserEmail = user.Email;

            // Передаем данные с помощью ViewData
            ViewData["UserName"] = user.Name;
            ViewData["UserAge"] = user.Age;
            ViewData["UserEmail"] = user.Email;

            // Передаем данные с помощью модели
            return View(user);
        }
    }
}
