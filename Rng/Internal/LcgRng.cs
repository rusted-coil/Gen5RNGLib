namespace Gen5RNGLib.Rng.Internal
{
    internal sealed class LcgRng : ILcgRng
    {
        public ulong Seed { get; set; }

        public LcgRng(ulong initialSeed)
        {
            Seed = initialSeed;
        }

        public uint Next()
        {
            Seed = Seed * 0x5D588B656C078965ul + 0x269EC3;
            return (uint)(Seed >> 32);
        }
    }
}
