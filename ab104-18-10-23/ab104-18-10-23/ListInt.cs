using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab104_18_10_23
{
    using System;

    internal class ListInt
    {
        private int[] array;

        public ListInt(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    Console.WriteLine("Index is out of range.");
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    Console.WriteLine("Index is out of range.");

                }
                array[index] = value;
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;
        }

        public void AddRange(params int[] nums)
        {
            int initialLength = array.Length;
            Array.Resize(ref array, array.Length + nums.Length);
            Array.Copy(nums, 0, array, initialLength, nums.Length);
        }

        public bool Contains(int num)
        {
            return Array.Exists(array, element => element == num);
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public void Remove(int num)
        {
            int index = Array.IndexOf(array, num);
            if (index != -1)
            {
                for (int i = index; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, array.Length - 1);
            }
        }

        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {
                Remove(num);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", array);
        }
    }

}
