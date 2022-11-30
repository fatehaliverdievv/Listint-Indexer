using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listint_indexer_.Models
{
    internal class ListInt
    {
        int[] _numsarr;
        public int Length
        {
            get { return _numsarr.Length; }
        }
        public int this[int index]
        {
            get
            {
                if (index < _numsarr.Length)
                {
                    return _numsarr[index];
                }
                else
                {
                    throw new Exception();
                }
            }
            set
            {
                if (index < _numsarr.Length)
                {
                    _numsarr[index] = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public ListInt()
        {
            _numsarr = new int[0];
        }
        public ListInt(int length)
        {
            _numsarr = new int[length];  
        }
        public ListInt(int[] numsarr)
        {
            _numsarr = numsarr;
        }
        public void Add(int num)
        {
            Array.Resize(ref _numsarr, _numsarr.Length+1);
            _numsarr[_numsarr.Length-1] = num;
        }
        public void Add(params int[] numArr)
        {
            int oldarrlength = _numsarr.Length;
            Console.WriteLine("Extended array : ");
            for (int i = 0; i < numArr.Length; i++)
            {
                Array.Resize(ref _numsarr, _numsarr.Length+1);
                _numsarr[_numsarr.Length-1]=numArr[i];
            }
            
        }
        public void GetArr()
        {
            foreach (var item in _numsarr)
            {
                Console.WriteLine(item);
            }
        }
        public bool Contains(int num)
        {
            Console.Write("Array contains number : ");
            foreach (int item in _numsarr)
            {
                if (num == item)
                {
                    return true;
                }
            }
            return false;
        }
        public void Sum()
        {
            int sum = 0;
            foreach (int item in _numsarr)
            {
                sum=sum+item;
            }
            Console.WriteLine("Numbers summary : " + sum);
        }
        public int Pop()
        {
            int lastindex = _numsarr[_numsarr.Length - 1] ;
            Array.Resize(ref _numsarr, _numsarr[lastindex]);
            return lastindex;
        }
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _numsarr.Length; i++)
            {
                sb.Append(_numsarr[i]);
            }
            return sb.ToString();
        }
    }
}
