using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/Result")]
      public ActionResult Result()
      {
        Game round = new Game();
        round.SetMoves(Request.Form["input1"], Request.Form["input2"]);
        //round.SetScore();
        return View(round);
      }
    }
}
