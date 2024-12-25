namespace _11ContainerOfWater;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int currentArea = 0;
            int max = 0;
            int right = height.Length - 1;
            int left = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (left >= right)
                {
                    return max;
                }
                if (height[left] < height[right])
                {
                    currentArea = height[left] * (right - left);
                    left++;
                }
                else
                {
                    currentArea = height[right] * (right - left);
                    right--;
                }

                if (currentArea > max)
                {
                    max = currentArea;
                }
            }
            return max;
        }
    }
}
