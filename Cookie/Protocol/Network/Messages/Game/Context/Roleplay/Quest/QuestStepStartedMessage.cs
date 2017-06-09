//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Quest
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class QuestStepStartedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6096;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_questId;
        
        public virtual ushort QuestId
        {
            get
            {
                return m_questId;
            }
            set
            {
                m_questId = value;
            }
        }
        
        private ushort m_stepId;
        
        public virtual ushort StepId
        {
            get
            {
                return m_stepId;
            }
            set
            {
                m_stepId = value;
            }
        }
        
        public QuestStepStartedMessage(ushort questId, ushort stepId)
        {
            m_questId = questId;
            m_stepId = stepId;
        }
        
        public QuestStepStartedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_questId);
            writer.WriteVarUhShort(m_stepId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_questId = reader.ReadVarUhShort();
            m_stepId = reader.ReadVarUhShort();
        }
    }
}
