//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Context.Roleplay
{
    using Cookie.Protocol.Network.Types.Game.Look;
    using Cookie.Protocol.Network.Types.Game.Context;
    using Cookie.Protocol.Network;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
    {
        
        public new const short ProtocolId = 129;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<HumanOption> m_options;
        
        public virtual List<HumanOption> Options
        {
            get
            {
                return m_options;
            }
            set
            {
                m_options = value;
            }
        }
        
        private byte m_sellType;
        
        public virtual byte SellType
        {
            get
            {
                return m_sellType;
            }
            set
            {
                m_sellType = value;
            }
        }
        
        public GameRolePlayMerchantInformations(List<HumanOption> options, byte sellType)
        {
            m_options = options;
            m_sellType = sellType;
        }
        
        public GameRolePlayMerchantInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_sellType);
            writer.WriteShort(((short)(m_options.Count)));
            int optionsIndex;
            for (optionsIndex = 0; (optionsIndex < m_options.Count); optionsIndex = (optionsIndex + 1))
            {
                HumanOption objectToSend = m_options[optionsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_sellType = reader.ReadByte();
            int optionsCount = reader.ReadUShort();
            int optionsIndex;
            m_options = new System.Collections.Generic.List<HumanOption>();
            for (optionsIndex = 0; (optionsIndex < optionsCount); optionsIndex = (optionsIndex + 1))
            {
                HumanOption objectToAdd = ProtocolTypeManager.GetInstance<HumanOption>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_options.Add(objectToAdd);
            }
        }
    }
}
