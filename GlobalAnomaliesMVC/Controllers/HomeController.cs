using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GlobalAnomaliesMVC.Models;

namespace GlobalAnomaliesMVC.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Returns the model for the AccordionList.  The user can feed
        /// </summary>
        /// <returns>AccordionList model: List<{string: AccordionHeaderText, List<string>: AccordionListItems}></returns>
        public ActionResult Index()
        {
            AccordionList accordion = new AccordionList();
            accordion.AddAccordionItem("Sea Animals", new string[] {"Whale", "Starfish", "Dolphin", "Eel", "Octopus", "Turtle", "Shark"});
            accordion.AddAccordionItem("Land Animals", new string[] { "Sheep", "Cat", "Horse", "Giraffe", "Zebra", "Gopher", "Human" });
            return View(accordion);
        }
    }
}