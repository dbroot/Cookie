//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Common.Basic
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class StatisticDataString : StatisticData
    {
        
        public new const short ProtocolId = 487;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_value;
        
        public virtual string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        
        public StatisticDataString(string value)
        {
            m_value = value;
        }
        
        public StatisticDataString()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_value);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_value = reader.ReadUTF();
        }
    }
}
