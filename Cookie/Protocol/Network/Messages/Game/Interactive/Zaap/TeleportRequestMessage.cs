//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Interactive.Zaap
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class TeleportRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5961;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_teleporterType;
        
        public virtual byte TeleporterType
        {
            get
            {
                return m_teleporterType;
            }
            set
            {
                m_teleporterType = value;
            }
        }
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        public TeleportRequestMessage(byte teleporterType, int mapId)
        {
            m_teleporterType = teleporterType;
            m_mapId = mapId;
        }
        
        public TeleportRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_teleporterType);
            writer.WriteInt(m_mapId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_teleporterType = reader.ReadByte();
            m_mapId = reader.ReadInt();
        }
    }
}
