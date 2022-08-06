using System;

namespace Tests.Benchmarks.Models.Comparation;

public struct StructObjectBase
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}

public struct StructObjectWithBoxing
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override bool Equals(object obj)
    {
        if(obj is not ClassObject other)
        {
            return false;
        }

        return
            X == other.X &&
            Y == other.Y &&
            Z == other.Z;
    }
}


public struct StructObjectWithoutBoxing : IEquatable<StructObjectWithoutBoxing>
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    //public override bool Equals(object obj)
    //{
    //    if(obj is not ClassObject other)
    //    {
    //        return false;
    //    }

    //    return
    //        X == other.X &&
    //        Y == other.Y &&
    //        Z == other.Z;
    //}

    public bool Equals(StructObjectWithoutBoxing other)
        => X == other.X &&
           Y == other.Y &&
           Z == other.Z;
}
