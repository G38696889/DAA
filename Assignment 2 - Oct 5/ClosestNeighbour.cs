/*
Try copy pasting this whole code in https://try.dot.net/
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
   public static int leftMinNeighbour = 10000000, rightMinNeighbour = 10000000;
        public static int[] arr = new int[12] { 3, 5, 4, 2, 6, 3, 0, 0, 5, 4, 8, 3 };
        public static int globalMax = -1;
        public static int globalMin = 1000000;
  public static void Main()
  {
    
          Program cn = new Program();
          cn.CalcCloseNeighbour(0, 11);
            if (leftMinNeighbour < rightMinNeighbour)
                Console.WriteLine(leftMinNeighbour);
            else
                Console.WriteLine(rightMinNeighbour);

            Console.WriteLine("Global Max" + globalMax);
            Console.WriteLine("Global Min" + globalMin);
        
  }

   public void CalcCloseNeighbour(int start, int end)
        {
            if (start == end || end<start || start>end)
                return;
            int leftDiff, rightDiff;
            int mid = (start + end) / 2;
            if (globalMin >= arr[mid])
                globalMin = arr[mid];
            if(globalMax <= arr[mid])
                globalMax = arr[mid];
            if (mid >= 1 && mid < arr.Length)
            {
                leftDiff = Math.Abs(arr[mid] - arr[mid - 1]);
                rightDiff = Math.Abs(arr[mid + 1] - arr[mid]);
                if (leftMinNeighbour > leftDiff)
                    leftMinNeighbour = leftDiff;
                if (rightMinNeighbour > rightDiff)
                    rightMinNeighbour = rightDiff;
            }
            CalcCloseNeighbour(start, mid - 1);
            CalcCloseNeighbour(mid + 1, end);
            return;
        }
}
