//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Tinsel
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class TitleLostMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6371;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_titleId;
        
        public virtual ushort TitleId
        {
            get
            {
                return m_titleId;
            }
            set
            {
                m_titleId = value;
            }
        }
        
        public TitleLostMessage(ushort titleId)
        {
            m_titleId = titleId;
        }
        
        public TitleLostMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_titleId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_titleId = reader.ReadVarUhShort();
        }
    }
}
