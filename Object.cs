using System;

namespace Sharptile
{
    [Serializable]
    public struct Object
    {
        public bool ellipse;
        public int gid;
        public double height;
        public int id;
        public string name;
        public bool point;
        public Coordinate[] polygon;
        public Coordinate[] polyline;
        public Property[] properties;
        public double rotation;
        public string template;
        public Text text;
        public string type;
        public bool visible;
        public double width;
        public double x;
        public double y;
    }
}
