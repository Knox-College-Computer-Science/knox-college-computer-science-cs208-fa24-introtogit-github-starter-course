//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

//Additionally, if the number is negative, return 0.

//Note: If the number is a multiple of both 3 and 5, only count it once.



//My solution starts here:

public static class Kata
{
  public static int Solution(int value)
  {
    //handle exception
    if (value <= 0)
    {
      return 0;
    }
    int num = 0;
    // iterate through each natural num
    for(int x = 1; x < value; x++)
    {
    if (x%5 == 0 || x%3 == 0)
      //determine if multiple
    {
      num += x;
      //add to sum
    }
    }
    return num;
  }
}