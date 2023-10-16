using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_8
{
    internal class Human
    {
        public int Age { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public Human() 
        {
            //PropertyChanged += Output;
        }
        public void Output(Human sender, int Age)
        {
            Console.WriteLine($"теперь возраст = {Age}");
        }
        
    }

    internal delegate void PropertyEventHandler(Human sender, int Age);
}
