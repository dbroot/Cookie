//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay.Party;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PartyNewGuestMessage : AbstractPartyEventMessage
    {
        
        public new const uint ProtocolId = 6260;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PartyGuestInformations m_guest;
        
        public virtual PartyGuestInformations Guest
        {
            get
            {
                return m_guest;
            }
            set
            {
                m_guest = value;
            }
        }
        
        public PartyNewGuestMessage(PartyGuestInformations guest)
        {
            m_guest = guest;
        }
        
        public PartyNewGuestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_guest.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_guest = new PartyGuestInformations();
            m_guest.Deserialize(reader);
        }
    }
}
