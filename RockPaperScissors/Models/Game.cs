using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Models
{
  public class Game
  {

    private static string[] _playerMoves;
    private static int[] _score;
    private string _player1Name = "player1";
    private string _player2Name = "player2";
    private static Dictionary<string,int> moveSheet = new Dictionary<string,int>(){{"rock",1},{"scissors",2},{"paper",3}};
    public Game()
    {
      //_score[0] for player1 and _score[1] for player2
      _score       = new int[2];
      _playerMoves = new string[2];
    }



    // public string GetComputerMove(){return _computerMove;}
    public int[] GetScore()
    {return _score;}

    public string GetP1Move()
    {
      return _playerMoves[0];
    }
    public string GetP2Move()
    {
      return _playerMoves[1];
    }
    public string[] GetMoves()
    {
      return _playerMoves;
    }
    public void SetMoves(string p1, string p2)
    {
      _playerMoves[0] = p1.ToLower();
      _playerMoves[1] = p2.ToLower();
    }
  }
}

  //  public void int SetScore()
  // {
  //   Switch (moveSheet[_playerMoves[0].ToLower()])
  //   {
  //     case 1:
  //       //loss
  //       if(moveSheet[_playerMoves[1].ToLower()]==3)
  //       {_score[1]++; break;}
  //       //win
  //       if(moveSheet[_playerMoves[1].ToLower()]==2)
  //       {_score[0]++; break;}
  //       //draw
  //       if(moveSheet[_playerMoves[1].ToLower()]==moveSheet[_playerMoves[0].ToLower()])
  //       {break;}
  //
  //     case 2:
  //       //loss
  //       if(moveSheet[_playerMoves[1].ToLower()]==3)
  //       {_score[1]++; break;}
  //       //win
  //       if(moveSheet[_playerMoves[1].ToLower()]==2)
  //       {_score[0]++; break;}
  //       //draw
  //       if(moveSheet[_playerMoves[1].ToLower()]==moveSheet[_playerMoves[0].ToLower()])
  //       {break;}
  //
  //     case 3:
  //       //loss
  //       if(moveSheet[_playerMoves[1].ToLower()]==3)
  //       {_score[1]++; break;}
  //       //win
  //       if(moveSheet[_playerMoves[1].ToLower()]==2)
  //       {_score[0]++; break;}
  //       //draw
  //       if(moveSheet[_playerMoves[1].ToLower()]==moveSheet[_playerMoves[0].ToLower()])
  //       {break;}
  //   }

  // if (phoneNumbers.ContainsKey(friend))

/*
    public bool IsRockPaperScissors()
    {
      _source = _source.ToLower();
      _target = _target.ToLower();

      if (_source == _target) //if str1 contains str2 and length is equal they are the same and should throw a false bool
      {Console.WriteLine("These are the same!");return false;}

      if (_source!=_target && _source.Length == _target.Length)
      {
        char[] a = _source.ToCharArray();
        char[] b = _target.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);
        string c = new string(a);
        string d = new string(b);
        if (c.Contains(d))
        {Console.WriteLine("These are RockPaperScissors!");return true;}
      }
      if ((_source != _target) && (_source.Length > _target.Length))
      {
        char[] a = _source.ToCharArray();
        char[] b = _target.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);
        string c = new string(a);
        string d = new string(b);
        Console.WriteLine("a: "+c+" b: "+d+" in if");
        if (c.Contains(d))
        // abeltt !contain abt, abeltt contains ab
        {
          Console.WriteLine("These are partial RockPaperScissors!");return true;
        }
      }
      Console.WriteLine("These are not RockPaperScissors!");return false;
    }
*/
