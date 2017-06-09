//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameMapMovementMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 951;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int16> m_keyMovements;
        
        public virtual List<System.Int16> KeyMovements
        {
            get
            {
                return m_keyMovements;
            }
            set
            {
                m_keyMovements = value;
            }
        }
        
        private short m_forcedDirection;
        
        public virtual short ForcedDirection
        {
            get
            {
                return m_forcedDirection;
            }
            set
            {
                m_forcedDirection = value;
            }
        }
        
        private double m_actorId;
        
        public virtual double ActorId
        {
            get
            {
                return m_actorId;
            }
            set
            {
                m_actorId = value;
            }
        }
        
        public GameMapMovementMessage(List<System.Int16> keyMovements, short forcedDirection, double actorId)
        {
            m_keyMovements = keyMovements;
            m_forcedDirection = forcedDirection;
            m_actorId = actorId;
        }
        
        public GameMapMovementMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_keyMovements.Count)));
            int keyMovementsIndex;
            for (keyMovementsIndex = 0; (keyMovementsIndex < m_keyMovements.Count); keyMovementsIndex = (keyMovementsIndex + 1))
            {
                writer.WriteShort(m_keyMovements[keyMovementsIndex]);
            }
            writer.WriteShort(m_forcedDirection);
            writer.WriteDouble(m_actorId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int keyMovementsCount = reader.ReadUShort();
            int keyMovementsIndex;
            m_keyMovements = new System.Collections.Generic.List<short>();
            for (keyMovementsIndex = 0; (keyMovementsIndex < keyMovementsCount); keyMovementsIndex = (keyMovementsIndex + 1))
            {
                m_keyMovements.Add(reader.ReadShort());
            }
            m_forcedDirection = reader.ReadShort();
            m_actorId = reader.ReadDouble();
        }
    }
}
