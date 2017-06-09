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
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class MonsterInGroupLightInformations : NetworkType
    {
        
        public const short ProtocolId = 395;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_creatureGenericId;
        
        public virtual int CreatureGenericId
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
        
        private byte m_grade;
        
        public virtual byte Grade
        {
            get
            {
                return m_grade;
            }
            set
            {
                m_grade = value;
            }
        }
        
        public MonsterInGroupLightInformations(int creatureGenericId, byte grade)
        {
            m_creatureGenericId = creatureGenericId;
            m_grade = grade;
        }
        
        public MonsterInGroupLightInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_creatureGenericId);
            writer.WriteByte(m_grade);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_creatureGenericId = reader.ReadInt();
            m_grade = reader.ReadByte();
        }
    }
}
