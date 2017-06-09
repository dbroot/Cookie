//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Common.Basic
{
    using Cookie.Protocol.Network.Types.Common.Basic;
    using Cookie.Protocol.Network;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class AggregateStatWithDataMessage : AggregateStatMessage
    {
        
        public new const uint ProtocolId = 6662;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<StatisticData> m_datas;
        
        public virtual List<StatisticData> Datas
        {
            get
            {
                return m_datas;
            }
            set
            {
                m_datas = value;
            }
        }
        
        public AggregateStatWithDataMessage(List<StatisticData> datas)
        {
            m_datas = datas;
        }
        
        public AggregateStatWithDataMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_datas.Count)));
            int datasIndex;
            for (datasIndex = 0; (datasIndex < m_datas.Count); datasIndex = (datasIndex + 1))
            {
                StatisticData objectToSend = m_datas[datasIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int datasCount = reader.ReadUShort();
            int datasIndex;
            m_datas = new System.Collections.Generic.List<StatisticData>();
            for (datasIndex = 0; (datasIndex < datasCount); datasIndex = (datasIndex + 1))
            {
                StatisticData objectToAdd = ProtocolTypeManager.GetInstance<StatisticData>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_datas.Add(objectToAdd);
            }
        }
    }
}
