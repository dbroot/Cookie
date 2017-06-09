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
    
    
    public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5950;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_itemUID;
        
        public virtual int ItemUID
        {
            get
            {
                return m_itemUID;
            }
            set
            {
                m_itemUID = value;
            }
        }
        
        public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            m_itemUID = itemUID;
        }
        
        public ExchangeBidHouseInListRemovedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_itemUID);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_itemUID = reader.ReadInt();
        }
    }
}
