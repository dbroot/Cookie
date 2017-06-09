//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Context.Fight
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
    {
        
        public new const short ProtocolId = 455;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_creatureGenericId;
        
        public virtual ushort CreatureGenericId
        {
            get
            {
                return m_creatureGenericId;
            }
            set
            {
                m_creatureGenericId = value;
            }
        }
        
        public GameFightFighterMonsterLightInformations(ushort creatureGenericId)
        {
            m_creatureGenericId = creatureGenericId;
        }
        
        public GameFightFighterMonsterLightInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_creatureGenericId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_creatureGenericId = reader.ReadVarUhShort();
        }
    }
}
