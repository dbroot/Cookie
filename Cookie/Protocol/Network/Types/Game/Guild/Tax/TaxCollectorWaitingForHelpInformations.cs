//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Guild.Tax
{
    using Cookie.Protocol.Network.Types.Game.Fight;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class TaxCollectorWaitingForHelpInformations : TaxCollectorComplementaryInformations
    {
        
        public new const short ProtocolId = 447;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ProtectedEntityWaitingForHelpInfo m_waitingForHelpInfo;
        
        public virtual ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo
        {
            get
            {
                return m_waitingForHelpInfo;
            }
            set
            {
                m_waitingForHelpInfo = value;
            }
        }
        
        public TaxCollectorWaitingForHelpInformations(ProtectedEntityWaitingForHelpInfo waitingForHelpInfo)
        {
            m_waitingForHelpInfo = waitingForHelpInfo;
        }
        
        public TaxCollectorWaitingForHelpInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_waitingForHelpInfo.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_waitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
            m_waitingForHelpInfo.Deserialize(reader);
        }
    }
}
