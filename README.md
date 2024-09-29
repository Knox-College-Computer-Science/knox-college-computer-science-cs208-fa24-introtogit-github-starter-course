[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/VoCX23gN)

REFLECTING ON YOUR WORK

*Part 2: Reflecting back on your work
Pick two alternate solutions that CodeWars showed you when you solved two exercises. What did you learn from these other approaches to the problem?*
```
using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryMergerKata 
{
  public sealed class DictionaryMerger
  {
    public static Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
    {
      return dicts
        .SelectMany(m => m)
        .GroupBy(p => p.Key)
        .ToDictionary(g => g.Key, g => g.Select(i => i.Value).ToArray());
    }
  }
}
```
Looking at solutions for dictionary merge I found one of them to be particularly interesting because it was created by the very author of the exercise. I imagine he had the solution in mind when developing the problem. This solution combines all of the dicts together, groups them by keys, and converts the groups back into a dictionary. This solution effectively utilizes the built-in LINQ functions. The code does not try to control the details of the steps but what the code should accomplish.
```
using System.Linq;
public class Kata
{
  public static int DontGiveMeFive(int start, int end)
  {
    return Enumerable.Range(start, end-start+1).Count(x => !x.ToString().Contains("5"));
  }
}
```
This Don’t Give Me Five exercise solution follows the same pattern of LINQ optimization. Instead of manually looping through integers, the machine is told to count each number that isn’t a five within the specified range. The solution is straightforward and to the point.

*Try to get ChatGPT to generate a solution to one of the problems. How well can it program? How much context do you need to put into the prompt? Include the full chat used.*

https://chatgpt.com/share/66f999cf-e2f0-8000-a0af-c86d529c82f0

```
using System.Linq;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        // Use LINQ to filter non-zero elements and get the count of zeros
        var nonZeroes = arr.Where(x => x != 0).ToArray();
        var zeroesCount = arr.Length - nonZeroes.Length;

        // Create a new array with non-zero elements followed by zeros
        return nonZeroes.Concat(Enumerable.Repeat(0, zeroesCount)).ToArray();
    }
}
```
ChatGPT can be good at coding at least from my perspective because it has more knowledge than me. I had it generate a solution for Moving Zeros to the End. My prompt was the stub code and guidance to use LINQ. It easily generated a functional method. I think the Moving Zeros problem is common and basic enough for the algorithm to generate an easy solution for however, a true judgment of character would be the generation of unique code for a complex and unique problem.


REFLECTING ON YOUR GOOGLE AND CHATGPT SKILLS

I made frequent use of google as I lack the experience with C#. I definitely made at least one google search for each problem.

“aggregate c#”

“array sort c#”

“c# implement vs extension reddit”

“non specific array type size c#”

“how to delete first letter of string c#”

“initialize string array c#” x4


The array sort search was the most helpful because I realized that LINQ functions can be used to solve problems more efficiently than manual loops and logic. None of the searches were necessarily the least helpful but it would have been better to remember the basic syntax instead of having to look it up multiple times.

