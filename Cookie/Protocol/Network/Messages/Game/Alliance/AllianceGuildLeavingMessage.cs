//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Alliance
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class AllianceGuildLeavingMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6399;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_kicked;
        
        public virtual bool Kicked
        {
            get
            {
                return m_kicked;
            }
            set
            {
                m_kicked = value;
            }
        }
        
        private uint m_guildId;
        
        public virtual uint GuildId
        {
            get
            {
                return m_guildId;
            }
            set
            {
                m_guildId = value;
            }
        }
        
        public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            m_kicked = kicked;
            m_guildId = guildId;
        }
        
        public AllianceGuildLeavingMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_kicked);
            writer.WriteVarUhInt(m_guildId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_kicked = reader.ReadBoolean();
            m_guildId = reader.ReadVarUhInt();
        }
    }
}
