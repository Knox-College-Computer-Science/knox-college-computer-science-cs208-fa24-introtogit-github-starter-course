//Simple, given a string of words, return the length of the shortest word(s).

//String will never be empty and you do not need to account for different data types.


public class Kata
{
  public static int FindShort(string s)
  {
    int curr = s.Length;
    
    //separate by word
    string[] WordArray = s.Split(" ");
    
    //check length of each word
    for(int x = 0; x < WordArray.Length; x++)
    {
      if(WordArray[x].Length < curr)
      {
        curr = WordArray[x].Length;
        //update if word is shorter
      }
    }
    return curr;
  }
}