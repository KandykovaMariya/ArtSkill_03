using ArtSkill_03.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace ArtSkill_03.Controllers
{
    public class ArtSkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

