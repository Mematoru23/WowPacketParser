using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_2_0_52038
{
    public class StableInfo : IStableInfo
    {
        public WowGuid StableMaster { get; set; }
        public DynamicUpdateField<IStablePetInfo> Pets { get; } = new DynamicUpdateField<IStablePetInfo>();
    }
}

