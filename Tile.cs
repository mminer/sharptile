using System;

namespace Sharptile
{
    [Serializable]
    public struct Tile
    {
        public Frame[] animation;
        public int id;
        public string image;
        public int gimageheight;
        public int imagewidth;
        public Layer objectgroup;
        public Property[] properties;
        public Terrain[] terrain;
    }
}
