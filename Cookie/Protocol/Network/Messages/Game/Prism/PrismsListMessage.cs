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
    using Cookie.Protocol.Network.Types.Game.Prism;
    using Cookie.IO;
    using System.Collections.Generic;

    public class PrismsListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6440;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<PrismGeolocalizedInformation> m_prisms;
        
        public virtual List<PrismGeolocalizedInformation> Prisms
        {
            get
            {
                return m_prisms;
            }
            set
            {
                m_prisms = value;
            }
        }
        
        public PrismsListMessage(List<PrismGeolocalizedInformation> prisms)
        {
            m_prisms = prisms;
        }
        
        public PrismsListMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_prisms.Count)));
            int prismsIndex;
            for (prismsIndex = 0; (prismsIndex < m_prisms.Count); prismsIndex = (prismsIndex + 1))
            {
                PrismGeolocalizedInformation objectToSend = m_prisms[prismsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int prismsCount = reader.ReadUShort();
            int prismsIndex;
            m_prisms = new System.Collections.Generic.List<PrismGeolocalizedInformation>();
            for (prismsIndex = 0; (prismsIndex < prismsCount); prismsIndex = (prismsIndex + 1))
            {
                PrismGeolocalizedInformation objectToAdd = ProtocolTypeManager.GetInstance<PrismGeolocalizedInformation>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_prisms.Add(objectToAdd);
            }
        }
    }
}
