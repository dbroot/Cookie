//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Dare
{
    using Cookie.Protocol.Network.Types.Game.Dare;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class DareRewardsListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6677;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<DareReward> m_rewards;
        
        public virtual List<DareReward> Rewards
        {
            get
            {
                return m_rewards;
            }
            set
            {
                m_rewards = value;
            }
        }
        
        public DareRewardsListMessage(List<DareReward> rewards)
        {
            m_rewards = rewards;
        }
        
        public DareRewardsListMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_rewards.Count)));
            int rewardsIndex;
            for (rewardsIndex = 0; (rewardsIndex < m_rewards.Count); rewardsIndex = (rewardsIndex + 1))
            {
                DareReward objectToSend = m_rewards[rewardsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int rewardsCount = reader.ReadUShort();
            int rewardsIndex;
            m_rewards = new System.Collections.Generic.List<DareReward>();
            for (rewardsIndex = 0; (rewardsIndex < rewardsCount); rewardsIndex = (rewardsIndex + 1))
            {
                DareReward objectToAdd = new DareReward();
                objectToAdd.Deserialize(reader);
                m_rewards.Add(objectToAdd);
            }
        }
    }
}
