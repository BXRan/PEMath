using System;
using PEMath;

/// <summary>
/// 测试用例
/// </summary>
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Example5();
            Console.ReadKey();
        }

        private static void Example5()  //规格化测试
        {
            PEVector3 v = new PEVector3(1, 1, 1);
            Console.WriteLine("a:" + v.normalized);
            Console.WriteLine("b:" + PEVector3.Narmalize(v));
            Console.WriteLine("c:" + v);
            v.Narmalize();
            Console.WriteLine("c:" + v);

        }

        static void Example3()
        {
            int hp = 500;
            var var1 = hp * new PEInt(0.3f);
            Console.WriteLine("before scale" + var1.ScaledValue);
            Console.WriteLine("before float" + var1.RawFloat);
            Console.WriteLine("before int" + var1.RawInt);
            Console.WriteLine("---------------------");

            var var2 = hp * new PEInt(-0.3f);
            Console.WriteLine("after scale" + var2.ScaledValue);
            Console.WriteLine("after float" + var2.RawFloat);
            Console.WriteLine("after int" + var2.RawInt);
        }
        static void Example2()
        {
            PEInt val1 = 2;
            PEInt val2 = (PEInt)1.5f;
            Console.WriteLine(val1 * val2);

            PEInt val3 = 4;
            PEInt val4 = (PEInt)0.5f;
            Console.WriteLine(val3 / val4);
        }
        static void Example1()
        {
            PEInt val1 = new PEInt(1);
            PEInt val2 = new PEInt(2);
            PEInt val3 = (PEInt)1.2f;
            PEInt val4 = 1;


            Console.WriteLine(val2 / val1);
            //if (val1 > val2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

        }

    }
}
