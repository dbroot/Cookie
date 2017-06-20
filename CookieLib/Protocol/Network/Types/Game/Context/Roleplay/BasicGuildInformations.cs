﻿using Cookie.IO;
using Cookie.Protocol.Network.Types.Game.Social;

namespace Cookie.Protocol.Network.Types.Game.Context.Roleplay
{
    public class BasicGuildInformations : AbstractSocialGroupInfos
    {
        public new const short ProtocolId = 365;
        public override short TypeID { get { return ProtocolId; } }

        public uint GuildId;
        public string GuildName;
        public sbyte GuildLevel;

        public BasicGuildInformations() { }

        public BasicGuildInformations(uint guildId, string guildName, sbyte guildLevel)
        {
            GuildId = guildId;
            GuildName = guildName;
            GuildLevel = guildLevel;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(GuildId);
            writer.WriteUTF(GuildName);
            writer.WriteSByte(GuildLevel);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            GuildId = reader.ReadVarUhInt();
            GuildName = reader.ReadUTF();
            GuildLevel = reader.ReadSByte();
        }
    }
}
