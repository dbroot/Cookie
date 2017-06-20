//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Cookie.Network;

namespace Cookie.Protocol.Network.Types.Game.Data.Items
{
    using Cookie.IO;
    using Cookie.Protocol.Network.Types.Game.Data.Items.Effects;
    using System.Collections.Generic;


    public class BidExchangerObjectInfo : NetworkType
    {
        
        public const short ProtocolId = 122;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectEffect> m_effects;
        
        public virtual List<ObjectEffect> Effects
        {
            get
            {
                return m_effects;
            }
            set
            {
                m_effects = value;
            }
        }
        
        private List<System.UInt64> m_prices;
        
        public virtual List<System.UInt64> Prices
        {
            get
            {
                return m_prices;
            }
            set
            {
                m_prices = value;
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
        
        public BidExchangerObjectInfo(List<ObjectEffect> effects, List<System.UInt64> prices, uint objectUID)
        {
            m_effects = effects;
            m_prices = prices;
            m_objectUID = objectUID;
        }
        
        public BidExchangerObjectInfo()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_effects.Count)));
            int effectsIndex;
            for (effectsIndex = 0; (effectsIndex < m_effects.Count); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToSend = m_effects[effectsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_prices.Count)));
            int pricesIndex;
            for (pricesIndex = 0; (pricesIndex < m_prices.Count); pricesIndex = (pricesIndex + 1))
            {
                writer.WriteVarUhLong(m_prices[pricesIndex]);
            }
            writer.WriteVarUhInt(m_objectUID);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int effectsCount = reader.ReadUShort();
            int effectsIndex;
            m_effects = new System.Collections.Generic.List<ObjectEffect>();
            for (effectsIndex = 0; (effectsIndex < effectsCount); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToAdd = ProtocolTypeManager.GetInstance<ObjectEffect>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_effects.Add(objectToAdd);
            }
            int pricesCount = reader.ReadUShort();
            int pricesIndex;
            m_prices = new System.Collections.Generic.List<ulong>();
            for (pricesIndex = 0; (pricesIndex < pricesCount); pricesIndex = (pricesIndex + 1))
            {
                m_prices.Add(reader.ReadVarUhLong());
            }
            m_objectUID = reader.ReadVarUhInt();
        }
    }
}
