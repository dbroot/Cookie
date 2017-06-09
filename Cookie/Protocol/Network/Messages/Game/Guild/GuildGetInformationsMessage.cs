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
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildGetInformationsMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5550;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_infoType;
        
        public virtual byte InfoType
        {
            get
            {
                return m_infoType;
            }
            set
            {
                m_infoType = value;
            }
        }
        
        public GuildGetInformationsMessage(byte infoType)
        {
            m_infoType = infoType;
        }
        
        public GuildGetInformationsMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_infoType);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_infoType = reader.ReadByte();
        }
    }
}
