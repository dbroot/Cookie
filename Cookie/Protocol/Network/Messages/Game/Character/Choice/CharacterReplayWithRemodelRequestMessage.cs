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
    using Cookie.Protocol.Network.Messages.Game.Character.Replay;
    using Cookie.Protocol.Network.Types.Game.Character.Choice;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
    {
        
        public new const uint ProtocolId = 6551;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private RemodelingInformation m_remodel;
        
        public virtual RemodelingInformation Remodel
        {
            get
            {
                return m_remodel;
            }
            set
            {
                m_remodel = value;
            }
        }
        
        public CharacterReplayWithRemodelRequestMessage(RemodelingInformation remodel)
        {
            m_remodel = remodel;
        }
        
        public CharacterReplayWithRemodelRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_remodel.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_remodel = new RemodelingInformation();
            m_remodel.Deserialize(reader);
        }
    }
}
