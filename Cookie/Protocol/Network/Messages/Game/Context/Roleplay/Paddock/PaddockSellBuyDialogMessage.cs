//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Paddock
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PaddockSellBuyDialogMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6018;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_bsell;
        
        public virtual bool Bsell
        {
            get
            {
                return m_bsell;
            }
            set
            {
                m_bsell = value;
            }
        }
        
        private uint m_ownerId;
        
        public virtual uint OwnerId
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
        
        public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, ulong price)
        {
            m_bsell = bsell;
            m_ownerId = ownerId;
            m_price = price;
        }
        
        public PaddockSellBuyDialogMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_bsell);
            writer.WriteVarUhInt(m_ownerId);
            writer.WriteVarUhLong(m_price);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_bsell = reader.ReadBoolean();
            m_ownerId = reader.ReadVarUhInt();
            m_price = reader.ReadVarUhLong();
        }
    }
}
