﻿using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages.Handshake
{
    public class ProtocolRequired : NetworkMessage
    {
        public const uint ProtocolId = 1;
        public override uint MessageID => ProtocolId;

        public int RequiredVersion { get; set; }
        public int CurrentVersion { get; set; }

        public ProtocolRequired() { }

        public ProtocolRequired(int requiredVersion, int currentVersion)
        {
            this.RequiredVersion = requiredVersion;
            this.CurrentVersion = currentVersion;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(RequiredVersion);
            writer.WriteInt(CurrentVersion);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            RequiredVersion = reader.ReadInt();
            if (RequiredVersion < 0)
                throw new Exception("Forbidden value on RequiredVersion = " + RequiredVersion + ", it doesn't respect the following condition : requiredVersion < 0");
            CurrentVersion = reader.ReadInt();
            if (CurrentVersion < 0)
                throw new Exception("Forbidden value on CurrentVersion = " + CurrentVersion + ", it doesn't respect the following condition : currentVersion < 0");
        }

    }
}
