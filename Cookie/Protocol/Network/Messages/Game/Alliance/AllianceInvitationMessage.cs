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
    
    
    public class AllianceInvitationMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6395;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_targetId;
        
        public virtual ulong TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        public AllianceInvitationMessage(ulong targetId)
        {
            m_targetId = targetId;
        }
        
        public AllianceInvitationMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhLong(m_targetId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_targetId = reader.ReadVarUhLong();
        }
    }
}
