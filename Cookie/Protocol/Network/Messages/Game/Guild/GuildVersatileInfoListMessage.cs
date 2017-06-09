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
    using Cookie.Protocol.Network.Types.Game.Social;
    using Cookie.Protocol.Network;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildVersatileInfoListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6435;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GuildVersatileInformations> m_guilds;
        
        public virtual List<GuildVersatileInformations> Guilds
        {
            get
            {
                return m_guilds;
            }
            set
            {
                m_guilds = value;
            }
        }
        
        public GuildVersatileInfoListMessage(List<GuildVersatileInformations> guilds)
        {
            m_guilds = guilds;
        }
        
        public GuildVersatileInfoListMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_guilds.Count)));
            int guildsIndex;
            for (guildsIndex = 0; (guildsIndex < m_guilds.Count); guildsIndex = (guildsIndex + 1))
            {
                GuildVersatileInformations objectToSend = m_guilds[guildsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int guildsCount = reader.ReadUShort();
            int guildsIndex;
            m_guilds = new System.Collections.Generic.List<GuildVersatileInformations>();
            for (guildsIndex = 0; (guildsIndex < guildsCount); guildsIndex = (guildsIndex + 1))
            {
                GuildVersatileInformations objectToAdd = ProtocolTypeManager.GetInstance<GuildVersatileInformations>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_guilds.Add(objectToAdd);
            }
        }
    }
}
