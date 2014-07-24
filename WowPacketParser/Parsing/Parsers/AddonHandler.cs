using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Parsing.Parsers
{
    public static class AddonHandler
    {
        private static int _addonCount = -1;

        public static void ReadClientAddonsList(ref Packet packet)
        {
            var decompCount = packet.ReadInt32();
            var newPacket = packet.Inflate(decompCount, false);

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_0_8_9464))
            {
                var count = newPacket.ReadInt32("Addons Count");
                _addonCount = count;

                for (var i = 0; i < count; i++)
                {
                    newPacket.ReadCString("Name", i);
                    newPacket.ReadBoolean("Uses public key", i);
                    newPacket.ReadInt32("Public key CRC", i);
                    newPacket.ReadInt32("URL file CRC", i);
                }

                newPacket.ReadTime("Time");
            }
            else
            {
                int count = 0;

                while (newPacket.Position != newPacket.Length)
                {
                    newPacket.ReadCString("Name");
                    newPacket.ReadBoolean("Enabled");
                    newPacket.ReadInt32("CRC");
                    newPacket.ReadInt32("Unk Int32");

                    count++;
                }

                _addonCount = count;
            }

            newPacket.ClosePacket(false);
        }

        [Parser(Opcode.SMSG_ADDON_INFO)]
        public static void HandleServerAddonsList(Packet packet)
        {
            // This packet requires _addonCount from CMSG_AUTH_SESSION to be parsed.
            if (_addonCount == -1)
            {
                packet.WriteLine("CMSG_AUTH_SESSION was not received - cannot successfully parse this packet.");
                packet.ReadToEnd();
                return;
            }

            for (var i = 0; i < _addonCount; i++)
            {
                packet.ReadByte("Addon State", i);

                var sendCrc = packet.ReadBoolean("Use CRC", i);

                if (sendCrc)
                {
                    var usePublicKey = packet.ReadBoolean("Use Public Key", i);

                    if (usePublicKey)
                    {
                        var pubKey = packet.ReadBytes(256);
                        packet.WriteLine("[{0}] Name MD5: {1}", i, Utilities.ByteArrayToHexString(pubKey));
                    }

                    packet.ReadInt32("Unk Int32", i);
                }

                if (packet.ReadBoolean("Use URL File", i))
                    packet.ReadCString("Addon URL File", i);
            }

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_0_8_9464))
            {
                var bannedCount = packet.ReadInt32("Banned Addons Count");

                for (var i = 0; i < bannedCount; i++)
                {
                    packet.ReadInt32("ID", i);

                    var unkStr2 = packet.ReadBytes(16);
                    packet.WriteLine("[{0}] Name MD5: {1}", i, Utilities.ByteArrayToHexString(unkStr2));

                    var unkStr3 = packet.ReadBytes(16);
                    packet.WriteLine("[{0}] Version MD5: {1}", i, Utilities.ByteArrayToHexString(unkStr3));

                    packet.ReadTime("Time", i);

                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_3_3a_11723))
                        packet.ReadInt32("Is banned", i);
                }
            }
        }

        // Changed on 4.3.0, bitshifted
        [Parser(Opcode.CMSG_ADDON_REGISTERED_PREFIXES, ClientVersionBuild.V4_1_0_13914, ClientVersionBuild.V4_3_0_15005)]
        public static void HandleAddonPrefixes(Packet packet)
        {
            var count = packet.ReadUInt32("Count");
            for (var i = 0; i < count; ++i)
                packet.ReadCString("Addon", i);
        }

        [Parser(Opcode.CMSG_ADDON_REGISTERED_PREFIXES, ClientVersionBuild.V4_3_0_15005)]
        public static void HandleAddonPrefixes434(Packet packet)
        {
            var count = packet.ReadBits("Count", 25);
            var lengths = new int[count];
            for (var i = 0; i < count; ++i)
                lengths[i] = (int)packet.ReadBits(5);

            for (var i = 0; i < count; ++i)
                packet.ReadWoWString("Addon", lengths[i], i);
        }

        [Parser(Opcode.CMSG_UNREGISTER_ALL_ADDON_PREFIXES)]
        public static void HandleAddonNull(Packet packet)
        {
        }
    }
}
