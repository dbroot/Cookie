//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.Protocol.Network.Messages.Game.Actions;
    using Cookie.IO;


    public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 6312;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private uint m_loss;
        
        public virtual uint Loss
        {
            get
            {
                return m_loss;
            }
            set
            {
                m_loss = value;
            }
        }
        
        private uint m_permanentDamages;
        
        public virtual uint PermanentDamages
        {
            get
            {
                return m_permanentDamages;
            }
            set
            {
                m_permanentDamages = value;
            }
        }
        
        public GameActionFightLifePointsLostMessage(double targetId, uint loss, uint permanentDamages)
        {
            m_targetId = targetId;
            m_loss = loss;
            m_permanentDamages = permanentDamages;
        }
        
        public GameActionFightLifePointsLostMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteVarUhInt(m_loss);
            writer.WriteVarUhInt(m_permanentDamages);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_loss = reader.ReadVarUhInt();
            m_permanentDamages = reader.ReadVarUhInt();
        }
    }
}
