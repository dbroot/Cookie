//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Preset
{
    using Cookie.Protocol.Network.Types.Game.Inventory.Preset;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class InventoryPresetItemUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6168;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PresetItem m_presetItem;
        
        public virtual PresetItem PresetItem
        {
            get
            {
                return m_presetItem;
            }
            set
            {
                m_presetItem = value;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        public InventoryPresetItemUpdateMessage(PresetItem presetItem, byte presetId)
        {
            m_presetItem = presetItem;
            m_presetId = presetId;
        }
        
        public InventoryPresetItemUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_presetItem.Serialize(writer);
            writer.WriteByte(m_presetId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_presetItem = new PresetItem();
            m_presetItem.Deserialize(reader);
            m_presetId = reader.ReadByte();
        }
    }
}
