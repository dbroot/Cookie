//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Choice
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterFirstSelectionMessage : CharacterSelectionMessage
    {
        
        public new const uint ProtocolId = 6084;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_doTutorial;
        
        public virtual bool DoTutorial
        {
            get
            {
                return m_doTutorial;
            }
            set
            {
                m_doTutorial = value;
            }
        }
        
        public CharacterFirstSelectionMessage(bool doTutorial)
        {
            m_doTutorial = doTutorial;
        }
        
        public CharacterFirstSelectionMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(m_doTutorial);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_doTutorial = reader.ReadBoolean();
        }
    }
}
