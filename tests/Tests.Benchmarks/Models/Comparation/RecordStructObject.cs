using System;

namespace Tests.Benchmarks.Models.Comparation;

public record struct RecordStructObjectBase
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}

public record struct RecordStructObjectIEquatable : IEquatable<RecordStructObjectIEquatable>
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public bool Equals(StructObjectWithoutBoxing other)
        => X == other.X &&
           Y == other.Y &&
           Z == other.Z;
}
