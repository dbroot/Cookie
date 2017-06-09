//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Character.Status
{
    using Cookie.IO;


    public class PlayerStatusExtended : PlayerStatus
    {
        
        public new const short ProtocolId = 414;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_message;
        
        public virtual string Message
        {
            get
            {
                return m_message;
            }
            set
            {
                m_message = value;
            }
        }
        
        public PlayerStatusExtended(string message)
        {
            m_message = message;
        }
        
        public PlayerStatusExtended()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_message);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_message = reader.ReadUTF();
        }
    }
}
