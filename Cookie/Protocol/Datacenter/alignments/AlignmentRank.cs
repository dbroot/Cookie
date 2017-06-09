

// Generated on 12/06/2016 11:35:49
using System;
using System.Collections.Generic;
using Cookie.Gamedata.D2o;

namespace Cookie.Datacenter
{
    [D2oClass("AlignmentRank")]
    public class AlignmentRank : IDataObject
    {
        public const String MODULE = "AlignmentRank";
        public int Id;
        public uint OrderId;
        public uint NameId;
        public uint DescriptionId;
        public int MinimumAlignment;
        public int ObjectsStolen;
        public List<int> Gifts;
    }
}