using System;

namespace Sharptile
{
    [Serializable]
    public struct Map
    {
        public string backgroundcolor;
        public int height;
        public int hexsidelength;
        public bool infinite;
        public Layer[] layers;
        public int nextlayerid;
        public int nextobjectid;
        public string orientation;
        public Property[] properties;
        public string renderorder;
        public string staggeraxis;
        public string staggerindex;
        public string tiledversion;
        public int tileheight;
        public Tileset[] tilesets;
        public int tilewidth;
        public string type;
        public double version;
        public int width;
    }
}
