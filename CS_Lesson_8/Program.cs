using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_8
{
    internal class Program
    {
        public delegate void Message();
        public delegate void Message2();
        public delegate void Message3(string msg);
        static event Message3 Notify;
        

        static void Output(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {

            //Program p = new Program();
            //p.Delegate();

            //Delegate();

            //Notify += Output;
            //Notify("hello C#");
            // события
            List<string> names = new List<string>(4);    // vector<T> в С++
            LinkedList<string> list = new LinkedList<string>();
            Queue<string> queueStrings = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            Dictionary<int, string> keyValuePairs= new Dictionary<int, string>();
            SortedList<int, string> keyValuePairs1= new SortedList<int, string>();
            
            Vector<int> vec = new Vector<int>();
            vec.PushBack(2);
            vec.PushBack(3);
            vec.PopBack();
            Console.WriteLine(vec.ToString());

            foreach(int i in vec)
            {
                Console.WriteLine(i);
            }
        }

        Message mes3 = delegate ()
        {
            Console.WriteLine("I love C");
        };
        // делегаты
        public static void Delegate()
        {
            Message mes = Hello;
            mes();

            Message mes1 = delegate ()
            {
                Console.WriteLine("I don't love C#");
            };

            mes1();
        }

        // лямбды
        public static void Lambda()
        {
            Message2 hello = () =>
            {

            };
        }

        public static void Hello() { Console.WriteLine("I love C#"); }

        
        

    }
}
