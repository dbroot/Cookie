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
    
    
    public class KrosmasterTransferMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6348;
        
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
        
        private byte m_failure;
        
        public virtual byte Failure
        {
            get
            {
                return m_failure;
            }
            set
            {
                m_failure = value;
            }
        }
        
        public KrosmasterTransferMessage(string uid, byte failure)
        {
            m_uid = uid;
            m_failure = failure;
        }
        
        public KrosmasterTransferMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUTF(m_uid);
            writer.WriteByte(m_failure);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_uid = reader.ReadUTF();
            m_failure = reader.ReadByte();
        }
    }
}
