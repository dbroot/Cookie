//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Context
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay;
    using Cookie.IO;


    public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
    {
        
        public new const short ProtocolId = 440;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AllianceInformations m_allianceIdentity;
        
        public virtual AllianceInformations AllianceIdentity
        {
            get
            {
                return m_allianceIdentity;
            }
            set
            {
                m_allianceIdentity = value;
            }
        }
        
        public TaxCollectorStaticExtendedInformations(AllianceInformations allianceIdentity)
        {
            m_allianceIdentity = allianceIdentity;
        }
        
        public TaxCollectorStaticExtendedInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_allianceIdentity.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_allianceIdentity = new AllianceInformations();
            m_allianceIdentity.Deserialize(reader);
        }
    }
}
