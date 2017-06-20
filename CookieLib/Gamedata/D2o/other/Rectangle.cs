﻿using Cookie.Gamedata.D2o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie.GameData.D2O
{
    public class Rectangle : IDataObject
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int top;
        public int right;
        public int left;
        public int bottom;
        public Point bottomRight;
        public Point size;
        public Point topLeft;
    }
}
