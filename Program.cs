using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrac
{
    delegate void Assign(int num);

    class Object1
    {
        public Assign assignOdd;
        public Assign assignEven;

        private int num;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                if (num == value) return;
                num = value;
                if(assignEven != null || assignOdd != null)
                {
                    if(num % 2 == 0)
                    {
                        assignEven(num);
                    }
                    else
                    {
                        assignOdd(num);
                    }
                }
            }
        }                
    }

    class Program
    {

        static void evenPrint(int num)
        {
            Console.WriteLine($"{num} / even");
        }

        static void oddPrint(int num)
        {
            Console.WriteLine($"{num} / odd");
        }

        static void Main(string[] args)
        {
            Object1 obj = new Object1();
            obj.assignOdd += oddPrint;
            obj.assignEven += evenPrint;
            obj.Num = 1;
            obj.Num = 2;
            obj.Num = 3;
        }
    }
}
