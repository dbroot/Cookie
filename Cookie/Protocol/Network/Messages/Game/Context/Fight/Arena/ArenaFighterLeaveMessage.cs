//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Fight.Arena
{
    using Cookie.Protocol.Network.Types.Game.Character;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ArenaFighterLeaveMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6700;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterBasicMinimalInformations m_leaver;
        
        public virtual CharacterBasicMinimalInformations Leaver
        {
            get
            {
                return m_leaver;
            }
            set
            {
                m_leaver = value;
            }
        }
        
        public ArenaFighterLeaveMessage(CharacterBasicMinimalInformations leaver)
        {
            m_leaver = leaver;
        }
        
        public ArenaFighterLeaveMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_leaver.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_leaver = new CharacterBasicMinimalInformations();
            m_leaver.Deserialize(reader);
        }
    }
}
