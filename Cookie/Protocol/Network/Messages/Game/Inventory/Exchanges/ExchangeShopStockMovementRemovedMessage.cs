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
    
    
    public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5907;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectId;
        
        public virtual uint ObjectId
        {
            get
            {
                return m_objectId;
            }
            set
            {
                m_objectId = value;
            }
        }
        
        public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            m_objectId = objectId;
        }
        
        public ExchangeShopStockMovementRemovedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_objectId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_objectId = reader.ReadVarUhInt();
        }
    }
}
