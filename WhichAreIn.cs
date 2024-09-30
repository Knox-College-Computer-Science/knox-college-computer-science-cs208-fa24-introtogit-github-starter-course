//Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.

//Example 1:
//a1 = ["arp", "live", "strong"]

//a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

//returns ["arp", "live", "strong"]

//Example 2:
//a1 = ["tarp", "mice", "bull"]

//a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

//returns []

//Notes:
//Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.
//In Shell bash a1 and a2 are strings. The return is a string where words are separated by commas.
//Beware: In some languages r must be without duplicates.



//My solution begins here:

using System;
using System.Text;

class WhichAreIn
        {
            public static string[] inArray(string[] array1, string[] array2)
            {
            
                
              string temp = "";
              
              
                for(int x = 0; x < array1.Length; x++)
                {
                  //cycle through array
                  //does array contain substring
                  for(int y = 0; y < array2.Length; y++)
                  {
                    if(array2[y].Contains(array1[x]))
                    {
                      //record the subtrings and buffer with space
                      temp+= array1[x] + " ";
                      break;
                    }
                    
                  }
                }
              
               //empty array case
              if(array1.Length == 0 || array2.Length == 0 || temp == "")
              {
                return new string[0];
              }
                
              
        //convert to array and trim extra buffer
        string[] WordArray = temp.ToString().TrimEnd(' ').Split(" ");

        //sort the list lexicographically
        Array.Sort(WordArray);

        return WordArray;
            }
        }