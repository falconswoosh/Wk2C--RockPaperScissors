using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTest
  {
    [TestMethod]
    public void SetMoves_ValuesBeingPassed_ReturnTrue()
    {
      Game testObj = new Game();
      testObj.SetMoves("Rock","paper");
      Assert.AreEqual(true, testObj.GetMoves()[0] == "rock");
      Assert.AreEqual(true, testObj.GetMoves()[1] == "paper");
    }
    [TestMethod]
    public void SetMoves_ValuesBeingPassed_ReturnFalse()
    {
      Game testObj = new Game();
      testObj.SetMoves("Rock","paper");
      Assert.AreEqual(false, testObj.GetMoves()[0] == "Rock");
      Assert.AreEqual(false, testObj.GetMoves()[1] == "repap");
    }

    [TestMethod]
    public void SetMoves_MoveStringsTranslatedCorrectlyByMoveSheet_ReturnTrue()
    {
      
    }


  }
}
