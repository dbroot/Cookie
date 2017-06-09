//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Storage
{
    using Cookie.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class StorageObjectsUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6036;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItem> m_objectList;
        
        public virtual List<ObjectItem> ObjectList
        {
            get
            {
                return m_objectList;
            }
            set
            {
                m_objectList = value;
            }
        }
        
        public StorageObjectsUpdateMessage(List<ObjectItem> objectList)
        {
            m_objectList = objectList;
        }
        
        public StorageObjectsUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_objectList.Count)));
            int objectListIndex;
            for (objectListIndex = 0; (objectListIndex < m_objectList.Count); objectListIndex = (objectListIndex + 1))
            {
                ObjectItem objectToSend = m_objectList[objectListIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int objectListCount = reader.ReadUShort();
            int objectListIndex;
            m_objectList = new System.Collections.Generic.List<ObjectItem>();
            for (objectListIndex = 0; (objectListIndex < objectListCount); objectListIndex = (objectListIndex + 1))
            {
                ObjectItem objectToAdd = new ObjectItem();
                objectToAdd.Deserialize(reader);
                m_objectList.Add(objectToAdd);
            }
        }
    }
}
