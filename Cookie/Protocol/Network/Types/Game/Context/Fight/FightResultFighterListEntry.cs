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
    using Cookie.IO;


    public class FightResultFighterListEntry : FightResultListEntry
    {
        
        public new const short ProtocolId = 189;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_ObjectId;
        
        public virtual double ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        private bool m_alive;
        
        public virtual bool Alive
        {
            get
            {
                return m_alive;
            }
            set
            {
                m_alive = value;
            }
        }
        
        public FightResultFighterListEntry(double objectId, bool alive)
        {
            m_ObjectId = objectId;
            m_alive = alive;
        }
        
        public FightResultFighterListEntry()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_ObjectId);
            writer.WriteBoolean(m_alive);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_ObjectId = reader.ReadDouble();
            m_alive = reader.ReadBoolean();
        }
    }
}
