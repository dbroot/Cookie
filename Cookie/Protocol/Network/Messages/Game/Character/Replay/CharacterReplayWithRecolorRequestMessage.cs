//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Replay
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterReplayWithRecolorRequestMessage : CharacterReplayRequestMessage
    {
        
        public new const uint ProtocolId = 6111;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int32> m_indexedColor;
        
        public virtual List<System.Int32> IndexedColor
        {
            get
            {
                return m_indexedColor;
            }
            set
            {
                m_indexedColor = value;
            }
        }
        
        public CharacterReplayWithRecolorRequestMessage(List<System.Int32> indexedColor)
        {
            m_indexedColor = indexedColor;
        }
        
        public CharacterReplayWithRecolorRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_indexedColor.Count)));
            int indexedColorIndex;
            for (indexedColorIndex = 0; (indexedColorIndex < m_indexedColor.Count); indexedColorIndex = (indexedColorIndex + 1))
            {
                writer.WriteInt(m_indexedColor[indexedColorIndex]);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int indexedColorCount = reader.ReadUShort();
            int indexedColorIndex;
            m_indexedColor = new System.Collections.Generic.List<int>();
            for (indexedColorIndex = 0; (indexedColorIndex < indexedColorCount); indexedColorIndex = (indexedColorIndex + 1))
            {
                m_indexedColor.Add(reader.ReadInt());
            }
        }
    }
}
