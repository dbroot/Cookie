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
    using Cookie.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangeStartedTaxCollectorShopMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6664;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItem> m_objects;
        
        public virtual List<ObjectItem> Objects
        {
            get
            {
                return m_objects;
            }
            set
            {
                m_objects = value;
            }
        }
        
        private ulong m_kamas;
        
        public virtual ulong Kamas
        {
            get
            {
                return m_kamas;
            }
            set
            {
                m_kamas = value;
            }
        }
        
        public ExchangeStartedTaxCollectorShopMessage(List<ObjectItem> objects, ulong kamas)
        {
            m_objects = objects;
            m_kamas = kamas;
        }
        
        public ExchangeStartedTaxCollectorShopMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_objects.Count)));
            int objectsIndex;
            for (objectsIndex = 0; (objectsIndex < m_objects.Count); objectsIndex = (objectsIndex + 1))
            {
                ObjectItem objectToSend = m_objects[objectsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteVarUhLong(m_kamas);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int objectsCount = reader.ReadUShort();
            int objectsIndex;
            m_objects = new System.Collections.Generic.List<ObjectItem>();
            for (objectsIndex = 0; (objectsIndex < objectsCount); objectsIndex = (objectsIndex + 1))
            {
                ObjectItem objectToAdd = new ObjectItem();
                objectToAdd.Deserialize(reader);
                m_objects.Add(objectToAdd);
            }
            m_kamas = reader.ReadVarUhLong();
        }
    }
}
