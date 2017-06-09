//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Houses
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class HouseBuyResultMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5735;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private bool m_bought;
        
        public virtual bool Bought
        {
            get
            {
                return m_bought;
            }
            set
            {
                m_bought = value;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
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
        
        private ulong m_realPrice;
        
        public virtual ulong RealPrice
        {
            get
            {
                return m_realPrice;
            }
            set
            {
                m_realPrice = value;
            }
        }
        
        public HouseBuyResultMessage(bool secondHand, bool bought, uint houseId, int instanceId, ulong realPrice)
        {
            m_secondHand = secondHand;
            m_bought = bought;
            m_houseId = houseId;
            m_instanceId = instanceId;
            m_realPrice = realPrice;
        }
        
        public HouseBuyResultMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_secondHand);
            BooleanByteWrapper.SetFlag(1, flag, m_bought);
            writer.WriteByte(flag);
            writer.WriteVarUhInt(m_houseId);
            writer.WriteInt(m_instanceId);
            writer.WriteVarUhLong(m_realPrice);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            byte flag = reader.ReadByte();
            m_secondHand = BooleanByteWrapper.GetFlag(flag, 0);
            m_bought = BooleanByteWrapper.GetFlag(flag, 1);
            m_houseId = reader.ReadVarUhInt();
            m_instanceId = reader.ReadInt();
            m_realPrice = reader.ReadVarUhLong();
        }
    }
}
