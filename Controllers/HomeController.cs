using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication210924.Models;

namespace WebApplication210924.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ������� ������ ������������
            var user = new User
            {
                Name = "���� ������",
                Age = 30,
                Email = "ivan.ivanov@example.com"
            };

            // �������� ������ � ������� ViewBag
            ViewBag.UserName = user.Name;
            ViewBag.UserAge = user.Age;
            ViewBag.UserEmail = user.Email;

            // �������� ������ � ������� ViewData
            ViewData["UserName"] = user.Name;
            ViewData["UserAge"] = user.Age;
            ViewData["UserEmail"] = user.Email;

            // �������� ������ � ������� ������
            return View(user);
        }
    }
}
