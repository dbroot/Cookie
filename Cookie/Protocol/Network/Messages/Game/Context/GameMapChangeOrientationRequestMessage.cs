//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameMapChangeOrientationRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 945;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_direction;
        
        public virtual byte Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
            }
        }
        
        public GameMapChangeOrientationRequestMessage(byte direction)
        {
            m_direction = direction;
        }
        
        public GameMapChangeOrientationRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_direction);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_direction = reader.ReadByte();
        }
    }
}
