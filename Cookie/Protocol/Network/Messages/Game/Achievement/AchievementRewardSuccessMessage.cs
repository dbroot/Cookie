//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Achievement
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class AchievementRewardSuccessMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6376;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_achievementId;
        
        public virtual short AchievementId
        {
            get
            {
                return m_achievementId;
            }
            set
            {
                m_achievementId = value;
            }
        }
        
        public AchievementRewardSuccessMessage(short achievementId)
        {
            m_achievementId = achievementId;
        }
        
        public AchievementRewardSuccessMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(m_achievementId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_achievementId = reader.ReadShort();
        }
    }
}
