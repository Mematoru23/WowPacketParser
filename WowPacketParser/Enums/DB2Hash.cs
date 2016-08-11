using System.Diagnostics.CodeAnalysis;

namespace WowPacketParser.Enums
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DB2Hash : uint
    {
        Achievement                     = 0xD2EE2CA7,
        Achievement_Category            = 0x231B414D,
        AdventureJournal                = 0x8EEF1A97,
        AdventureMapPOI                 = 0x6275EEF7,
        AnimKit                         = 0xB3AF6ECA,
        AnimKitBoneSet                  = 0xA88C80F8,
        AnimKitBoneSetAlias             = 0x37804DEA,
        AnimKitConfig                   = 0x141DB817,
        AnimKitConfigBoneSet            = 0x5D9F4EB1,
        AnimKitPriority                 = 0x51FD492D,
        AnimKitSegment                  = 0x3E988108,
        AnimReplacement                 = 0x536AA9E9,
        AnimReplacementSet              = 0xE970BB7B,
        AnimationData                   = 0x9CAF5A21,
        AreaGroupMember                 = 0x09626FB2,
        AreaPOI                         = 0xDF3F054A,
        AreaPOIState                    = 0x49EFF4C0,
        AreaTable                       = 0x7253EB43,
        AreaTrigger                     = 0x1A5081E1,
        AreaTriggerActionSet            = 0x5C4BBB1F,
        AreaTriggerBox                  = 0x490CDD72,
        AreaTriggerCylinder             = 0xAC92E4AD,
        AreaTriggerSphere               = 0x93073B25,
        ArmorLocation                   = 0xB1911544,
        Artifact                        = 0x0165E45F,
        ArtifactAppearance              = 0xACE08AE7,
        ArtifactAppearanceSet           = 0xE7121BA1,
        ArtifactCategory                = 0xC572B485,
        ArtifactPower                   = 0xF3AB984A,
        ArtifactPowerLink               = 0x36787E77,
        ArtifactPowerRank               = 0x15E3C63B,
        ArtifactQuestXP                 = 0xCA31E679,
        ArtifactUnlock                  = 0x57D1CB68,
        AuctionHouse                    = 0xB8F96456,
        BankBagSlotPrices               = 0xDEEC5A60,
        BannedAddOns                    = 0x3B7DA145,
        BarberShopStyle                 = 0x8F09B48B,
        BattlePetAbility                = 0xCBA43BD7,
        BattlePetAbilityEffect          = 0xDD8B690E,
        BattlePetAbilityState           = 0x3C556E43,
        BattlePetAbilityTurn            = 0xECD8ECDC,
        BattlePetBreedQuality           = 0x1B5A4EA6,
        BattlePetBreedState             = 0x6AFB3206,
        BattlePetEffectProperties       = 0x63B4C4BA,
        BattlePetNPCTeamMember          = 0xF2059DFA,
        BattlePetSpecies                = 0x6C93F9B1,
        BattlePetSpeciesState           = 0x15D87DD0,
        BattlePetSpeciesXAbility        = 0x44237314,
        BattlePetState                  = 0x8F447330,
        BattlePetVisual                 = 0xC3ADEB43,
        BattlemasterList                = 0x558D704E,
        BoneWindModifierModel           = 0x15D0EFA4,
        BoneWindModifiers               = 0x6519F1A9,
        Bounty                          = 0x5B476B7C,
        BountySet                       = 0xCBD2A10A,
        BroadcastText                   = 0x021826BB,
        CameraEffect                    = 0x4FA1379D,
        CameraEffectEntry               = 0x9D41DE06,
        CameraMode                      = 0xFD872EBD,
        CameraShakes                    = 0x48B883A1,
        CastableRaidBuffs               = 0xF7361166,
        Cfg_Categories                  = 0xC7ED797D,
        Cfg_Configs                     = 0x091F6599,
        Cfg_Regions                     = 0xA77E7F0D,
        CharBaseInfo                    = 0x3067A8F8,
        CharBaseSection                 = 0x5DA4CF6C,
        CharComponentTextureLayouts     = 0xA77C3E7B,
        CharComponentTextureSections    = 0xFAA98CF5,
        CharHairGeosets                 = 0x11D3EE9C,
        CharSections                    = 0x36304853,
        CharShipment                    = 0xB032B557,
        CharShipmentContainer           = 0xA7894FE7,
        CharStartOutfit                 = 0x7B41F581,
        CharTitles                      = 0x85DF9E8E,
        CharacterFaceBoneSet            = 0x4D62306F,
        CharacterFacialHairStyles       = 0x212303C2,
        CharacterLoadout                = 0xE00A47FB,
        CharacterLoadoutItem            = 0x65C39BA7,
        ChatChannels                    = 0xCCFF87ED,
        ChatProfanity                   = 0x23F759C7,
        ChrClassRaceSex                 = 0x31DAFEBF,
        ChrClassTitle                   = 0xC0DC0837,
        ChrClassUIDisplay               = 0xB0E2632B,
        ChrClassVillain                 = 0x359587F6,
        ChrClasses                      = 0xF5889D8C,
        ChrClassesXPowerTypes           = 0xC0315ACF,
        ChrRaces                        = 0x53F1783C,
        ChrSpecialization               = 0xA00F8E60,
        ChrUpgradeBucket                = 0xDDBC25B7,
        ChrUpgradeBucketSpell           = 0xC6426A90,
        ChrUpgradeTier                  = 0x99F5DC12,
        CinematicCamera                 = 0xC2CEFDF9,
        CinematicSequences              = 0x55EC00F0,
        CloakDampening                  = 0xDCC61EF0,
        CombatCondition                 = 0x15F55B6D,
        ComponentModelFileData          = 0xBE6AED26,
        ComponentTextureFileData        = 0x82408B8D,
        ConversationLine                = 0xC794A036,
        Creature                        = 0xC9D6B6B3,
        CreatureDifficulty              = 0xC9E0A749,
        CreatureDispXUiCamera           = 0x3B5B6503,
        CreatureDisplayInfo             = 0xBFDAF9F1,
        CreatureDisplayInfoCond         = 0x1183FBF1,
        CreatureDisplayInfoExtra        = 0x66A5C5B7,
        CreatureDisplayInfoTrn          = 0xFD09B803,
        CreatureFamily                  = 0x369F469F,
        CreatureImmunities              = 0x211E2DEF,
        CreatureModelData               = 0x7F695FA5,
        CreatureMovementInfo            = 0xCF156785,
        CreatureSoundData               = 0x91C188C0,
        CreatureType                    = 0x1F80AD3F,
        Criteria                        = 0xEF23DC80,
        CriteriaTree                    = 0x4AD4429C,
        CriteriaTreeXEffect             = 0xE85A9D09,
        CurrencyCategory                = 0xD3C46981,
        CurrencyTypes                   = 0x2F51378E,
        Curve                           = 0x4BD9DF7A,
        CurvePoint                      = 0x700ECA3A,
        DeathThudLookups                = 0x4237038F,
        DecalProperties                 = 0xC7B7E435,
        DeclinedWord                    = 0x2032D85F,
        DeclinedWordCases               = 0xA4495A4A,
        DestructibleModelData           = 0x7A74425D,
        DeviceBlacklist                 = 0x3A9E3494,
        DeviceDefaultSettings           = 0xD007E829,
        Difficulty                      = 0xCB297E3A,
        DissolveEffect                  = 0x8FDAC9B4,
        DriverBlacklist                 = 0x4F10F976,
        DungeonEncounter                = 0xFB6E72FC,
        DungeonMap                      = 0x4E8538DF,
        DungeonMapChunk                 = 0x8FC85876,
        DurabilityCosts                 = 0xB8CE321B,
        DurabilityQuality               = 0xF7808C05,
        EdgeGlowEffect                  = 0x803704B6,
        Emotes                          = 0x21091B9A,
        EmotesText                      = 0xED4E8758,
        EmotesTextData                  = 0x7765D867,
        EmotesTextSound                 = 0x1D3AC587,
        EnvironmentalDamage             = 0x6E5CA398,
        Exhaustion                      = 0x3386B543,
        Faction                         = 0x06F624D7,
        FactionGroup                    = 0x7A55B55D,
        FactionTemplate                 = 0x1018ADD5,
        FootprintTextures               = 0x2BBD5BA1,
        FootstepTerrainLookup           = 0x52AC9461,
        FriendshipRepReaction           = 0x13315BF9,
        FriendshipReputation            = 0x0DF61E79,
        FullScreenEffect                = 0x85401935,
        GMSurveyAnswers                 = 0x4405A1CA,
        GMSurveyCurrentSurvey           = 0x907149C9,
        GMSurveyQuestions               = 0xFEAFC1B9,
        GMSurveySurveys                 = 0x0C0B722F,
        GameObjectArtKit                = 0x0024BCED,
        GameObjectDiffAnimMap           = 0x174228A6,
        GameObjectDisplayInfo           = 0x6D100DCB,
        GameObjectDisplayInfoXSoundKit  = 0xDB23FBD9,
        GameObjects                     = 0x13C403A5,
        GameTips                        = 0x8978228D,
        GarrAbility                     = 0xE47316B8,
        GarrAbilityCategory             = 0x32D73CE8,
        GarrAbilityEffect               = 0xA41CF54F,
        GarrBuilding                    = 0x345B0DB7,
        GarrBuildingDoodadSet           = 0x9EBC6471,
        GarrBuildingPlotInst            = 0x94A9BA1E,
        GarrClassSpec                   = 0x4575BF0F,
        GarrClassSpecPlayerCond         = 0xDB01B862,
        GarrEncounter                   = 0xA753AC92,
        GarrEncounterSetXEncounter      = 0x9EF63764,
        GarrEncounterXMechanic          = 0x46C53A0B,
        GarrFollItemSetMember           = 0x2A41D721,
        GarrFollSupportSpell            = 0x76BC8305,
        GarrFollower                    = 0xA8D85D45,
        GarrFollowerLevelXP             = 0xDE342443,
        GarrFollowerQuality             = 0x4205184C,
        GarrFollowerSetXFollower        = 0xC1F2B6A1,
        GarrFollowerType                = 0xBFCD2376,
        GarrFollowerUICreature          = 0x9E19CD04,
        GarrFollowerXAbility            = 0x914D7D9B,
        GarrMechanic                    = 0x63AA03A4,
        GarrMechanicSetXMechanic        = 0x0DFE316B,
        GarrMechanicType                = 0xA91F6CA8,
        GarrMission                     = 0x0DF5FA28,
        GarrMissionTexture              = 0x37FC4173,
        GarrMissionType                 = 0xD8D9D218,
        GarrMissionXEncounter           = 0x6294C01F,
        GarrMissionXFollower            = 0xBB693A32,
        GarrMssnBonusAbility            = 0xC3369DE5,
        GarrPlot                        = 0x2CD8C002,
        GarrPlotBuilding                = 0x73F2572B,
        GarrPlotInstance                = 0xF3F86C96,
        GarrPlotUICategory              = 0x0FC6FEC6,
        GarrSiteLevel                   = 0x22C7158E,
        GarrSiteLevelPlotInst           = 0x69B2A3AC,
        GarrSpecialization              = 0x1EE674BD,
        GarrString                      = 0xE4FACA3A,
        GarrTalent                      = 0x2400895C,
        GarrTalentTree                  = 0x9D6A097A,
        GarrType                        = 0xD16A730B,
        GarrUiAnimClassInfo             = 0x025C3B70,
        GarrUiAnimRaceInfo              = 0x4C59D8A6,
        GemProperties                   = 0x9C00EA6D,
        GlobalStrings                   = 0xBF0BC27A,
        GlyphBindableSpell              = 0x0D3BA0F3,
        GlyphExclusiveCategory          = 0xE122AC03,
        GlyphProperties                 = 0xFAF454A9,
        GlyphRequiredSpec               = 0x8E304E55,
        GroundEffectDoodad              = 0xA5945ACA,
        GroundEffectTexture             = 0x8108D98D,
        GroupFinderActivity             = 0xAF32E8CA,
        GroupFinderActivityGrp          = 0x357024D6,
        GroupFinderCategory             = 0x2FE6EF1A,
        GuildColorBackground            = 0x7E831D78,
        GuildColorBorder                = 0x13BE3875,
        GuildColorEmblem                = 0x1B8B472E,
        GuildPerkSpells                 = 0x01956414,
        Heirloom                        = 0x2E7BAFAE,
        HelmetAnimScaling               = 0x3C808B5A,
        HelmetGeosetVisData             = 0x380E19DF,
        HighlightColor                  = 0x52191C0A,
        HolidayDescriptions             = 0x2927A4BF,
        HolidayNames                    = 0x5499185A,
        Holidays                        = 0x758E7BCC,
        ImportPriceArmor                = 0x3E372864,
        ImportPriceQuality              = 0x3C615C13,
        ImportPriceShield               = 0x2BDE6A98,
        ImportPriceWeapon               = 0x976C8F98,
        InvasionClientData              = 0x18791515,
        Item                            = 0x50238EC2,
        ItemAppearance                  = 0x42261B89,
        ItemAppearanceXUiCamera         = 0x8C3E04CB,
        ItemArmorQuality                = 0xB94A5807,
        ItemArmorShield                 = 0xFFBB8DC2,
        ItemArmorTotal                  = 0x029D50FE,
        ItemBagFamily                   = 0x11301D47,
        ItemBonus                       = 0x8318900A,
        ItemBonusListLevelDelta         = 0x39606286,
        ItemBonusTreeNode               = 0xA67E0631,
        ItemChildEquipment              = 0x1E8E6583,
        ItemClass                       = 0xB977271E,
        ItemContextPickerEntry          = 0x96A8C4D6,
        ItemCurrencyCost                = 0x6FE05AE9,
        ItemDamageAmmo                  = 0x9790C2EE,
        ItemDamageOneHand               = 0xE0A6BB08,
        ItemDamageOneHandCaster         = 0xF2972767,
        ItemDamageTwoHand               = 0xD8C5FD43,
        ItemDamageTwoHandCaster         = 0x80A1A0FA,
        ItemDisenchantLoot              = 0x66A4506E,
        ItemDisplayInfo                 = 0x986F8CD0,
        ItemDisplayInfoMaterialRes      = 0xF35AF3DB,
        ItemDisplayXUiCamera            = 0xE5973CC6,
        ItemEffect                      = 0x4002A5B1,
        ItemExtendedCost                = 0xBB858355,
        ItemGroupSounds                 = 0x9F4206C9,
        ItemLimitCategory               = 0x7BBA1EB1,
        ItemLimitCategoryCondition      = 0xD80883F0,
        ItemModifiedAppearance          = 0xE491AC55,
        ItemModifiedAppearanceExtra     = 0xD94C9544,
        ItemNameDescription             = 0x70C2E7FD,
        ItemPetFood                     = 0x30DE185C,
        ItemPriceBase                   = 0x2DE09E95,
        ItemRandomProperties            = 0x04BD338F,
        ItemRandomSuffix                = 0xE6811147,
        ItemRangedDisplayInfo           = 0x88EAC09B,
        ItemSearchName                  = 0x198E28B5,
        ItemSet                         = 0x8E741A98,
        ItemSetSpell                    = 0x8645BB79,
        Item_sparse                     = 0x919BE54E,
        ItemSpec                        = 0x08DA6E2A,
        ItemSpecOverride                = 0x149AAE79,
        ItemSubClass                    = 0x95D8638F,
        ItemSubClassMask                = 0xE5F0B775,
        ItemToBattlePet                 = 0x5D2EF1A8, // MoP - 5.4.2 (replaced by ItemToBattlePetSpecies in WoD)
        ItemToBattlePetSpecies          = 0x7185589B, // WoD - 6.0.1 (removed in legion)
        ItemUpgrade                     = 0x7006463B,
        ItemVisualEffects               = 0x926C975E,
        ItemVisuals                     = 0x77F6CC65,
        ItemXBonusTree                  = 0x325582EA,
        JournalEncounter                = 0x57382070,
        JournalEncounterCreature        = 0xACF3ADCB,
        JournalEncounterItem            = 0xF7ED685F,
        JournalEncounterSection         = 0x7956786C,
        JournalEncounterXDifficulty     = 0xA83B4856,
        JournalInstance                 = 0x713E1C99,
        JournalItemXDifficulty          = 0x286E3E37,
        JournalSectionXDifficulty       = 0x0B051170,
        JournalTier                     = 0x26D91FF9,
        JournalTierXInstance            = 0x23612F8C,
        KeyChain                        = 0x6D8A2694,
        KeystoneAffix                   = 0xC2E384E5,
        LanguageWords                   = 0xE849437C,
        Languages                       = 0xF3D3E512,
        LfgDungeonExpansion             = 0xF1FFC748,
        LfgDungeonGroup                 = 0x23F64598,
        LfgDungeons                     = 0x999BB9C2,
        LfgDungeonsGroupingMap          = 0xD6D21146,
        LfgRoleRequirement              = 0x7187CA05,
        Light                           = 0x5CCAA0BA,
        LightData                       = 0x0AD67EBF,
        LightParams                     = 0xC67F0D98,
        LightSkybox                     = 0xD364D557,
        LiquidMaterial                  = 0x8C379329,
        LiquidObject                    = 0xFC2A0DFF,
        LiquidType                      = 0x6613BED3,
        LoadingScreenTaxiSplines        = 0xE6AE2B07,
        LoadingScreens                  = 0xEF9DC6FF,
        Locale                          = 0x3F85ABB7,
        Location                        = 0x394C3727,
        Lock                            = 0xE9BECB23,
        LockType                        = 0x9349B344,
        LookAtController                = 0x5D20CF07,
        MailTemplate                    = 0xE3C5B7D1,
        ManifestInterfaceActionIcon     = 0x12A21181,
        ManifestInterfaceData           = 0xFEBBA57C,
        ManifestInterfaceItemIcon       = 0x022B23D6,
        ManifestInterfaceTOCData        = 0xE50FD32C,
        ManifestMP3                     = 0x353E4F0C,
        Map                             = 0xBD84CD62,
        MapChallengeMode                = 0x383B4C27,
        MapDifficulty                   = 0x9265F70D,
        MapDifficultyXCondition         = 0xB7A2B3BD,
        MarketingPromotionsXLocale      = 0xA1D3F1AD,
        Material                        = 0xA4C11069,
        MinorTalent                     = 0x25A192A7,
        ModelAnimCloakDampening         = 0x115B0A10,
        ModelFileData                   = 0xA161E42C,
        ModelRibbonQuality              = 0x326D6E8F,
        ModifierTree                    = 0x7E692D56,
        Mount                           = 0x96737A41,
        MountCapability                 = 0xF66E0076,
        MountTypeXCapability            = 0x28D9DEA9,
        Movie                           = 0x032DFA13,
        MovieFileData                   = 0xB8B69B3D,
        MovieVariation                  = 0x12D121A8,
        NPCSounds                       = 0x495495DF,
        NameGen                         = 0xF5FA849B,
        NamesProfanity                  = 0xDA82D96C,
        NamesReserved                   = 0x25C1CB13,
        NamesReservedLocale             = 0x3ACAE305,
        NpcModelItemSlotDisplayInfo     = 0x76C04C97,
        ObjectEffect                    = 0x67660235,
        ObjectEffectGroup               = 0x4C6EBA83,
        ObjectEffectModifier            = 0x62C90BAB,
        ObjectEffectPackage             = 0x5E3E8F24,
        ObjectEffectPackageElem         = 0xCB2273C2,
        OutlineEffect                   = 0xB94046AE,
        OverrideSpellData               = 0xCA75DF1C,
        PageTextMaterial                = 0xD243819F,
        PaperDollItemFrame              = 0xADDB889C,
        ParticleColor                   = 0xE89BEFDA,
        Path                            = 0x94F46395,
        PathNode                        = 0x3B9E4CA2,
        PathNodeProperty                = 0xFE21C024,
        PathProperty                    = 0x08E54F60,
        Phase                           = 0xF0D11963,
        PhaseShiftZoneSounds            = 0x7BB16543,
        PhaseXPhaseGroup                = 0x25CC2A59,
        PlayerCondition                 = 0xB94C2807,
        Positioner                      = 0x240D864E,
        PositionerState                 = 0x60C46E9D,
        PositionerStateEntry            = 0x461FDC45,
        PowerDisplay                    = 0x61A51B8E,
        PowerType                       = 0x8D899A57,
        PrestigeLevelInfo               = 0x51322141,
        PvpBracketTypes                 = 0xF7879101,
        PvpDifficulty                   = 0x987332DF,
        PvpItem                         = 0xF996FA59,
        PvpReward                       = 0x8B1B4749,
        PvpTalent                       = 0x63AE91A1,
        PvpTalentUnlock                 = 0x38F4D4E2,
        QuestFactionReward              = 0xBFB87048,
        QuestFeedbackEffect             = 0x79C72909,
        QuestInfo                       = 0x2D11D732,
        QuestLine                       = 0xEB57A423,
        QuestLineXQuest                 = 0x8CC17856,
        QuestMoneyReward                = 0xCF096091,
        QuestObjective                  = 0x01325CA0,
        QuestPOIBlob                    = 0xAE1CA308,
        QuestPOIPoint                   = 0x83467FEB,
        QuestPOIPointCliTask            = 0x8FCA1265,
        QuestPackageItem                = 0xCC2F84F0,
        QuestSort                       = 0x5479CB09,
        QuestV2                         = 0x3AC83109,
        QuestV2CliTask                  = 0x0F992211,
        QuestXP                         = 0x3D89A572,
        RacialMounts                    = 0x426026C2,
        RandPropPoints                  = 0x5D8CEFA6,
        ResearchBranch                  = 0x420F9A85,
        ResearchField                   = 0xDDE2C5CF,
        ResearchProject                 = 0x81560FC3,
        ResearchSite                    = 0x9C31AE60,
        Resistances                     = 0x91BB4526,
        RewardPack                      = 0xCEF864BC,
        RewardPackXCurrencyType         = 0xD3DCF67F,
        RewardPackXItem                 = 0x7F87A2C7,
        RibbonQuality                   = 0x8E858136,
        RulesetItemUpgrade              = 0x6DB7086C,
        ScalingStatDistribution         = 0x45D2FA27,
        Scenario                        = 0x830F3A66,
        ScenarioEventEntry              = 0xC194468C,
        ScenarioStep                    = 0x96679B72,
        SceneScript                     = 0xD4B163CC,
        SceneScriptPackage              = 0xE8CB5E09,
        SceneScriptPackageMember        = 0xE44DB71C,
        ScheduledInterval               = 0xB2BB19EB,
        ScheduledWorldState             = 0x3853E6B7,
        ScheduledWorldStateGroup        = 0x57D3B0F1,
        ScheduledWorldStateXUniqCat     = 0x9716FC4C,
        ScreenEffect                    = 0xB33F3964,
        ScreenLocation                  = 0x6CBB84DF,
        SeamlessSite                    = 0x1EF95B83,
        ServerMessages                  = 0xBD158365,
        ShadowyEffect                   = 0xADACD19B,
        SkillLine                       = 0xB53DC9D6,
        SkillLineAbility                = 0xFF4446F6,
        SkillRaceClassInfo              = 0x06ADE420,
        SoundAmbience                   = 0x35F9DE58,
        SoundAmbienceFlavor             = 0x2691DC13,
        SoundBus                        = 0x072CA15A,
        SoundEmitterPillPoints          = 0xD8A1D70C,
        SoundEmitters                   = 0xC638B8D4,
        SoundFilter                     = 0x0EF0A657,
        SoundFilterElem                 = 0xA17FA21E,
        SoundKit                        = 0x36237731,
        SoundKitAdvanced                = 0xC0A5F8C6,
        SoundKitChild                   = 0x2BE0E266,
        SoundKitEntry                   = 0xC2B150C7,
        SoundKitFallback                = 0xE98312F8,
        SoundOverride                   = 0x8E8053CC,
        SoundProviderPreferences        = 0xBAA71EA8,
        SourceInfo                      = 0x3C34F90F,
        SpamMessages                    = 0x91AB8126,
        SpecializationSpells            = 0x4FBA0E5C,
        Spell                           = 0xE111669E,
        SpellActionBarPref              = 0x84B0BDD7,
        SpellActivationOverlay          = 0xF8685781,
        SpellAuraOptions                = 0xF42FC065,
        SpellAuraRestrictions           = 0xBA978F4E,
        SpellAuraVisXChrSpec            = 0x7CF13280,
        SpellAuraVisibility             = 0xE86AED45,
        SpellCastTimes                  = 0xFDBA5A66,
        SpellCastingRequirements        = 0x61025756,
        SpellCategories                 = 0xDBE7F829,
        SpellCategory                   = 0xD0C3D18E,
        SpellChainEffects               = 0x1EDACEA1,
        SpellClassOptions               = 0x288EAB81,
        SpellCooldowns                  = 0xF9F37C57,
        SpellDescriptionVariables       = 0x3CC89C00,
        SpellDispelType                 = 0x2B7C0063,
        SpellDuration                   = 0xB423FA7A,
        SpellEffect                     = 0xF04238A5,
        SpellEffectCameraShakes         = 0x73985069,
        SpellEffectEmission             = 0xC327CDC8,
        SpellEffectGroupSize            = 0x23BF7E10,
        SpellEffectScaling              = 0x9DADE032,
        SpellEquippedItems              = 0xE44ABBD4,
        SpellFlyout                     = 0xB4BC3BE6,
        SpellFlyoutItem                 = 0xD0BEE46B,
        SpellFocusObject                = 0xB99DB712,
        SpellIcon                       = 0x00E38DEC,
        SpellInterrupts                 = 0x668FAE03,
        SpellItemEnchantment            = 0xE05AC589,
        SpellItemEnchantmentCondition   = 0xF9513930,
        SpellKeyboundOverride           = 0xD4B64DCD,
        SpellLabel                      = 0x30769020,
        SpellLearnSpell                 = 0xDBEDF603,
        SpellLevels                     = 0x1DDEC5E6,
        SpellMechanic                   = 0x726D2B3E,
        SpellMisc                       = 0xC603EE28,
        SpellMiscDifficulty             = 0x7FC0A695,
        SpellMissile                    = 0x688F7A07,
        SpellMissileMotion              = 0x37717679,
        SpellPower                      = 0xA1ACE1DF,
        SpellPowerDifficulty            = 0x7EA08450,
        SpellProceduralEffect           = 0xF6BC85DF,
        SpellProcsPerMinute             = 0xD0768C6C,
        SpellProcsPerMinuteMod          = 0xEB24B92C,
        SpellRadius                     = 0xAB7E4841,
        SpellRange                      = 0xE051A69C,
        SpellReagents                   = 0xAB66C99F,
        SpellReagentsCurrency           = 0x2049B60C,
        SpellRuneCost                   = 0x1A27961E, // WoD - 6.0.1
        SpellScaling                    = 0x40E92D65,
        SpellShapeshift                 = 0xBC91EA17,
        SpellShapeshiftForm             = 0xF952B945,
        SpellSpecialUnitEffect          = 0xAFADE934,
        SpellTargetRestrictions         = 0xE064A75C,
        SpellTotems                     = 0xA50F8A31,
        SpellVisual                     = 0xF72496D9,
        SpellVisualAnim                 = 0x3334A75E,
        SpellVisualColorEffect          = 0x58E72946,
        SpellVisualEffectName           = 0x02E18F32,
        SpellVisualKit                  = 0xF483EADB,
        SpellVisualKitAreaModel         = 0x208AB51D,
        SpellVisualKitEffect            = 0x4666ED42,
        SpellVisualKitModelAttach       = 0xF07194C3,
        SpellVisualMissile              = 0x51A28350,
        SpellXSpellVisual               = 0x27B7A01A,
        Startup_Strings                 = 0xFB0657CD,
        Stationery                      = 0xAF0DC253,
        StringLookups                   = 0x4A5D42EB,
        SummonProperties                = 0x33C9E1A8,
        TactKey                         = 0xDF2F53CF,
        TactKeyLookup                   = 0xAFC190D1,
        Talent                          = 0xF9A4265F,
        TaxiNodes                       = 0x50D91A78,
        TaxiPath                        = 0xAB30A45C,
        TaxiPathNode                    = 0xE5E988BC,
        TerrainMaterial                 = 0x32573345,
        TerrainType                     = 0x8F38A4B1,
        TerrainTypeSounds               = 0xF3EB5A27,
        TextureBlendSet                 = 0x95C24ED7,
        TextureFileData                 = 0x1A473014,
        TotemCategory                   = 0xA7A2F29A,
        Toy                             = 0x7B03245C,
        TradeSkillCategory              = 0x253A9B6B,
        TradeSkillItem                  = 0xB50CA635,
        TransformMatrix                 = 0x0A5DF5FA,
        TransmogSet                     = 0x15393898,
        TransmogSetItem                 = 0x1E21AFB4,
        TransportAnimation              = 0x6B9AEBE5,
        TransportPhysics                = 0xD04684DD,
        TransportRotation               = 0x9645753D,
        Trophy                          = 0xF13B375C,
        UiCamFbackTransmogChrRace       = 0x4D4AF767,
        UiCamFbackTransmogWeapon        = 0x4193DD76,
        UiCamera                        = 0xF6A91AC1,
        UiCameraType                    = 0x36886009,
        UiMapPOI                        = 0xBA5C035B,
        UiTextureAtlas                  = 0x894D3B63,
        UiTextureAtlasMember            = 0xB5307A56,
        UiTextureKit                    = 0x15EC48BB,
        UnitBlood                       = 0xDB7B2578,
        UnitBloodLevels                 = 0x0B19E2A8,
        UnitCondition                   = 0x0E540EFD,
        UnitPowerBar                    = 0x4541CDC7,
        Vehicle                         = 0x0A9F6ABF,
        VehicleSeat                     = 0xD4A85CEB,
        VehicleUIIndSeat                = 0x739EAFD1,
        VehicleUIIndicator              = 0x81D11838,
        VideoHardware                   = 0x404980FC,
        Vignette                        = 0xEFB13552,
        VocalUISounds                   = 0x5223195A,
        WMOAreaTable                    = 0xC74FBDEB,
        WbAccessControlList             = 0x580B4EF3,
        WbCertBlacklist                 = 0xCDAB90DF,
        WbCertWhitelist                 = 0x885585BD,
        WbPermissions                   = 0xF827ECFB,
        WeaponImpactSounds              = 0xAE23C39A,
        WeaponSwingSounds2              = 0xC809AA0D,
        WeaponTrail                     = 0xA42476ED,
        WeaponTrailModelDef             = 0xA0E73181,
        WeaponTrailParam                = 0x3CEEC8C5,
        Weather                         = 0xC3062B9A,
        WindSettings                    = 0x72B25981,
        WmoMinimapTexture               = 0xB1C5A0F8,
        WorldBossLockout                = 0xF416A54C,
        WorldChunkSounds                = 0x9959835E,
        WorldEffect                     = 0xDA728027,
        WorldElapsedTimer               = 0xC7A973A1,
        WorldMapArea                    = 0x53B09981,
        WorldMapContinent               = 0x8BD32359,
        WorldMapOverlay                 = 0x1D740E72,
        WorldMapTransforms              = 0x1621F58B,
        WorldStateExpression            = 0x1D53EB74,
        WorldStateUI                    = 0x31314060,
        WorldStateZoneSounds            = 0x4DABD3FB,
        World_PVP_Area                  = 0xAFE24F5A,
        WorldSafeLocs                   = 0xD3E152D4,
        ZoneIntroMusicTable             = 0x21497AB7,
        ZoneLight                       = 0x59F2EB50,
        ZoneLightPoint                  = 0x1CF9216D,
        ZoneMusic                       = 0xF2A7C540,
    }
}
