using System;

namespace Sharptile
{
    [Serializable]
    public struct Layer
    {
        public Chunk[] chunks;
        public string compression;
        public int[] data;
        public string draworder;
        public string encoding;
        public int height;
        public int id;
        public string image;
        //public Layer[] layers;
        public string name;
        public Object[] objects;
        public double offsetx;
        public double offsety;
        public double opacity;
        public Property[] properties;
        public string transparentcolor;
        public string type;
        public bool visible;
        public int width;
        public int x;
        public int y;
    }
}
