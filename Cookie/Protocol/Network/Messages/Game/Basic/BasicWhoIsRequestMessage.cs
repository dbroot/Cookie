//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Basic
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class BasicWhoIsRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 181;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_verbose;
        
        public virtual bool Verbose
        {
            get
            {
                return m_verbose;
            }
            set
            {
                m_verbose = value;
            }
        }
        
        private string m_search;
        
        public virtual string Search
        {
            get
            {
                return m_search;
            }
            set
            {
                m_search = value;
            }
        }
        
        public BasicWhoIsRequestMessage(bool verbose, string search)
        {
            m_verbose = verbose;
            m_search = search;
        }
        
        public BasicWhoIsRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_verbose);
            writer.WriteUTF(m_search);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_verbose = reader.ReadBoolean();
            m_search = reader.ReadUTF();
        }
    }
}
