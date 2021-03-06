//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Dare
{
    using Cookie.Protocol.Network.Types.Game.Character;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class DareInformations : NetworkType
    {
        
        public const short ProtocolId = 502;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterBasicMinimalInformations m_creator;
        
        public virtual CharacterBasicMinimalInformations Creator
        {
            get
            {
                return m_creator;
            }
            set
            {
                m_creator = value;
            }
        }
        
        private List<DareCriteria> m_criterions;
        
        public virtual List<DareCriteria> Criterions
        {
            get
            {
                return m_criterions;
            }
            set
            {
                m_criterions = value;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        private ulong m_subscriptionFee;
        
        public virtual ulong SubscriptionFee
        {
            get
            {
                return m_subscriptionFee;
            }
            set
            {
                m_subscriptionFee = value;
            }
        }
        
        private ulong m_jackpot;
        
        public virtual ulong Jackpot
        {
            get
            {
                return m_jackpot;
            }
            set
            {
                m_jackpot = value;
            }
        }
        
        private ushort m_maxCountWinners;
        
        public virtual ushort MaxCountWinners
        {
            get
            {
                return m_maxCountWinners;
            }
            set
            {
                m_maxCountWinners = value;
            }
        }
        
        private double m_endDate;
        
        public virtual double EndDate
        {
            get
            {
                return m_endDate;
            }
            set
            {
                m_endDate = value;
            }
        }
        
        private bool m_isPrivate;
        
        public virtual bool IsPrivate
        {
            get
            {
                return m_isPrivate;
            }
            set
            {
                m_isPrivate = value;
            }
        }
        
        private uint m_guildId;
        
        public virtual uint GuildId
        {
            get
            {
                return m_guildId;
            }
            set
            {
                m_guildId = value;
            }
        }
        
        private uint m_allianceId;
        
        public virtual uint AllianceId
        {
            get
            {
                return m_allianceId;
            }
            set
            {
                m_allianceId = value;
            }
        }
        
        private double m_startDate;
        
        public virtual double StartDate
        {
            get
            {
                return m_startDate;
            }
            set
            {
                m_startDate = value;
            }
        }
        
        public DareInformations(CharacterBasicMinimalInformations creator, List<DareCriteria> criterions, double dareId, ulong subscriptionFee, ulong jackpot, ushort maxCountWinners, double endDate, bool isPrivate, uint guildId, uint allianceId, double startDate)
        {
            m_creator = creator;
            m_criterions = criterions;
            m_dareId = dareId;
            m_subscriptionFee = subscriptionFee;
            m_jackpot = jackpot;
            m_maxCountWinners = maxCountWinners;
            m_endDate = endDate;
            m_isPrivate = isPrivate;
            m_guildId = guildId;
            m_allianceId = allianceId;
            m_startDate = startDate;
        }
        
        public DareInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_creator.Serialize(writer);
            writer.WriteShort(((short)(m_criterions.Count)));
            int criterionsIndex;
            for (criterionsIndex = 0; (criterionsIndex < m_criterions.Count); criterionsIndex = (criterionsIndex + 1))
            {
                DareCriteria objectToSend = m_criterions[criterionsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteDouble(m_dareId);
            writer.WriteVarUhLong(m_subscriptionFee);
            writer.WriteVarUhLong(m_jackpot);
            writer.WriteUShort(m_maxCountWinners);
            writer.WriteDouble(m_endDate);
            writer.WriteBoolean(m_isPrivate);
            writer.WriteVarUhInt(m_guildId);
            writer.WriteVarUhInt(m_allianceId);
            writer.WriteDouble(m_startDate);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_creator = new CharacterBasicMinimalInformations();
            m_creator.Deserialize(reader);
            int criterionsCount = reader.ReadUShort();
            int criterionsIndex;
            m_criterions = new System.Collections.Generic.List<DareCriteria>();
            for (criterionsIndex = 0; (criterionsIndex < criterionsCount); criterionsIndex = (criterionsIndex + 1))
            {
                DareCriteria objectToAdd = new DareCriteria();
                objectToAdd.Deserialize(reader);
                m_criterions.Add(objectToAdd);
            }
            m_dareId = reader.ReadDouble();
            m_subscriptionFee = reader.ReadVarUhLong();
            m_jackpot = reader.ReadVarUhLong();
            m_maxCountWinners = reader.ReadUShort();
            m_endDate = reader.ReadDouble();
            m_isPrivate = reader.ReadBoolean();
            m_guildId = reader.ReadVarUhInt();
            m_allianceId = reader.ReadVarUhInt();
            m_startDate = reader.ReadDouble();
        }
    }
}
