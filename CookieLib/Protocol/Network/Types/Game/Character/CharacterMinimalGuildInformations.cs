﻿using Cookie.IO;
using Cookie.Protocol.Network.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Network.Types.Game.Character
{
    public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
    {
        public new const short ProtocolId = 445;
        public override short TypeID { get { return ProtocolId; } }

        public BasicGuildInformations Guild { get; set; }

        public CharacterMinimalGuildInformations() { }

        public CharacterMinimalGuildInformations(BasicGuildInformations guild)
        {
            Guild = guild;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            Guild.Serialize(writer);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            Guild = new BasicGuildInformations();
            Guild.Deserialize(reader);
        }
    }
}
