

// Generated on 12/06/2016 11:35:50
using System;
using System.Collections.Generic;
using Cookie.Gamedata.D2o;

namespace Cookie.Datacenter
{
    [D2oClass("SmileyPacks")]
    public class SmileyPack : IDataObject
    {
        public const String MODULE = "SmileyPacks";
        public uint Id;
        public uint NameId;
        public uint Order;
        public List<uint> Smileys;
    }
}