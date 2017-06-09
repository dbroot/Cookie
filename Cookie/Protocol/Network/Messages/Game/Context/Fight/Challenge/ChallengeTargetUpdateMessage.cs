//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Fight.Challenge
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ChallengeTargetUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6123;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_challengeId;
        
        public virtual ushort ChallengeId
        {
            get
            {
                return m_challengeId;
            }
            set
            {
                m_challengeId = value;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        public ChallengeTargetUpdateMessage(ushort challengeId, double targetId)
        {
            m_challengeId = challengeId;
            m_targetId = targetId;
        }
        
        public ChallengeTargetUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_challengeId);
            writer.WriteDouble(m_targetId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_challengeId = reader.ReadVarUhShort();
            m_targetId = reader.ReadDouble();
        }
    }
}
