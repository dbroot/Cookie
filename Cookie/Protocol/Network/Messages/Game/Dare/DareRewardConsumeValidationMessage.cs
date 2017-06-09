//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Dare
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class DareRewardConsumeValidationMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6675;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        private byte m_type;
        
        public virtual byte Type
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
        
        public DareRewardConsumeValidationMessage(double dareId, byte type)
        {
            m_dareId = dareId;
            m_type = type;
        }
        
        public DareRewardConsumeValidationMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteDouble(m_dareId);
            writer.WriteByte(m_type);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_dareId = reader.ReadDouble();
            m_type = reader.ReadByte();
        }
    }
}
