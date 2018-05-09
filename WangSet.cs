using System;

namespace Sharptile
{
    [Serializable]
    public struct WangSet
    {
        public WangColor[] cornercolors;
        public WangColor[] edgecolors;
        public string name;
        public int tile;
        public WangTile[] wangtiles;
    }
}
