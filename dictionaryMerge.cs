//Your task is to implement a function that takes one or more dictionaries and combines them in one result dictionary.

//The keys in the given dictionaries can overlap. In that case you should combine all source values in an array. Duplicate values should be preserved.

//Here is an example:

//var source1 = new Dictionary<string, int>{{"A", 1}, {"B", 2}}; 
//var source2 = new Dictionary<string, int>{{"A", 3}};

//Dictionary<string, int[]> result = DictionaryMerger.Merge(source1, source2);
// result should have this content: {{"A", [1, 3]}, {"B", [2]}}
//You can assume that only valid dictionaries are passed to your function. The number of given dictionaries might be large. So take care about performance.

////I had a lot of difficulty with this problem and received help
//My solution begins here:

using System;
using System.Collections.Generic;

namespace DictionaryMergerKata 
{
  public sealed class DictionaryMerger
  {
    public static Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
    {
      //create var dict to hold results
      var result = new Dictionary< TKey, List<TValue>>();
      
      //cycle through the dictionaries
      foreach (var dict in dicts) 
      {
        //loop each entry
        foreach (var kvp in dict)
        {
          TKey key = kvp.Key;
          TValue val = kvp.Value;
          //updates val
          if (result.ContainsKey(key)) 
          {
            result[key].Add(val);
          }
          //adds val
          else 
          {
            result[key] = new List<TValue> { val };
          }
        }
      }
      //convert values to int arrays
      var answer = new Dictionary<TKey, TValue[]>();
        foreach (var kvp in result) {
            answer[kvp.Key] = kvp.Value.ToArray();
        }
      
      return answer;
    }
  }
}