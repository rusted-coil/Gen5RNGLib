namespace Gen5RNGLib.Rng
{
    /// <summary>
    /// 第5世代のLCGの乱数生成器のインターフェースです。
    /// </summary>
    public interface ILcgRng
    {
        /// <summary>
        /// 現在のSeedを取得/設定します。一度もNextを呼んでいない時、初期Seedと一致する値をとります。
        /// </summary>
        ulong Seed { get; set; }

        /// <summary>
        /// 乱数を1つ取り出し、内部状態を1進めます。
        /// </summary>
        uint Next();
    }
}
