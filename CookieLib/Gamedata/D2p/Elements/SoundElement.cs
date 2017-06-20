﻿using Cookie.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cookie.Gamedata.D2p.Elements
{
    public class SoundElement : BasicElement
    {
        // Methods
        internal override void Init(IDataReader Reader, int MapVersion)
        {
            this.SoundId = Reader.ReadInt();
            this.BaseVolume = Reader.ReadShort();
            this.FullVolumeDistance = Reader.ReadInt();
            this.NullVolumeDistance = Reader.ReadInt();
            this.MinDelayBetweenLoops = Reader.ReadShort();
            this.MaxDelayBetweenLoops = Reader.ReadShort();
        }

        // Fields
        public int BaseVolume;
        public int FullVolumeDistance;
        public int MaxDelayBetweenLoops;
        public int MinDelayBetweenLoops;
        public int NullVolumeDistance;
        public int SoundId;
    }
}
