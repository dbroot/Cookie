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
    
    
    public class LifePointsRegenBeginMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5684;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_regenRate;
        
        public virtual sbyte RegenRate
        {
            get
            {
                return m_regenRate;
            }
            set
            {
                m_regenRate = value;
            }
        }
        
        public LifePointsRegenBeginMessage(sbyte regenRate)
        {
            m_regenRate = regenRate;
        }
        
        public LifePointsRegenBeginMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteSByte(m_regenRate);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_regenRate = reader.ReadSByte();
        }
    }
}
