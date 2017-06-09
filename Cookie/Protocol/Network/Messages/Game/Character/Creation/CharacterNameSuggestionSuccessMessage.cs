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
    
    
    public class CharacterNameSuggestionSuccessMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5544;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_suggestion;
        
        public virtual string Suggestion
        {
            get
            {
                return m_suggestion;
            }
            set
            {
                m_suggestion = value;
            }
        }
        
        public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            m_suggestion = suggestion;
        }
        
        public CharacterNameSuggestionSuccessMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUTF(m_suggestion);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_suggestion = reader.ReadUTF();
        }
    }
}
