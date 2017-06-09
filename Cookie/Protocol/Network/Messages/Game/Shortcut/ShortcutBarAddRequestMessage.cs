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
    using Cookie.Protocol.Network.Types.Game.Shortcut;
    using Cookie.Protocol.Network;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ShortcutBarAddRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6225;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private Shortcut m_shortcut;
        
        public virtual Shortcut Shortcut
        {
            get
            {
                return m_shortcut;
            }
            set
            {
                m_shortcut = value;
            }
        }
        
        private byte m_barType;
        
        public virtual byte BarType
        {
            get
            {
                return m_barType;
            }
            set
            {
                m_barType = value;
            }
        }
        
        public ShortcutBarAddRequestMessage(Shortcut shortcut, byte barType)
        {
            m_shortcut = shortcut;
            m_barType = barType;
        }
        
        public ShortcutBarAddRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUShort(((ushort)(m_shortcut.TypeID)));
            m_shortcut.Serialize(writer);
            writer.WriteByte(m_barType);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_shortcut = ProtocolTypeManager.GetInstance<Shortcut>((short)reader.ReadUShort());
            m_shortcut.Deserialize(reader);
            m_barType = reader.ReadByte();
        }
    }
}
