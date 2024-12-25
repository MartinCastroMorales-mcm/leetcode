
namespace _703KthLargestElement;

class Program
{
    static void Main(string[] args)
    {
        KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
        Console.WriteLine("output:\n");
        kthLargest.Add(3); // return 4
        Console.WriteLine("return " + kthLargest.arrHeap[3]);
        kthLargest.Add(5); // return 5
        Console.WriteLine("return " + kthLargest.arrHeap[3]);
        kthLargest.Add(10); // return 5
        Console.WriteLine("return " + kthLargest.arrHeap[3]);
        kthLargest.Add(9); // return 8
        Console.WriteLine("return " + kthLargest.arrHeap[3]);
        kthLargest.Add(4); // return 8
        Console.WriteLine("return " + kthLargest.arrHeap[3]);
    }

    public class KthLargest
    {
        public int[] arrHeap;
        int arrSize = 0;
        int maxSize;

        public KthLargest(int k, int[] nums)
        {
            this.maxSize = k +1;
            arrHeap = new int[this.maxSize];
            for (int i = 0; i < nums.Length; i++)
            {
                this.Add(nums[i]);
            }
        }

        public void Swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        public void BubbleDown(int i, int[] arrHeap)
        {
            if (i * 2 > arrHeap.Length)
            {
                return;
            }
            if (arrHeap[i * 2] > arrHeap[i])
            {
                Swap(arrHeap, i, i * 2);
                BubbleDown(i * 2, arrHeap);
                return;
            }
            if (i * 2 + 1 > arrHeap.Length)
            {
                return;
            }
            if (arrHeap[i * 2 + 1] > arrHeap[i])
            {
                Swap(arrHeap, i, i * 2 + 1);
                BubbleDown(i * 2 + 1, arrHeap);
                return;
            }
        }

        public void BubbleUp(int i, int[] arrHeap)
        {
            if (i == 1)
            {
                return;
            }
            int fatherIndex;
            int fatherValue;
            if (i % 2 == 0)
            {
                //Es hijo a la izquierda
                fatherIndex = i / 2;
            }
            else
            {
                //Es hijo a la derecha
                fatherIndex = (i - 1) / 2;
            }
            fatherValue = arrHeap[fatherIndex];
            if (fatherValue < arrHeap[i])
            {
                Swap(arrHeap, i, fatherIndex);
                BubbleUp(fatherIndex, arrHeap);
                return;
            }
            return;
        }

        public int Add(int val)
        {
            if (arrSize != this.maxSize-1)
            {
                this.arrSize++;
            }

            int i = this.arrSize;
            if (val > this.arrHeap[i])
            {
                this.arrHeap[i] = val;
                BubbleUp(i, this.arrHeap);
            }
            
            this.printArr(arrHeap);
            return arrHeap[3];
        }
        public void printArr(int[] arr) {
            Console.Write("[");
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
            Console.WriteLine("]");
        }
    }
}
