//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Mount
{
    using Cookie.Protocol.Network.Types.Game.Mount;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class MountDataMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5973;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private MountClientData m_mountData;
        
        public virtual MountClientData MountData
        {
            get
            {
                return m_mountData;
            }
            set
            {
                m_mountData = value;
            }
        }
        
        public MountDataMessage(MountClientData mountData)
        {
            m_mountData = mountData;
        }
        
        public MountDataMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_mountData.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_mountData = new MountClientData();
            m_mountData.Deserialize(reader);
        }
    }
}
