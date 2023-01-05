using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("content_tuning")]
    public sealed record ContentTuningHotfix1000: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("Flags")]
        public int? Flags;

        [DBFieldName("ExpansionID")]
        public int? ExpansionID;

        [DBFieldName("MinLevel")]
        public int? MinLevel;

        [DBFieldName("MaxLevel")]
        public int? MaxLevel;

        [DBFieldName("MinLevelType")]
        public int? MinLevelType;

        [DBFieldName("MaxLevelType")]
        public int? MaxLevelType;

        [DBFieldName("TargetLevelDelta")]
        public int? TargetLevelDelta;

        [DBFieldName("TargetLevelMaxDelta")]
        public int? TargetLevelMaxDelta;

        [DBFieldName("TargetLevelMin")]
        public int? TargetLevelMin;

        [DBFieldName("TargetLevelMax")]
        public int? TargetLevelMax;

        [DBFieldName("MinItemLevel")]
        public int? MinItemLevel;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
