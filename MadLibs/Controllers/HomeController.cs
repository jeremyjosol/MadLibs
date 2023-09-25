using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    public string Welcome() { return "Welcome to the MadLibs generator."; }
    [Route("/")]
    public ActionResult SteppingIntoTomorrow() 
    { 
      PartsOfSpeech partsOfSpeech = new PartsOfSpeech();
      partsOfSpeech.Adjective = "Party";
      partsOfSpeech.Noun = "people";
      partsOfSpeech.Verb = "let";
      partsOfSpeech.AdjectiveTwo = "prior";
      partsOfSpeech.NounTwo = "invasion";
      return View(partsOfSpeech); }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/madlibs")]
    public ActionResult MadLibs(string adjective, string noun, string verb, string adjectiveTwo, string nounTwo)
    {
      PartsOfSpeech partsOfSpeech = new PartsOfSpeech();
      partsOfSpeech.Adjective = adjective;
      partsOfSpeech.Noun = noun;
      partsOfSpeech.Verb = verb;
      partsOfSpeech.AdjectiveTwo = adjectiveTwo;
      partsOfSpeech.NounTwo = nounTwo;
      return View(partsOfSpeech);
    }
  }
}