//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Fight
{
    using Cookie.Protocol.Network.Types.Game.Context.Fight;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameRolePlayShowChallengeMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 301;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private FightCommonInformations m_commonsInfos;
        
        public virtual FightCommonInformations CommonsInfos
        {
            get
            {
                return m_commonsInfos;
            }
            set
            {
                m_commonsInfos = value;
            }
        }
        
        public GameRolePlayShowChallengeMessage(FightCommonInformations commonsInfos)
        {
            m_commonsInfos = commonsInfos;
        }
        
        public GameRolePlayShowChallengeMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_commonsInfos.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_commonsInfos = new FightCommonInformations();
            m_commonsInfos.Deserialize(reader);
        }
    }
}
