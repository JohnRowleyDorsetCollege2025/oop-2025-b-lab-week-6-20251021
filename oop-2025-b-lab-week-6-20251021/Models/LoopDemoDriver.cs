using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_lab_week_6_20251021.Models
{
    public static class LoopDemoDriver
    {
        public static void Run()
        {
            ForLoop1();
            ForLoop2();
            ForLoop2();
        }

        public static void ForLoop1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        public static void ForLoop2()
        {

            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Iteration {i} is even");
                }

            }
        }
        public static void ForLoop3()
        {
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                counter += i;

            }
            Console.WriteLine($"The sum of numbers between 1 and 100 is {counter}");
        }
    }
}
