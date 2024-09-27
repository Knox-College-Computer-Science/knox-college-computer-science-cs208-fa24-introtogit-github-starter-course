//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

//Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1})



//My solution begins here

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int[] answer = new int[arr.Length];
    //new array to store the values
    int p = 0;
    
    //cycle through each value
    for(int i = 0; i < arr.Length; i++)
    {
      if(arr[i] != 0)
      {
        answer[p] = arr[i];
        p++;
      }
    }
    return answer;
  }
}