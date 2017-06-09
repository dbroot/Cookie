//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Guild.Tax
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
    {
        
        public new const short ProtocolId = 446;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicGuildInformations m_guild;
        
        public virtual BasicGuildInformations Guild
        {
            get
            {
                return m_guild;
            }
            set
            {
                m_guild = value;
            }
        }
        
        public TaxCollectorGuildInformations(BasicGuildInformations guild)
        {
            m_guild = guild;
        }
        
        public TaxCollectorGuildInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_guild.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_guild = new BasicGuildInformations();
            m_guild.Deserialize(reader);
        }
    }
}
