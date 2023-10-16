using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_8
{
    internal class Generic<T>
    {
        private T value;
        public Generic() { }

        
        public bool F1<T>(T a, T b) where T : IComparable<T>
        {
            if(a.CompareTo(b) < 0) return false;
            return true;
        }
    }
}
