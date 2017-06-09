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
    
    
    public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
    {
        
        public new const short ProtocolId = 464;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GroupMonsterStaticInformations> m_alternatives;
        
        public virtual List<GroupMonsterStaticInformations> Alternatives
        {
            get
            {
                return m_alternatives;
            }
            set
            {
                m_alternatives = value;
            }
        }
        
        private byte m_nbWaves;
        
        public virtual byte NbWaves
        {
            get
            {
                return m_nbWaves;
            }
            set
            {
                m_nbWaves = value;
            }
        }
        
        public GameRolePlayGroupMonsterWaveInformations(List<GroupMonsterStaticInformations> alternatives, byte nbWaves)
        {
            m_alternatives = alternatives;
            m_nbWaves = nbWaves;
        }
        
        public GameRolePlayGroupMonsterWaveInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_alternatives.Count)));
            int alternativesIndex;
            for (alternativesIndex = 0; (alternativesIndex < m_alternatives.Count); alternativesIndex = (alternativesIndex + 1))
            {
                GroupMonsterStaticInformations objectToSend = m_alternatives[alternativesIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_nbWaves);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_nbWaves = reader.ReadByte();
            int alternativesCount = reader.ReadUShort();
            int alternativesIndex;
            m_alternatives = new System.Collections.Generic.List<GroupMonsterStaticInformations>();
            for (alternativesIndex = 0; (alternativesIndex < alternativesCount); alternativesIndex = (alternativesIndex + 1))
            {
                GroupMonsterStaticInformations objectToAdd = ProtocolTypeManager.GetInstance<GroupMonsterStaticInformations>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_alternatives.Add(objectToAdd);
            }
        }
    }
}
