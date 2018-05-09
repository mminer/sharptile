using System;

namespace Sharptile
{
    [Serializable]
    public struct Chunk
    {
        public int[] data;
        public int height;
        public int width;
        public int x;
        public int y;
    }
}
