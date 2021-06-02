using System;
using System.Collections.Generic;

namespace GenerateNames
{
  class Program
  {
    /* ARRAYS not recommended. Must define size of array before creating the array.
    static string[] GenerateNames()
    {
      string[] names = new string[4];
      names[0] = "Gamma";
      names[1] = "Vlissides";
      names[2] = "Johnson";
      names[3] = "Helm";
      return names;
    }
 */

    /* ARRAYLIST() not recommended. It's up to the developer to ensure that the type (string, int, etc.) is
    correctly represented when the ARRAYLIST() object is used. 
        static ArrayList GenerateNames()
        {
          ArrayList names = new ArrayList();
          names.Add("Gamma");
          names.Add("Vlissides");
          names.Add("Johnson");
          names.Add("Helm");
          return names;
        }
    */
    /* STRINGCOLLECTION() is recommended. It enforces type safety via compiler:
    error CS1503: Argument 1: cannot convert from 'int' to 'string?'*/

    /* static StringCollection GenerateNames()
{
  StringCollection names = new StringCollection();
  names.Add("Gamma");
  names.Add("Vlissides");
  names.Add("Johnson");
  names.Add("Helm");
  names.Add("1");

  return names;
}

static void PrintNames(StringCollection names)
    {
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void Main( )
    {
        var names = GenerateNames();
        PrintNames(names);
    } *******************************************************************************/

    /* Now let's replace STRINGCOLLECTION with a GENERIC TYPE.
    Why? StringCollection can only work with strings. A generic type can accept and return
    an object of any type. */

    static List<string> GenerateNames()
    {
      List<string> names = new List<string>();
      names.Add("Gamma");
      names.Add("Vlissides");
      names.Add("Johnson");
      names.Add("Helm");
      names.Add("1");

      return names;
    }
    
    static void PrintNames(List<string> names)
    {
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
    }

    static void Main()
    {
      var names = GenerateNames();
      PrintNames(names);
    } 

  }
}
