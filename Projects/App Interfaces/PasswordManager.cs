using System;

namespace App_Interfaces
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public string HeaderSymbol
    { get; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display(string HeaderSymbol)
    {
      Console.WriteLine($"Password\n {HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}{HeaderSymbol}");
      
      if(Hidden)
      {
        Console.WriteLine("*******");
      }
      else
      {
        Console.WriteLine(Password);
      }
    }

    public void Reset()
    {
        Password = "";
        Hidden = false;
    }




  }
}