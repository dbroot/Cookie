//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Items
{
    using Cookie.Protocol.Network.Messages.Game.Inventory.Exchanges;
    using Cookie.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangeObjectPutInBagMessage : ExchangeObjectMessage
    {
        
        public new const uint ProtocolId = 6009;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItem m_object;
        
        public virtual ObjectItem Object
        {
            get
            {
                return m_object;
            }
            set
            {
                m_object = value;
            }
        }
        
        public ExchangeObjectPutInBagMessage(ObjectItem @object)
        {
            m_object = @object;
        }
        
        public ExchangeObjectPutInBagMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_object.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_object = new ObjectItem();
            m_object.Deserialize(reader);
        }
    }
}
