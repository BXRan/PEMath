namespace PEMath
{
    /// <summary>
    /// Acos数值查询表
    /// </summary>
    class AcosTable
    {
        public static readonly int IndexCount;
        public static readonly int HalfIndexCount;
        public static readonly uint Multipler;  //倍增值  10000
        public static readonly int[] table;
        static AcosTable()
        {
            IndexCount = 1024;
            HalfIndexCount = 512;
            Multipler = 10000;


            table = new int[]
            {
            31416, //0
            30791, //1 
            30532 ,
            30333,
            30165 ,
            30017,
            29883,
            29760 ,
            29646,
            29538 ,
            29436 ,
            29339,
            29247,
            29158,
            29072,
            28989,
            28909,
            28832,
            28756,
            28683 ,
            28612 ,
            28542 ,
            28474,
            28407,
            28342,
            28278,
            28215,
            28154,
            28093,
            28034,
            27976,
            27918 ,
            27862,
            27806 ,

            };
        }
    }
}
