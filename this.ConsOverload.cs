using System;

class XYCoord
{
    public int x, y;


    public XYCoord() : this(0,0){

    }

    public XYCoord(XYCoord obj) : this(obj.x, obj.y)
    {

    }

    public XYCoord(int i, int j)
    {
        x = i;
        y = j;
    }
}
