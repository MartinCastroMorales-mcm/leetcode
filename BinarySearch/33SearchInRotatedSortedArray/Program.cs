namespace _33SearchInRotatedSortedArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int Search(int[] nums, int target) { 
            int left = 0;
            int right = nums.Length-1;
            int m;
            bool buscarDerecha;
            if(target <= nums[right]) {
                if(target == nums[rihgt]){
                    return right;
                }
                buscarDerecha = true;
            }else if(target >= nums[left]) {
                if(target == nums[left]){
                    return left;
                }
                buscarDerecha = false;
            }else {
                return -1;
            }

            while(left < right) {
                m = left + (right-left)/2;
                if(nums[m] < nums[right]) {
                    //Esta en la parte derecha del arreglo
                    if(nums[m] < target) {
                        right = m -1;
                    }else if(nums[m] > target) {
                        left = m+1;
                    }else {
                        return m;
                    }
                }

                if(nums[m] > nums[left]) {
                    //Esta en la parte izquierda
                    if(nums[m] > target) {
                        right = m -1;
                    }else if(nums[m] < target) {
                        left = m+1;
                    }else {
                        return m;
                    }
                }

            }
            if(target < nums[right]) {

            }
        }
    }
}
