using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSortingAlgo
{
    public class QuickSort
    {
        private int[] array;
        private int len;

        public QuickSort(int[] arrayInput)
        {
            array = arrayInput;
            len = arrayInput.Length;
        }
        public void quickSort()
        {
            sort(0, len - 1);
        }

        public void sort(int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot)
            {
                sort(left, pivot - 1);
            }

            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }
    }
}
