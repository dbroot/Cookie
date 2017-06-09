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
    using Cookie.IO;
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;


    public class JobDescriptionMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5655;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<JobDescription> m_jobsDescription;
        
        public virtual List<JobDescription> JobsDescription
        {
            get
            {
                return m_jobsDescription;
            }
            set
            {
                m_jobsDescription = value;
            }
        }
        
        public JobDescriptionMessage(List<JobDescription> jobsDescription)
        {
            m_jobsDescription = jobsDescription;
        }
        
        public JobDescriptionMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_jobsDescription.Count)));
            int jobsDescriptionIndex;
            for (jobsDescriptionIndex = 0; (jobsDescriptionIndex < m_jobsDescription.Count); jobsDescriptionIndex = (jobsDescriptionIndex + 1))
            {
                JobDescription objectToSend = m_jobsDescription[jobsDescriptionIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int jobsDescriptionCount = reader.ReadUShort();
            int jobsDescriptionIndex;
            m_jobsDescription = new System.Collections.Generic.List<JobDescription>();
            for (jobsDescriptionIndex = 0; (jobsDescriptionIndex < jobsDescriptionCount); jobsDescriptionIndex = (jobsDescriptionIndex + 1))
            {
                JobDescription objectToAdd = new JobDescription();
                objectToAdd.Deserialize(reader);
                m_jobsDescription.Add(objectToAdd);
            }
        }
    }
}