//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Actions.Fight
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
    {
        
        public new const short ProtocolId = 209;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_delta;
        
        public virtual short Delta
        {
            get
            {
                return m_delta;
            }
            set
            {
                m_delta = value;
            }
        }
        
        public FightTemporaryBoostEffect(short delta)
        {
            m_delta = delta;
        }
        
        public FightTemporaryBoostEffect()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(m_delta);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_delta = reader.ReadShort();
        }
    }
}
