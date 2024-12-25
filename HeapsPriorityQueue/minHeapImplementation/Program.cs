using System;
using System.Collections.Generic;

namespace minHeapImplementation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    class MinHeap {
        private int count;
        private List<int> array;
        public MinHeap() {
            this.array = new List<int>();
            this.count = 1;
        }
        public MinHeap(List<int> arr) {
            this.array = this.Heapify(arr);
            this.count = array.Count;
        }

        //HelperMethods
        public void Swap(int i, int j) {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
        private void BubbleDown(int i) {
            if(2* i > this.count) {
                return;
            }
            if(this.array[i] > this.array[2* i]) {
                this.Swap(i, 2*i);
                BubbleDown(2*i);
                return;
            }
            if(2*i + 1 > this.count) {
                return;
            }
            if(this.array[i] > this.array[2*i + 1]) {
                this.Swap(i, 2*i);
                BubbleDown(2*i);
                return;
            }
            
        }
        private void BubbleUp(int i) {
            if(i == 1) {
                return;
            }
            if(i % 2 == 0) {
                //is LeftChild
                int fatherIndex = i/2;
                int fatherValue = this.array[fatherIndex];
                if(fatherValue > this.array[i]) {
                    this.Swap(fatherIndex, i);
                    BubbleUp(fatherIndex);
                    return;
                }

            }else {
                //is RightChild
                int fatherIndex = (i - 1)/2;
                int fatherValue = this.array[fatherIndex];
                if(fatherValue > this.array[i]) {
                    this.Swap(fatherIndex, i);
                    BubbleUp(fatherIndex);
                    return;
                }
            }
        }
        //public methods
        public void Insert(int val) {
            this.array.Insert(count, val);
            count++;
            this.BubbleUp(count);
        }

        public void RemoveMin() {
            this.Swap(1, this.count);
            this.array.RemoveAt(this.count);
            this.BubbleDown(1);

        }
        
        public void getIndex(int i) {
            if(i == 0 || i > this.count) {
                throw InvalidOperationException;
            }
            return this.array[i];
        }

        public int SeeMin() {
            if(array[1] != null) {
                throw InvalidOperationException;
            }
            return array[1];
        }
        public List<int> Heapify(List<int> arr) {

        }
    }
}
