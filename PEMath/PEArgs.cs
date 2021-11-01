using System;
/// <summary>
/// 运算参数
/// </summary>
namespace PEMath
{
    public struct PEArgs
    {
        public int value;
        public uint multipler;  //方法的倍数

        public PEArgs(int value, uint multipler)
        {
            this.value = value;
            this.multipler = multipler;
        }

        public static PEArgs Zero = new PEArgs(0, 10000);
        public static PEArgs HALFPL = new PEArgs(15708, 10000);
        public static PEArgs PL = new PEArgs(31416, 10000);
        public static PEArgs TWOPL = new PEArgs(62832, 10000);

        #region 运算符
        public static bool operator >(PEArgs a, PEArgs b)
        {
            if (a.multipler == b.multipler)
            {
                return a.value > b.value;
            }
            else
            {
                throw new System.Exception("multipler is unequal.");
            }
        }
        public static bool operator <(PEArgs a, PEArgs b)
        {
            if (a.multipler == b.multipler)
            {
                return a.value < b.value;
            }
            else
            {
                throw new System.Exception("multipler is unequal.");
            }
        }
        public static bool operator >=(PEArgs a, PEArgs b)
        {
            if (a.multipler == b.multipler)
            {
                return a.value >= b.value;
            }
            else
            {
                throw new System.Exception("multipler is unequal.");
            }
        }
        public static bool operator <=(PEArgs a, PEArgs b)
        {
            if (a.multipler == b.multipler)
            {
                return a.value <= b.value;
            }
            else
            {
                throw new System.Exception("multipler is unequal.");
            }
        }
        public static bool operator ==(PEArgs a, PEArgs b)
        {
            if (a.multipler == b.multipler)
            {
                return a.value == b.value;
            }
            else
            {
                throw new System.Exception("multipler is unequal.");
            }
        }
        public static bool operator !=(PEArgs a, PEArgs b)
        {
            if (a.multipler == b.multipler)
            {
                return a.value == b.value;
            }
            else
            {
                throw new System.Exception("multipler is unequal.");
            }
        }
        #endregion

        /// <summary>
        /// 转换为视图角度，不可用于逻辑运算
        /// </summary>
        /// <returns></returns>
        public int CovertViewAngle()
        {
            float radians = ConvertToFloat();
            return (int)Math.Round(radians / Math.PI * 180);
        }

        /// <summary>
        /// 转换为视图弧度，不可用于逻辑运算
        /// </summary>
        /// <returns></returns>
        public float ConvertToFloat()
        {
            return value * 1.0f / multipler;
        }

        public override bool Equals(object obj)
        {
            return obj is PEArgs args && value == args.value && multipler == args.multipler;
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
        public override string ToString()
        {
            return $"value:{value} multipler:{multipler}";
        }
    }
}
