using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    
    [Route("/kung-fu")]
    public string HelloEnemy() {return "hello fiend";}

    [Route("/boo")]
    public ActionResult Booo() { return View(); }

    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Dudebro";
      myLetterVariable.Sender = "BestLyfer";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() {return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = recipient;
        myLetterVariable.Sender = sender;
        return View(myLetterVariable);
    }
  }
}