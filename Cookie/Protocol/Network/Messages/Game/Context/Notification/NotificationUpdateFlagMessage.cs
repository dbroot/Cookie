//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Notification
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class NotificationUpdateFlagMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6090;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_index;
        
        public virtual ushort Index
        {
            get
            {
                return m_index;
            }
            set
            {
                m_index = value;
            }
        }
        
        public NotificationUpdateFlagMessage(ushort index)
        {
            m_index = index;
        }
        
        public NotificationUpdateFlagMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_index);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_index = reader.ReadVarUhShort();
        }
    }
}
