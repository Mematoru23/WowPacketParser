using WowPacketParser.Misc;
using WowPacketParser.Store.Objects;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_0_7_48676
{
    public class CraftingOrder : ICraftingOrder
    {
        public DynamicUpdateField<ItemEnchantData> Enchantments { get; } = new DynamicUpdateField<ItemEnchantData>();
        public DynamicUpdateField<ItemGemData> Gems { get; } = new DynamicUpdateField<ItemGemData>();
        public ICraftingOrderData Data { get; set; }
    }
}

