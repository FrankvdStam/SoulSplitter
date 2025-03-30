namespace SoulSplitterUIv2.Enums
{
    public enum Game
    {
        [TimingTypes(TimingType.Immediate, TimingType.OnLoading, TimingType.OnWarp)]
        [SplitTypes(SplitType.Boss, SplitType.Attribute, SplitType.Bonfire, SplitType.Item, SplitType.Position, SplitType.KnownFlag, SplitType.Flag)]
        DarkSouls1 = 0,

        [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
        [SplitTypes(SplitType.Position, SplitType.Boss, SplitType.Attribute, SplitType.Flag)]
        DarkSouls2 = 1,

        [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
        [SplitTypes(SplitType.Boss, SplitType.Bonfire, SplitType.ItemPickup, SplitType.Attribute, SplitType.Flag, SplitType.Position)]
        DarkSouls3 = 2,

        [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
        [SplitTypes(SplitType.Boss, SplitType.Bonfire, SplitType.Position, SplitType.Flag, SplitType.Attribute)]
        Sekiro = 3,

        [TimingTypes(TimingType.Immediate, TimingType.OnLoading, TimingType.OnBlackscreen)]
        [SplitTypes(SplitType.Boss, SplitType.Bonfire, SplitType.ItemPickup, SplitType.KnownFlag, SplitType.Position, SplitType.Flag)]
        EldenRing = 4,

        [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
        [SplitTypes(SplitType.Flag)]
        ArmoredCore6 = 5,
    }
}
