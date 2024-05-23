/*
First i think of Nested loop but in worst case if the array contains 100 elements 
and it do not found any item then it will run 10000 times

We are Noting Down the Element index and the 
so if target is 9 and array = [2,7,11,15]
Minus value = 9 - 2 = 7  and then we look for 7 in the Dictionary
But the 7 not found and we Note Down the index of 2 in Dictionary
{2 : 0}  NumberMapper[nums[i]] = i;
*/

public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    Dictionary<int, int> NumberMapper = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
      int MinusValue = target - nums[i];
      if (NumberMapper.ContainsKey(MinusValue))
      {
        return new int[] { NumberMapper[MinusValue], i };
      }

      NumberMapper[nums[i]] = i;
    }


    return [];
  }
}