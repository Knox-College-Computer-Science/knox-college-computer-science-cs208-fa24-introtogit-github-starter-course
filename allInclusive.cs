//Input:

//a string strng
//an array of strings arr
//Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):

//a boolean true if all rotations of strng are included in arr
//false otherwise
//Examples:
//contain_all_rots(
  "bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true

//contain_all_rots(
//  "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)
//Note:
//Though not correct in a mathematical sense

//we will consider that there are no rotations of strng == ""
//and for any array arr: contain_all_rots("", arr) --> true



//My solution begins here:

using System;
using System.Collections.Generic;

public class Rotations
{
  public static Boolean ContainAllRots(string strng, List<string> arr) 
  {

    //cycle through each version
    for(int i = 0; i < strng.Length; i++)
    {
      //check each spot in array
     
      if(!arr.Contains(strng))
      {
        //if the string doesn't occur
        return false;
      }
      
      //rotate the string
      strng = strng.Substring(1) + strng[0];
    }
    
    return true;
  }
}