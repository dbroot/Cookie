//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Context.Roleplay
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay.Quest;
    using Cookie.Protocol.Network.Types.Game.Look;
    using Cookie.Protocol.Network.Types.Game.Context;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
    {
        
        public new const short ProtocolId = 383;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GameRolePlayNpcQuestFlag m_questFlag;
        
        public virtual GameRolePlayNpcQuestFlag QuestFlag
        {
            get
            {
                return m_questFlag;
            }
            set
            {
                m_questFlag = value;
            }
        }
        
        public GameRolePlayNpcWithQuestInformations(GameRolePlayNpcQuestFlag questFlag)
        {
            m_questFlag = questFlag;
        }
        
        public GameRolePlayNpcWithQuestInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_questFlag.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_questFlag = new GameRolePlayNpcQuestFlag();
            m_questFlag.Deserialize(reader);
        }
    }
}
