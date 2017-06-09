//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Fight.Arena
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6284;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_registered;
        
        public virtual bool Registered
        {
            get
            {
                return m_registered;
            }
            set
            {
                m_registered = value;
            }
        }
        
        private byte m_step;
        
        public virtual byte Step
        {
            get
            {
                return m_step;
            }
            set
            {
                m_step = value;
            }
        }
        
        private int m_battleMode;
        
        public virtual int BattleMode
        {
            get
            {
                return m_battleMode;
            }
            set
            {
                m_battleMode = value;
            }
        }
        
        public GameRolePlayArenaRegistrationStatusMessage(bool registered, byte step, int battleMode)
        {
            m_registered = registered;
            m_step = step;
            m_battleMode = battleMode;
        }
        
        public GameRolePlayArenaRegistrationStatusMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_registered);
            writer.WriteByte(m_step);
            writer.WriteInt(m_battleMode);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_registered = reader.ReadBoolean();
            m_step = reader.ReadByte();
            m_battleMode = reader.ReadInt();
        }
    }
}
