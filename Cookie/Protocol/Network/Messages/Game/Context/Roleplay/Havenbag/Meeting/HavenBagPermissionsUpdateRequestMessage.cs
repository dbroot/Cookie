//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class HavenBagPermissionsUpdateRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6714;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_permissions;
        
        public virtual int Permissions
        {
            get
            {
                return m_permissions;
            }
            set
            {
                m_permissions = value;
            }
        }
        
        public HavenBagPermissionsUpdateRequestMessage(int permissions)
        {
            m_permissions = permissions;
        }
        
        public HavenBagPermissionsUpdateRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_permissions);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_permissions = reader.ReadInt();
        }
    }
}
