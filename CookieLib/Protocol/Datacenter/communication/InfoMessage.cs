

// Generated on 12/06/2016 11:35:50
using System;
using System.Collections.Generic;
using Cookie.Gamedata.D2o;

namespace Cookie.Datacenter
{
    [D2oClass("InfoMessages")]
    public class InfoMessage : IDataObject
    {
        public const String MODULE = "InfoMessages";
        public uint TypeId;
        public uint MessageId;
        public uint TextId;
    }
}