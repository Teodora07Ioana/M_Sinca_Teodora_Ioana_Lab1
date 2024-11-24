using Microsoft.AspNetCore.Mvc;

namespace M_Sinca_Teodora_Ioana_Lab1.Controllers
{
    public class StudentController : Controller
    {
        // Metoda 1: Index - Mesaj de bun venit
        public IActionResult Index()
        {
           
            return Content("Bun venit la laboratorul nostru ASP.NET Core MVC!");
        }

        // Metoda 2: Salut utilizator
        public IActionResult Salut()
        {
            return Content("Salut, draga student! Sper sa ai o zi minunata!");
        }

        // Metoda 3: Mesaj cu parametru string și întreg
        public IActionResult Mesaj(string nume, int varsta)
        {
           
            return Content($"Salut, {nume}! Ai {varsta} ani si esti binevenit la laborator!");
        }
    }
}
