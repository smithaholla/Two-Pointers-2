public class MergeSortedArray
	{
        // Time Complexity : O(m + n)
        // Space Complexity : O(1)
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int idx = m + n - 1;
            while(p1 >=0 && p2 >= 0)
            {
                if (nums1[p1] >= nums1[p2])
                {
                    nums1[idx] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[idx] = nums1[p2];
                    p2--;
                }
                idx--;
            }
            //either p1 or p2 goes to -1
            while (p2 >= 0)
            {
                nums1[idx] = nums1[p2];
                p2--;
                idx--;
            }
        }
    }
