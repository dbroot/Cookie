﻿using Cookie.IO;

namespace Cookie.Protocol.Network.Types.Game.Approach
{
    public class ServerSessionConstant : NetworkType
    {
        public const short ProtocolId = 430;
        public override short TypeID { get { return ProtocolId; } }

        public ushort ObjectID { get; set; }

        public ServerSessionConstant() { }

        public ServerSessionConstant(ushort objectId)
        {
            ObjectID = objectId;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(ObjectID);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            ObjectID = reader.ReadVarUhShort();
        }
    }
}
