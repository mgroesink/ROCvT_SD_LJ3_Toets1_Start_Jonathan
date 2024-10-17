using I1SD_Toets1_Start;
using Microsoft.AspNetCore.Mvc;

namespace Toets1_Start.Controllers
{
    public class OpdrachtController : Controller
    {
        public IActionResult Opdracht1()
        {
            // Hier komt jouw uitwerking van opdracht 1
            ViewBag.Naam = "Jonathan";
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht1(int Value1)
        {
            // Hier komt jouw uitwerking van opdracht 1
            ViewBag.Naam = "Jonathan";


            try
            {
                ViewBag.awnser = MyFunctions.CreateNumberSequence(Value1);
            }
            catch (Exception ex) { ViewBag.ex = ex; }
            

            
            
            return View();
        }


        public IActionResult Opdracht2()
        {
            // Hier komt jouw uitwerking van opdracht 2
            ViewBag.Naam = "Jonathan";
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht2(string naam)
        {
            // Hier komt jouw uitwerking van opdracht 2
            ViewBag.Naam = "Jonathan";


            ViewBag.ogname = naam;
                string awnser = MyFunctions.ConvertStringToBinary(naam);
            ViewBag.awnser = awnser;
            
                



            return View();
        }
    }
}
