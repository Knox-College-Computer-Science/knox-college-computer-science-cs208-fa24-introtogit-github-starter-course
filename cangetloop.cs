//You are given a node that is the beginning of a linked list. This list contains a dangling piece and a loop. Your objective is to determine the length of the loop.

//For example in the following picture the size of the dangling piece is 3 and the loop size is 12:


//# Use the `next' method to get the following node.
//node.next
//Notes:

//do NOT mutate the nodes!
//in some cases there may be only a loop, with no dangling piece


//My solution begins here:

public class Kata{
  public static int getLoopSize(LoopDetector.Node startNode){
    
    var fastPointer = startNode;
    var slowPointer = startNode;
 
    //detect loop
    fastPointer = fastPointer.next.next;
    slowPointer = slowPointer.next;
    while(fastPointer!=slowPointer)
    {
      fastPointer = fastPointer.next.next;
      slowPointer = slowPointer.next;
    }
    slowPointer = startNode;
    
    //find the start of the list
    while(fastPointer!=slowPointer)
    {
      fastPointer = fastPointer.next;
      slowPointer = slowPointer.next;
    }
    
    //count the length of the list
    slowPointer = slowPointer.next;
    int count = 1;
    while(fastPointer!=slowPointer)
    {
      slowPointer = slowPointer.next;
      count++;
    }
    
    
    return count;
  }
}