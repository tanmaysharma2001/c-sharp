using System;

namespace App_Interfaces
{
  interface IDisplayable
  {
    string HeaderSymbol
    {
        get;
    }
    void Display(string HeaderSymbol);
  }

}