namespace _74Search2DMatrix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        bool result;
        Console.WriteLine("test 1");
        result = sol.SearchMatrix(
            [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ],
            3
        );
        Console.WriteLine(result);
        Console.WriteLine("test 2");
        result = sol.SearchMatrix(
            [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ],
            13
        );
        Console.WriteLine("test 5");
        result = sol.SearchMatrix(
            [[1],[3]],
            3
        );
        Console.WriteLine("test 6");
        result = sol.SearchMatrix(
            [
                [1]
            ],
            0
        );
        Console.WriteLine(result);
        Console.WriteLine(result);
        Console.WriteLine("test 7");
        result = sol.SearchMatrix(
            [
                [-9, -9, -9, -8, -8, -7, -6, -4, -4, -3],
                [0, 1, 2, 2, 4, 5, 5, 5, 7, 9],
                [12, 12, 14, 14, 15, 17, 19, 19, 19, 21],
                [22, 23, 23, 25, 25, 26, 26, 28, 28, 29],
                [31, 31, 31, 33, 34, 36, 37, 38, 38, 39],
                [40, 42, 43, 44, 46, 46, 46, 47, 49, 50],
                [52, 54, 55, 57, 59, 60, 60, 62, 64, 66],
                [68, 68, 70, 71, 71, 72, 74, 76, 78, 80],
                [82, 83, 85, 85, 85, 87, 88, 88, 89, 89],
                [90, 90, 90, 91, 93, 94, 94, 95, 95, 97],
                [98, 98, 99, 99, 101, 103, 105, 106, 108, 109],
                [112, 112, 112, 113, 113, 113, 114, 116, 118, 118],
                [119, 121, 122, 124, 125, 125, 125, 126, 127, 128],
                [131, 133, 134, 134, 134, 135, 135, 137, 137, 139],
                [141, 143, 145, 147, 148, 150, 150, 150, 150, 152],
                [153, 153, 154, 155, 157, 157, 157, 159, 161, 162],
                [164, 166, 167, 167, 167, 169, 170, 170, 171, 173],
                [176, 176, 178, 179, 181, 182, 183, 183, 184, 186]
            ],
            135
        );
        Console.WriteLine(result);
        
    }

    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length <= 1)
            {
                return this.Search(matrix[0], target);
            }
            //find the row
            int left = 0;
            int right = matrix.Length - 1;
            int m = 0;
            while (right > left)
            {
                m = left + (right - left) / 2;

                Console.WriteLine("left: " + left + " right: " + right + " m: " + m);
                if (matrix[m][0] < target)
                {
                    left = m + 1;
                }
                else if (matrix[m][0] > target)
                {
                    right = m - 1;
                }
                else if (matrix[m][0] == target)
                {
                    return true;
                }
            }
            m = left + (right - left) / 2;
            Console.WriteLine("left: " + left + " right: " + right + " m: " + m);
            if (m != 0)
            {
                if (target < matrix[m][0])
                {
                    Console.WriteLine("search in m: " + m);
                    return this.Search(matrix[m - 1], target);
                }
            }
            Console.WriteLine("m: " + m + "matrix.Lenght"  + matrix.Length);
            if (m + 1 < matrix.Length)
            {
                if (matrix[m + 1][0] < target)
                {
                    Console.WriteLine("search in m: " + m);
                    return this.Search(matrix[m + 1], target);
                }
            }
            Console.WriteLine("search in m: " + m);
            return this.Search(matrix[m], target);
        }

        public bool Search(int[] nums, int value)
        {
            int left = 0;
            int right = nums.Length - 1;
            int m;

            while (right >= left)
            {
                m = left + (right - left) / 2;
                if (nums[m] < value)
                {
                    left = m + 1;
                }
                else if (nums[m] > value)
                {
                    right = m - 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
