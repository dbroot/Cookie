//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.House
{
    using Cookie.IO;

    public class HouseInformationsInside : HouseInformations
    {
        
        public new const short ProtocolId = 218;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_instanceId;
        
        public virtual int InstanceId
        {
            get
            {
                return m_instanceId;
            }
            set
            {
                m_instanceId = value;
            }
        }
        
        private bool m_secondHand;
        
        public virtual bool SecondHand
        {
            get
            {
                return m_secondHand;
            }
            set
            {
                m_secondHand = value;
            }
        }
        
        private int m_ownerId;
        
        public virtual int OwnerId
        {
            get
            {
                return m_ownerId;
            }
            set
            {
                m_ownerId = value;
            }
        }
        
        private string m_ownerName;
        
        public virtual string OwnerName
        {
            get
            {
                return m_ownerName;
            }
            set
            {
                m_ownerName = value;
            }
        }
        
        private ulong m_price;
        
        public virtual ulong Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }
        
        private bool m_isLocked;
        
        public virtual bool IsLocked
        {
            get
            {
                return m_isLocked;
            }
            set
            {
                m_isLocked = value;
            }
        }
        
        private short m_worldX;
        
        public virtual short WorldX
        {
            get
            {
                return m_worldX;
            }
            set
            {
                m_worldX = value;
            }
        }
        
        private short m_worldY;
        
        public virtual short WorldY
        {
            get
            {
                return m_worldY;
            }
            set
            {
                m_worldY = value;
            }
        }
        
        public HouseInformationsInside(int instanceId, bool secondHand, int ownerId, string ownerName, ulong price, bool isLocked, short worldX, short worldY)
        {
            m_instanceId = instanceId;
            m_secondHand = secondHand;
            m_ownerId = ownerId;
            m_ownerName = ownerName;
            m_price = price;
            m_isLocked = isLocked;
            m_worldX = worldX;
            m_worldY = worldY;
        }
        
        public HouseInformationsInside()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_instanceId);
            writer.WriteBoolean(m_secondHand);
            writer.WriteInt(m_ownerId);
            writer.WriteUTF(m_ownerName);
            writer.WriteVarUhLong(m_price);
            writer.WriteBoolean(m_isLocked);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_instanceId = reader.ReadInt();
            m_secondHand = reader.ReadBoolean();
            m_ownerId = reader.ReadInt();
            m_ownerName = reader.ReadUTF();
            m_price = reader.ReadVarUhLong();
            m_isLocked = reader.ReadBoolean();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
        }
    }
}
