using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 4/15/25
namespace Homework_8
{
    public class Pivot
    {
        public static int pivotIndex(int[] nums)
        {
            int totalSum = 0;
            // Calculate the total sum of the array
            for(int i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i];
            }

            int leftSum = 0;

            // iterate though the array to find the pivotindex
            for( int i = 0; i < nums.Length; i++)
            {
                // right sum is total sum minus left sum minus the current element 
                int rightSum = totalSum = leftSum + nums[i];

                // check to see if the left and right are equal 

                if( leftSum == rightSum)
                {
                    return i; // found the pivot index 
                }
                // add the current element to the left sum 
                leftSum += nums[i];
            }
            return -1; // no pivot found 
        }
    }
}
