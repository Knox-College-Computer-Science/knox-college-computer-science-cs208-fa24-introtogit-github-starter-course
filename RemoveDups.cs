//Your task is to remove all duplicate words from a string, leaving only single (first) words entries.

//Example:

//Input:

//'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

//Output:

//'alpha beta gamma delta'

//my solution begins here:

using System;

public static class Kata
{
  public static string RemoveDuplicateWords(string s)
  {

    //convert input string into array
    String[] input = s.Split(" ");
    string output = input[0];
    //create new string for output
    for(int x = 1; x < input.Length; x++)
    {
      if(!output.Contains(input[x]))//check if output contains input already
      {//if not add input
        output = output + " " + input[x];
      }
    }
    return output;
  }
}