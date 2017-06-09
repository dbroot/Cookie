//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Job
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class JobExperienceMultiUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5809;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<JobExperience> m_experiencesUpdate;
        
        public virtual List<JobExperience> ExperiencesUpdate
        {
            get
            {
                return m_experiencesUpdate;
            }
            set
            {
                m_experiencesUpdate = value;
            }
        }
        
        public JobExperienceMultiUpdateMessage(List<JobExperience> experiencesUpdate)
        {
            m_experiencesUpdate = experiencesUpdate;
        }
        
        public JobExperienceMultiUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_experiencesUpdate.Count)));
            int experiencesUpdateIndex;
            for (experiencesUpdateIndex = 0; (experiencesUpdateIndex < m_experiencesUpdate.Count); experiencesUpdateIndex = (experiencesUpdateIndex + 1))
            {
                JobExperience objectToSend = m_experiencesUpdate[experiencesUpdateIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int experiencesUpdateCount = reader.ReadUShort();
            int experiencesUpdateIndex;
            m_experiencesUpdate = new System.Collections.Generic.List<JobExperience>();
            for (experiencesUpdateIndex = 0; (experiencesUpdateIndex < experiencesUpdateCount); experiencesUpdateIndex = (experiencesUpdateIndex + 1))
            {
                JobExperience objectToAdd = new JobExperience();
                objectToAdd.Deserialize(reader);
                m_experiencesUpdate.Add(objectToAdd);
            }
        }
    }
}
