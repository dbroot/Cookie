//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Friend
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class FriendWarnOnLevelGainStateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6078;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_enable;
        
        public virtual bool Enable
        {
            get
            {
                return m_enable;
            }
            set
            {
                m_enable = value;
            }
        }
        
        public FriendWarnOnLevelGainStateMessage(bool enable)
        {
            m_enable = enable;
        }
        
        public FriendWarnOnLevelGainStateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_enable);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_enable = reader.ReadBoolean();
        }
    }
}
