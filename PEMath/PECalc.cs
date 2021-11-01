using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 常用定点数数学运算
/// </summary>
namespace PEMath
{
    public class PECalc
    {
        public static PEInt Sqrt(PEInt value, int interatorCount = 8)  //牛顿迭代法   //优化过的  很有必要因为定点库在游戏底层逻辑会用到很多次，优化过后可以在更低端的手机上跑起来
        {
            if (value == PEInt.zero)
            {
                return 0;
            }
            if (value < PEInt.zero)
            {
                throw new Exception();
            }
            PEInt result = value;
            PEInt history;
            int count = 0; //保护机制  防止死循环
            do
            {
                history = result;
                result = (result + value / result) >> 1;
                ++count;
            } while (count < interatorCount && result != history);

            return result;
        }
        /// <summary>
        /// 求平方根
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="interator">迭代次数</param>
        /// <returns></returns>
        public static PEInt Sqrt2(PEInt value, int interatorCount = 8)  //牛顿迭代法
        {
            if (value == PEInt.zero)
            {
                return 0;
            }
            if (value < PEInt.zero)
            {
                throw new Exception();
            }
            PEInt result = value;

            for (int i = 0; i < interatorCount; i++)
            {
                result = (result + value / result) >> 1;
                Console.WriteLine($"迭代{i}次： result={result.RawFloat}");
            }
            return result;
        }

        public static PEArgs Acos(PEInt value)
        {
            PEInt rate = (value * AcosTable.HalfIndexCount) + AcosTable.HalfIndexCount; ;
            rate = Clamp(rate, PEInt.zero, AcosTable.IndexCount);
            int rad = AcosTable.table[rate.RawInt];    //弧度值
            
            return new PEArgs(rad, AcosTable.Multipler);
        }

        private static PEInt Clamp(PEInt input, PEInt min, int max)
        {
            if (input < min)
            {
                return min;
            }
            if (input > max)
            {
                return max;
            }
            return input;
        }
    }
}
