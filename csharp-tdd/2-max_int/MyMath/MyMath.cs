using System.Collections.Generic;
using System.Globalization;

namespace MyMath
{
  public class Operations
  {
    public static int Max(List<int> nums)
    {
      if (nums.Count == 0)
      {
        return 0;
      }else{
        int max = nums[0];
        foreach(int num in nums)
        {
          if(num > max)
          {
            max = num;
          }
        }
        return max;
      }
    }
  }
}