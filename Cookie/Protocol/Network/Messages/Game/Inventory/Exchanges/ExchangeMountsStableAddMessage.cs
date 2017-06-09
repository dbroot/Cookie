//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using Cookie.Protocol.Network.Types.Game.Mount;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangeMountsStableAddMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6555;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<MountClientData> m_mountDescription;
        
        public virtual List<MountClientData> MountDescription
        {
            get
            {
                return m_mountDescription;
            }
            set
            {
                m_mountDescription = value;
            }
        }
        
        public ExchangeMountsStableAddMessage(List<MountClientData> mountDescription)
        {
            m_mountDescription = mountDescription;
        }
        
        public ExchangeMountsStableAddMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_mountDescription.Count)));
            int mountDescriptionIndex;
            for (mountDescriptionIndex = 0; (mountDescriptionIndex < m_mountDescription.Count); mountDescriptionIndex = (mountDescriptionIndex + 1))
            {
                MountClientData objectToSend = m_mountDescription[mountDescriptionIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int mountDescriptionCount = reader.ReadUShort();
            int mountDescriptionIndex;
            m_mountDescription = new System.Collections.Generic.List<MountClientData>();
            for (mountDescriptionIndex = 0; (mountDescriptionIndex < mountDescriptionCount); mountDescriptionIndex = (mountDescriptionIndex + 1))
            {
                MountClientData objectToAdd = new MountClientData();
                objectToAdd.Deserialize(reader);
                m_mountDescription.Add(objectToAdd);
            }
        }
    }
}
