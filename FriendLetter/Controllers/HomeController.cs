using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!";}

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

// Root Route
    [Route("/")]
    // public ActionResult Letter()
    // {
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = "Lina";
    //   myLetterVariable.Sender = "Jasmine";
    //   return View(myLetterVariable);
    // }

    [Route("/form")]
    public ActionResult Form() { return View();}

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string vacation, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Vacation = vacation;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }
  }
}