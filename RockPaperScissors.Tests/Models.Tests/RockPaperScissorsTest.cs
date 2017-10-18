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
    public void SetMoveVal_MoveStringsTranslatedCorrectlyToInt_ReturnTrue()
    {
      Game testObj = new Game();
      testObj.SetMoves("Rock","paper");
      Assert.AreEqual(true,testObj.GetMoveValue(0) == 1);
      Assert.AreEqual(true,testObj.GetMoveValue(1) == 3);
    }
    [TestMethod]
    public void SetMoveVal_MoveStringsTranslatedCorrectlyToInt_ReturnFalse()
    {
      Game testObj = new Game();
      testObj.SetMoves("Rock","paper");
      Assert.AreEqual(false,testObj.GetMoveValue(0) == 2);
      Assert.AreEqual(false,testObj.GetMoveValue(1) == 2);
    }

    [TestMethod]
    public void SetScore_TestPlayerMoveIntVals_Loss()
    {
      Game testObj = new Game();
      testObj.SetMoves("Rock","paper");
      testObj.SetScore();
      Console.WriteLine("p1: "+testObj.GetScore()[0]);
      Console.WriteLine("p2: "+testObj.GetScore()[1]);
      Assert.AreEqual(true,(testObj.GetScore()[0])<(testObj.GetScore()[1]));
    }
    [TestMethod]
    public void SetScore_TestPlayerMoveIntVals_Win()
    {
      Game testObj = new Game();
      testObj.SetMoves("paper","Rock");
      testObj.SetScore();
      Console.WriteLine("p1: "+testObj.GetScore()[0]);
      Console.WriteLine("p2: "+testObj.GetScore()[1]);
      Assert.AreEqual(true,(testObj.GetScore()[0])>(testObj.GetScore()[1]));
    }
    [TestMethod]
    public void SetScore_TestPlayerMoveIntVals_Draw()
    {
      Game testObj = new Game();
      testObj.SetMoves("paper","PaPer");
      testObj.SetScore();
      Assert.AreEqual(true,(testObj.GetScore()[0])==(testObj.GetScore()[1]));
    }
  }
}
