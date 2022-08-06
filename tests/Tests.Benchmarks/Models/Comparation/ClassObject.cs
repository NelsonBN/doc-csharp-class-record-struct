namespace Tests.Benchmarks.Models.Comparation;

public class ClassObject
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
