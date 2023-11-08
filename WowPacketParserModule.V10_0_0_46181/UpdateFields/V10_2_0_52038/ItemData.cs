using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_2_0_52038
{
    public class ItemData : IItemData
    {
        public WowGuid Owner { get; set; }
        public WowGuid ContainedIn { get; set; }
        public WowGuid Creator { get; set; }
        public WowGuid GiftCreator { get; set; }
        public System.Nullable<uint> StackCount { get; set; }
        public System.Nullable<uint> Expiration { get; set; }
        public System.Nullable<int>[] SpellCharges { get; } = new System.Nullable<int>[5];
        public System.Nullable<uint> DynamicFlags { get; set; }
        public IItemEnchantment[] Enchantment { get; } = new IItemEnchantment[13];
        public System.Nullable<uint> Durability { get; set; }
        public System.Nullable<uint> MaxDurability { get; set; }
        public System.Nullable<uint> CreatePlayedTime { get; set; }
        public System.Nullable<int> Context { get; set; }
        public System.Nullable<long> CreateTime { get; set; }
        public System.Nullable<ulong> ArtifactXP { get; set; }
        public System.Nullable<byte> ItemAppearanceModID { get; set; }
        public System.Nullable<uint> DynamicFlags2 { get; set; }
        public System.Nullable<ushort> DEBUGItemLevel { get; set; }
        public DynamicUpdateField<IArtifactPower> ArtifactPowers { get; } = new DynamicUpdateField<IArtifactPower>();
        public DynamicUpdateField<ISocketedGem> Gems { get; } = new DynamicUpdateField<ISocketedGem>();
        public IItemModList Modifiers { get; set; }
    }
}

