using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave4
{
    internal class MyList<Int>
    {
        private int[] arr;
        public int Count { get; private set; }
        public MyList()
        {
            arr = new int[2];
            Count = 0;
        }

        public void Add(int number)
        {
            if (arr.Length == Count)
            {
                Array.Resize(ref arr, arr.Length * 2);
            }

            arr[Count] = number;
            Count++;
        }
        public void Remove(int number)
        {
            //Ikke færdig
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return arr[index];
            }
            set
            {
                if (index >= 0 && index <= Count - 1)
                {
                    arr[Count] = value;
                }
            }
        }

        private void Resize()
        {
            int[] newArr = new int[arr.Length * 2];

            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }
    }
}
