using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_8
{
    internal class Vector<T> : IEnumerable<T>
    {
        private T[] array;
        private int size;

        public Vector()
        {

        }
        public Vector(int size)
        {
            array = new T[size];
            this.size = size;
        }

        public void PushBack(T value)
        {
            T[] arr = new T[size + 1];
            for(int i = 0; i < size; i++)
            {
                arr[i] = array[i];
            }
            arr[size] = value;
            array = arr;
            size++;
        }

        public void PopBack()
        {
            T[] arr = new T[size - 1];
            for (int i = 0; i < size - 1; i++)
            {
                arr[i] = array[i];
            }
            
            array = arr;
            size--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    sb.Append(array[i].ToString());
                }
                else
                {
                    sb.Append(array[i].ToString() + ", ");
                }
            }
            return sb.ToString();
        }

        

        public IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return IEnumerable<T>;
        }

       
    }
}
