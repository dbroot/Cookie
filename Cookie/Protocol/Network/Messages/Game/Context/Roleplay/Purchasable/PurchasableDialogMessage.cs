//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Purchasable
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PurchasableDialogMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5739;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_buyOrSell;
        
        public virtual bool BuyOrSell
        {
            get
            {
                return m_buyOrSell;
            }
            set
            {
                m_buyOrSell = value;
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
        
        private uint m_purchasableId;
        
        public virtual uint PurchasableId
        {
            get
            {
                return m_purchasableId;
            }
            set
            {
                m_purchasableId = value;
            }
        }
        
        private int m_purchasableInstanceId;
        
        public virtual int PurchasableInstanceId
        {
            get
            {
                return m_purchasableInstanceId;
            }
            set
            {
                m_purchasableInstanceId = value;
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
        
        public PurchasableDialogMessage(bool buyOrSell, bool secondHand, uint purchasableId, int purchasableInstanceId, ulong price)
        {
            m_buyOrSell = buyOrSell;
            m_secondHand = secondHand;
            m_purchasableId = purchasableId;
            m_purchasableInstanceId = purchasableInstanceId;
            m_price = price;
        }
        
        public PurchasableDialogMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_buyOrSell);
            BooleanByteWrapper.SetFlag(1, flag, m_secondHand);
            writer.WriteByte(flag);
            writer.WriteVarUhInt(m_purchasableId);
            writer.WriteInt(m_purchasableInstanceId);
            writer.WriteVarUhLong(m_price);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            byte flag = reader.ReadByte();
            m_buyOrSell = BooleanByteWrapper.GetFlag(flag, 0);
            m_secondHand = BooleanByteWrapper.GetFlag(flag, 1);
            m_purchasableId = reader.ReadVarUhInt();
            m_purchasableInstanceId = reader.ReadInt();
            m_price = reader.ReadVarUhLong();
        }
    }
}