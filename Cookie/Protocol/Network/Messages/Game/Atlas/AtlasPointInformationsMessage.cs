//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Atlas
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class AtlasPointInformationsMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5956;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AtlasPointsInformations m_type;
        
        public virtual AtlasPointsInformations Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public AtlasPointInformationsMessage(AtlasPointsInformations type)
        {
            m_type = type;
        }
        
        public AtlasPointInformationsMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_type.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_type = new AtlasPointsInformations();
            m_type.Deserialize(reader);
        }
    }
}
