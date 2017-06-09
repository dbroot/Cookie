//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Creation
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterCreationResultMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 161;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_result;
        
        public virtual byte Result
        {
            get
            {
                return m_result;
            }
            set
            {
                m_result = value;
            }
        }
        
        public CharacterCreationResultMessage(byte result)
        {
            m_result = result;
        }
        
        public CharacterCreationResultMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_result);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_result = reader.ReadByte();
        }
    }
}
