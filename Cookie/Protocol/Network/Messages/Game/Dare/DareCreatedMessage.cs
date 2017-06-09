//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Dare
{
    using Cookie.Protocol.Network.Types.Game.Dare;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class DareCreatedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6668;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private DareInformations m_dareInfos;
        
        public virtual DareInformations DareInfos
        {
            get
            {
                return m_dareInfos;
            }
            set
            {
                m_dareInfos = value;
            }
        }
        
        private bool m_needNotifications;
        
        public virtual bool NeedNotifications
        {
            get
            {
                return m_needNotifications;
            }
            set
            {
                m_needNotifications = value;
            }
        }
        
        public DareCreatedMessage(DareInformations dareInfos, bool needNotifications)
        {
            m_dareInfos = dareInfos;
            m_needNotifications = needNotifications;
        }
        
        public DareCreatedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_dareInfos.Serialize(writer);
            writer.WriteBoolean(m_needNotifications);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_dareInfos = new DareInformations();
            m_dareInfos.Deserialize(reader);
            m_needNotifications = reader.ReadBoolean();
        }
    }
}
