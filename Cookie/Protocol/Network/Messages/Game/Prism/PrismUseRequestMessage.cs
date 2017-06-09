//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Prism
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PrismUseRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6041;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_moduleToUse;
        
        public virtual byte ModuleToUse
        {
            get
            {
                return m_moduleToUse;
            }
            set
            {
                m_moduleToUse = value;
            }
        }
        
        public PrismUseRequestMessage(byte moduleToUse)
        {
            m_moduleToUse = moduleToUse;
        }
        
        public PrismUseRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_moduleToUse);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_moduleToUse = reader.ReadByte();
        }
    }
}
