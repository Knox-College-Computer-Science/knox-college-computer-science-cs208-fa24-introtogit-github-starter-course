//⚠️ The world is in quarantine! There is a new pandemia that struggles mankind. Each continent is isolated from each other but infected people have spread before the warning. ⚠️

//🗺️ You would be given a map of the world in a type of string:

//string s = "01000000X000X011X0X"

//'0' : uninfected

//'1' : infected

//'X' : ocean
//⚫ The virus can't spread in the other side of the ocean.

//⚫ If one person is infected every person in this continent gets infected too.

//⚫ Your task is to find the percentage of human population that got infected in the end.

//☑️ Return the percentage % of the total population that got infected.

//❗❗ The first and the last continent are not connected!

//💡 Example:

 //start: map1 = "01000000X000X011X0X"
 //end:   map1 = "11111111X000X111X0X"
 //total = 15
 //infected = 11
 //percentage = 100*11/15 = 73.33333333333333
//➕ For maps without oceans "X" the whole world is connected.

//➕ For maps without "0" and "1" return 0 as there is no population.


//My solution begins here:

using System;
using System.Linq;

public class Kata 
{
  public static double infected(string s)
  {
    double infected = 0;
    double uninfected = 0;
    //step one, divide by continent
    String[] continents = s.Split('X');
    
    //check each for infected
    for(int x = 0; x < continents.Length; x++)
    {
      //does string contain an X
      if(continents[x].Contains("1"))
      {//if yes, whole continent is infected
        infected = infected + continents[x].Length;
      }
      else
        {
        uninfected = uninfected + continents[x].Length;
      }
    }
    //calc total
    double total = infected + uninfected;
    if (total == 0)
    {//handles 0 case
      return 0;
    }
    //calc percentage
    return (infected / total) * 100.0;
  }
}
