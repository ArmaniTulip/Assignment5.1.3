namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Console.WriteLine(TwiceShown(nums1)); 
            Console.WriteLine(TwiceShown(nums2)); 
            Console.WriteLine(TwiceShown(nums3)); 


        }
        static bool TwiceShown(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;

                    }
                }
            }
            return false;

        }
        
    }

}
