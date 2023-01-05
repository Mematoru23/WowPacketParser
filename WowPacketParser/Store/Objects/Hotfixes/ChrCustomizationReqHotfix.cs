using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("chr_customization_req")]
    public sealed record ChrCustomizationReqHotfix1000: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("ReqSource")]
        public string ReqSource;

        [DBFieldName("Flags")]
        public int? Flags;

        [DBFieldName("ClassMask")]
        public int? ClassMask;

        [DBFieldName("AchievementID")]
        public int? AchievementID;

        [DBFieldName("QuestID")]
        public int? QuestID;

        [DBFieldName("OverrideArchive")]
        public int? OverrideArchive;

        [DBFieldName("ItemModifiedAppearanceID")]
        public int? ItemModifiedAppearanceID;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("chr_customization_req_locale")]
    public sealed record ChrCustomizationReqLocaleHotfix1000: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("ReqSource_lang")]
        public string ReqSourceLang;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
