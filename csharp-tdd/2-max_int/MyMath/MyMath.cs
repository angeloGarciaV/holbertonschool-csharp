using System;
using System.Collections.Generic;
using System.Globalization;

namespace MyMath
{
  /// <summary>
  /// Represents a class that contains operations for integers.
  /// </summary>
  public class Operations
  {
    /// <summary>
    /// Returns the maximum integer from a list of integers.
    /// </summary>
    /// <param name="nums">List</param>
    /// <returns>int</returns>
    public static int Max(List<int> nums)
    {
      if (nums == null || nums.Count <= 0)
            {
                return 0;
            }
        int max = nums[0];
        foreach(int num in nums)
        {
          if(num > max)
          {
            max = Math.Max(max, num);
          }
        }
        return max;
      }
    }
  }
