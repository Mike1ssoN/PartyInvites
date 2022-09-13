using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
   public IActionResult Index()
   {
      return View();
   }
   [HttpGet]
   public ViewResult RsvpForm()
   {
      return View();
   }

   [HttpPost]
   public ViewResult RsvpForm(GuestResponse questResponse)
   {
     Repository.AddResponses(questResponse);
     return View("Thanks", questResponse);
   }

   public IActionResult ListRespinses()
   {
      return View(Repository.Responses.Where(x => x.WillAttend == true));
   }
}