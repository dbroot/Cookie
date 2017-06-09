//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ObjectFeedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6290;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        private uint m_foodUID;
        
        public virtual uint FoodUID
        {
            get
            {
                return m_foodUID;
            }
            set
            {
                m_foodUID = value;
            }
        }
        
        private uint m_foodQuantity;
        
        public virtual uint FoodQuantity
        {
            get
            {
                return m_foodQuantity;
            }
            set
            {
                m_foodQuantity = value;
            }
        }
        
        public ObjectFeedMessage(uint objectUID, uint foodUID, uint foodQuantity)
        {
            m_objectUID = objectUID;
            m_foodUID = foodUID;
            m_foodQuantity = foodQuantity;
        }
        
        public ObjectFeedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_objectUID);
            writer.WriteVarUhInt(m_foodUID);
            writer.WriteVarUhInt(m_foodQuantity);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_objectUID = reader.ReadVarUhInt();
            m_foodUID = reader.ReadVarUhInt();
            m_foodQuantity = reader.ReadVarUhInt();
        }
    }
}
