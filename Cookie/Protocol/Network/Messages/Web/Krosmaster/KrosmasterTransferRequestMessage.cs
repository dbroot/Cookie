//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Web.Krosmaster
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class KrosmasterTransferRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6349;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_uid;
        
        public virtual string Uid
        {
            get
            {
                return m_uid;
            }
            set
            {
                m_uid = value;
            }
        }
        
        public KrosmasterTransferRequestMessage(string uid)
        {
            m_uid = uid;
        }
        
        public KrosmasterTransferRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUTF(m_uid);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_uid = reader.ReadUTF();
        }
    }
}
