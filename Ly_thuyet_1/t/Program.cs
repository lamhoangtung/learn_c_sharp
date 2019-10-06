using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace t
{
    class MainClass
    {
        public static void Simple(string[] args)
        {
            Int32 a, b, c = 0;
            Console.Write("Nhap vao a: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap vao b: ");
                b = Int32.Parse(Console.ReadLine());
                String op;
                Console.Write("Nhap vao operator: ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "+": c = a + b; break;
                    case "-": c = a - b; break;
                    case "*": c = a * b; break;
                    case "/": c = a / b; break;
                }
                Console.WriteLine("{0} {1} {2} = {3}", a, op, b, c);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Simple2(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            for (Int32 i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }

            foreach (Single each in a)
            {
                Console.Write(each + "\t");
            }
        }

        public static void Simple3(string[] args)
        {
            List<String> sinhvien = new List<String>();
            sinhvien.Add("Hoang Tung Lam");
            sinhvien.Add("Pham Thi Hoa");
            sinhvien.Sort();
            //sinhvien.Reverse()
            foreach (String sv in sinhvien)
            {
                Console.WriteLine(sv);
            }
        }

        public static void Simple4(string[] args)
        {
            String s = "Dai hoc Cong nghiep Ha Noi";
            List<String> word = s.Split(' ').ToList();
            word.Reverse();
            foreach (String sv in word)
            {
                Console.WriteLine(sv);
            }
        }

        public static void Simple5(string[] args)
        {
            ArrayList b = new ArrayList();
            b.Add(001);
            b.Add("Nguyen Van A");
            b.Add(002);
            b.Add("Nguyen Van B");
            b.Add(false);
            foreach (var each in b)
                Console.WriteLine(each);
        }

        public static void Bai1()
        {
            Int32 n;
            Int64 sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (Int32 i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong cac so tu 1 den {0} la {1}", n, sum);

        }

        public static void Bai2()
        {
            Int32 a, b, ans = 0;
            String op;
            Boolean still_running = true;
            do
            {
                try
                {
                    Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Operator: "); op = Console.ReadLine();
                    switch (op)
                    {
                        case "+": ans = a + b; break;
                        case "-": ans = a - b; break;
                        case "*": ans = a * b; break;
                        case "/": ans = a / b; break;
                        default: Console.WriteLine("Operator not supported"); still_running = false; break;
                    }
                    Console.WriteLine("{0} {1} {2} = {3}", a, op, b, ans);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input string");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't devide by zero");
                }

            }
            while (still_running == true);
        }

        public static void Bai3()
        {
            Int32 a, b, c;
            s.Split(' ').ToList()

        }

        public static void Main(string[] args)
        {
            Bai3();
            
        }
    }
}