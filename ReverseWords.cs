//Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

//Examples
//"This is an example!" ==> "sihT si na !elpmaxe"
//"double  spaces"      ==> "elbuod  secaps"

//My solution begins here:

using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    //convert strings to separate words
    String[] WordArray = str.Split(" ");
    String result = new string("");
    
    //reverse each word in loop
    for(int x = 0; x < WordArray.Length; x++)
    {
    char[] temp = WordArray[x].ToCharArray();
    //reverse with function
    Array.Reverse(temp);
    
    //append to result
      result = result + new string(temp);
      
      //add spaces
      if(x < WordArray.Length-1)
      {
        result = result + " ";
      }
    }

    return result;
  }
}