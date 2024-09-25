//Write a simple parser that will parse and run Deadfish.

//Deadfish has 4 commands, each 1 character long:

//i increments the value (initially 0)
//d decrements the value
//s squares the value
//o outputs the value into the return array
//Invalid characters should be ignored.

//Deadfish.Parse("iiisdoso") => new int[] {8, 64};


//My solution begins here:

using System.Collections.Generic;
public class Deadfish
{
  public static int[] Parse(string data)
  {
    //create list for storing values
    List<int> temp = new List<int>();
    int q = 0;
    
    //commands
    for(int i = 0; i < data.Length; i++)
    {
      if(data[i] == 'i'){
        q++;
      }
      else if(data[i] == 'd')
      {
        q--;
      }
      else if(data[i] == 's')
      {
        q = q * q;
      }
      else if(data[i] == 'o')
      {
        temp.Add(q);
      }
    }
    
    
    return temp.ToArray();
  }
}