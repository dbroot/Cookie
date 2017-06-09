//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Context.Roleplay.Party
{
    using Cookie.Protocol.Network.Types.Game.Look;
    using Cookie.Protocol.Network.Types.Game.Character.Status;
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay.Party.Companion;
    using Cookie.Protocol.Network;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PartyGuestInformations : NetworkType
    {
        
        public const short ProtocolId = 374;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityLook m_guestLook;
        
        public virtual EntityLook GuestLook
        {
            get
            {
                return m_guestLook;
            }
            set
            {
                m_guestLook = value;
            }
        }
        
        private PlayerStatus m_status;
        
        public virtual PlayerStatus Status
        {
            get
            {
                return m_status;
            }
            set
            {
                m_status = value;
            }
        }
        
        private List<PartyCompanionBaseInformations> m_companions;
        
        public virtual List<PartyCompanionBaseInformations> Companions
        {
            get
            {
                return m_companions;
            }
            set
            {
                m_companions = value;
            }
        }
        
        private ulong m_guestId;
        
        public virtual ulong GuestId
        {
            get
            {
                return m_guestId;
            }
            set
            {
                m_guestId = value;
            }
        }
        
        private ulong m_hostId;
        
        public virtual ulong HostId
        {
            get
            {
                return m_hostId;
            }
            set
            {
                m_hostId = value;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        private byte m_breed;
        
        public virtual byte Breed
        {
            get
            {
                return m_breed;
            }
            set
            {
                m_breed = value;
            }
        }
        
        private bool m_sex;
        
        public virtual bool Sex
        {
            get
            {
                return m_sex;
            }
            set
            {
                m_sex = value;
            }
        }
        
        public PartyGuestInformations(EntityLook guestLook, PlayerStatus status, List<PartyCompanionBaseInformations> companions, ulong guestId, ulong hostId, string name, byte breed, bool sex)
        {
            m_guestLook = guestLook;
            m_status = status;
            m_companions = companions;
            m_guestId = guestId;
            m_hostId = hostId;
            m_name = name;
            m_breed = breed;
            m_sex = sex;
        }
        
        public PartyGuestInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_guestLook.Serialize(writer);
            writer.WriteUShort(((ushort)(m_status.TypeID)));
            m_status.Serialize(writer);
            writer.WriteShort(((short)(m_companions.Count)));
            int companionsIndex;
            for (companionsIndex = 0; (companionsIndex < m_companions.Count); companionsIndex = (companionsIndex + 1))
            {
                PartyCompanionBaseInformations objectToSend = m_companions[companionsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteVarUhLong(m_guestId);
            writer.WriteVarUhLong(m_hostId);
            writer.WriteUTF(m_name);
            writer.WriteByte(m_breed);
            writer.WriteBoolean(m_sex);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_guestLook = new EntityLook();
            m_guestLook.Deserialize(reader);
            m_status = ProtocolTypeManager.GetInstance<PlayerStatus>((short)reader.ReadUShort());
            m_status.Deserialize(reader);
            int companionsCount = reader.ReadUShort();
            int companionsIndex;
            m_companions = new System.Collections.Generic.List<PartyCompanionBaseInformations>();
            for (companionsIndex = 0; (companionsIndex < companionsCount); companionsIndex = (companionsIndex + 1))
            {
                PartyCompanionBaseInformations objectToAdd = new PartyCompanionBaseInformations();
                objectToAdd.Deserialize(reader);
                m_companions.Add(objectToAdd);
            }
            m_guestId = reader.ReadVarUhLong();
            m_hostId = reader.ReadVarUhLong();
            m_name = reader.ReadUTF();
            m_breed = reader.ReadByte();
            m_sex = reader.ReadBoolean();
        }
    }
}
