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
    
    
    public class ExchangeStartOkRecycleTradeMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6600;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_percentToPrism;
        
        public virtual short PercentToPrism
        {
            get
            {
                return m_percentToPrism;
            }
            set
            {
                m_percentToPrism = value;
            }
        }
        
        private short m_percentToPlayer;
        
        public virtual short PercentToPlayer
        {
            get
            {
                return m_percentToPlayer;
            }
            set
            {
                m_percentToPlayer = value;
            }
        }
        
        public ExchangeStartOkRecycleTradeMessage(short percentToPrism, short percentToPlayer)
        {
            m_percentToPrism = percentToPrism;
            m_percentToPlayer = percentToPlayer;
        }
        
        public ExchangeStartOkRecycleTradeMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(m_percentToPrism);
            writer.WriteShort(m_percentToPlayer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_percentToPrism = reader.ReadShort();
            m_percentToPlayer = reader.ReadShort();
        }
    }
}
