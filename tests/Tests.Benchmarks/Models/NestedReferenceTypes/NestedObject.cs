namespace Tests.Benchmarks.Models.NestedReferenceTypes;

public class NestedObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}


public class ClassObject
{
    public int Value { get; set; }
    public NestedObject Nested { get; set; }
}

public record class RecordClassObject
{
    public int Value { get; set; }
    public NestedObject Nested { get; set; }
}

public record RecordObject
{
    public int Value { get; set; }
    public NestedObject Nested { get; set; }
}

public record struct RecordStructObject
{
    public int Value { get; set; }
    public NestedObject Nested { get; set; }
}

public struct StructObject
{
    public int Value { get; set; }
    public NestedObject Nested { get; set; }
}
