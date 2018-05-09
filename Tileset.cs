using System;

namespace Sharptile
{
    [Serializable]
    public struct Tileset
    {
        public int columns;
        public int firstgid;
        public Grid grid;
        public string image;
        public int imagewidth;
        public int imageheight;
        public int margin;
        public string name;
        public Property[] properties;
        public int spacing;
        public Terrain[] terrains;
        public int tilecount;
        public int tileheight;
        public Coordinate tileoffset;
        public Tile[] tiles;
        public int tilewidth;
        public string transparentcolor;
        public string type;
        public WangSet[] wangsets;
    }
}
