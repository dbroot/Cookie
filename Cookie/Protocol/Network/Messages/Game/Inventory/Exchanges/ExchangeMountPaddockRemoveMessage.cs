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
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangeMountPaddockRemoveMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6050;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_mountId;
        
        public virtual double MountId
        {
            get
            {
                return m_mountId;
            }
            set
            {
                m_mountId = value;
            }
        }
        
        public ExchangeMountPaddockRemoveMessage(double mountId)
        {
            m_mountId = mountId;
        }
        
        public ExchangeMountPaddockRemoveMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteDouble(m_mountId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_mountId = reader.ReadDouble();
        }
    }
}
