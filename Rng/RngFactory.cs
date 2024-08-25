namespace Gen5RNGLib.Rng
{
    public static class RngFactory
    {
        /// <summary>
        /// 初期seedを与えてLcgRngを生成します。
        /// </summary>
        public static ILcgRng CreateLcgRng(ulong initialSeed)
        {
            return new Internal.LcgRng(initialSeed);
        }
    }
}
