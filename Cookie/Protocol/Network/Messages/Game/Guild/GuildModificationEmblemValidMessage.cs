//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Guild
{
    using Cookie.Protocol.Network.Types.Game.Guild;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildModificationEmblemValidMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6328;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_guildEmblem;
        
        public virtual GuildEmblem GuildEmblem
        {
            get
            {
                return m_guildEmblem;
            }
            set
            {
                m_guildEmblem = value;
            }
        }
        
        public GuildModificationEmblemValidMessage(GuildEmblem guildEmblem)
        {
            m_guildEmblem = guildEmblem;
        }
        
        public GuildModificationEmblemValidMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_guildEmblem = new GuildEmblem();
            m_guildEmblem.Deserialize(reader);
        }
    }
}
