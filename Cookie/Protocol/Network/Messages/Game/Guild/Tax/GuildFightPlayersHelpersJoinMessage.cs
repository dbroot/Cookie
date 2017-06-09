//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Guild.Tax
{
    using Cookie.Protocol.Network.Types.Game.Character;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5720;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterMinimalPlusLookInformations m_playerInfo;
        
        public virtual CharacterMinimalPlusLookInformations PlayerInfo
        {
            get
            {
                return m_playerInfo;
            }
            set
            {
                m_playerInfo = value;
            }
        }
        
        private int m_fightId;
        
        public virtual int FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        public GuildFightPlayersHelpersJoinMessage(CharacterMinimalPlusLookInformations playerInfo, int fightId)
        {
            m_playerInfo = playerInfo;
            m_fightId = fightId;
        }
        
        public GuildFightPlayersHelpersJoinMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_playerInfo.Serialize(writer);
            writer.WriteInt(m_fightId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_playerInfo = new CharacterMinimalPlusLookInformations();
            m_playerInfo.Deserialize(reader);
            m_fightId = reader.ReadInt();
        }
    }
}
