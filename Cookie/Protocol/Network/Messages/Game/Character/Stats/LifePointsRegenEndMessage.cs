//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Stats
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class LifePointsRegenEndMessage : UpdateLifePointsMessage
    {
        
        public new const uint ProtocolId = 5686;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_lifePointsGained;
        
        public virtual uint LifePointsGained
        {
            get
            {
                return m_lifePointsGained;
            }
            set
            {
                m_lifePointsGained = value;
            }
        }
        
        public LifePointsRegenEndMessage(uint lifePointsGained)
        {
            m_lifePointsGained = lifePointsGained;
        }
        
        public LifePointsRegenEndMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_lifePointsGained);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_lifePointsGained = reader.ReadVarUhInt();
        }
    }
}