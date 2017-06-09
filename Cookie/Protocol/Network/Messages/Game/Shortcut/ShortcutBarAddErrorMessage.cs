//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Shortcut
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ShortcutBarAddErrorMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6227;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_error;
        
        public virtual byte Error
        {
            get
            {
                return m_error;
            }
            set
            {
                m_error = value;
            }
        }
        
        public ShortcutBarAddErrorMessage(byte error)
        {
            m_error = error;
        }
        
        public ShortcutBarAddErrorMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_error);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_error = reader.ReadByte();
        }
    }
}
