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
    
    
    public class ExchangeBidHouseListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5807;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_ObjectId;
        
        public virtual ushort ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        public ExchangeBidHouseListMessage(ushort objectId)
        {
            m_ObjectId = objectId;
        }
        
        public ExchangeBidHouseListMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_ObjectId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_ObjectId = reader.ReadVarUhShort();
        }
    }
}
