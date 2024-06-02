// My Solution 

public class Solution
{
  public int NumberOfSteps(int num)
  {
    int steps = 0;
    while (num > 0)
    {
      if (num % 2 == 0)
      {
        num /= 2;
        steps++;
      }
      else
      {
        num--;
        steps++;
      }
    }
    return steps;
  }
}

// by Bitwise Approach

public class Solution
{
  public int NumberOfSteps(int num)
  {
    int steps = 0;
    while (num != 0)
    {
      if ((num & 1) == 1)
      {
        num--;
        steps++;
      }
      else
      {
        num >>= 1;
        steps++;
      }
    }
    return steps;
  }
}