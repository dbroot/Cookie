//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangeOkMultiCraftMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5768;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_initiatorId;
        
        public virtual ulong InitiatorId
        {
            get
            {
                return m_initiatorId;
            }
            set
            {
                m_initiatorId = value;
            }
        }
        
        private ulong m_otherId;
        
        public virtual ulong OtherId
        {
            get
            {
                return m_otherId;
            }
            set
            {
                m_otherId = value;
            }
        }
        
        private byte m_role;
        
        public virtual byte Role
        {
            get
            {
                return m_role;
            }
            set
            {
                m_role = value;
            }
        }
        
        public ExchangeOkMultiCraftMessage(ulong initiatorId, ulong otherId, byte role)
        {
            m_initiatorId = initiatorId;
            m_otherId = otherId;
            m_role = role;
        }
        
        public ExchangeOkMultiCraftMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhLong(m_initiatorId);
            writer.WriteVarUhLong(m_otherId);
            writer.WriteByte(m_role);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_initiatorId = reader.ReadVarUhLong();
            m_otherId = reader.ReadVarUhLong();
            m_role = reader.ReadByte();
        }
    }
}
