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
    
    
    public class FightTeamMemberCompanionInformations : FightTeamMemberInformations
    {
        
        public new const short ProtocolId = 451;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_companionId;
        
        public virtual byte CompanionId
        {
            get
            {
                return m_companionId;
            }
            set
            {
                m_companionId = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        private double m_masterId;
        
        public virtual double MasterId
        {
            get
            {
                return m_masterId;
            }
            set
            {
                m_masterId = value;
            }
        }
        
        public FightTeamMemberCompanionInformations(byte companionId, sbyte level, double masterId)
        {
            m_companionId = companionId;
            m_level = level;
            m_masterId = masterId;
        }
        
        public FightTeamMemberCompanionInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_companionId);
            writer.WriteSByte(m_level);
            writer.WriteDouble(m_masterId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_companionId = reader.ReadByte();
            m_level = reader.ReadSByte();
            m_masterId = reader.ReadDouble();
        }
    }
}
