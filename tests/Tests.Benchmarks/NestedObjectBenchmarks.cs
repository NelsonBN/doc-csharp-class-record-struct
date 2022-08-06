using System.Collections.Generic;
using Tests.Benchmarks.Models.NestedReferenceTypes;

namespace Tests.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class NestedObjectsBenchmarks
{
    [Params(10, 100, 1000, 10_000_000)]
    public int TotalItems;


    [Benchmark(Baseline = true)]
    public void Class()
    {
        var classList = new List<ClassObject>(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            classList.Add(new()
            {
                Value = count,
                Nested = new()
                {
                    X = count,
                    Y = count,
                    Z = count
                }
            });
        }
    }

    [Benchmark]
    public void RecordClass()
    {
        var classList = new List<RecordClassObject>(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            classList.Add(new()
            {
                Value = count,
                Nested = new()
                {
                    X = count,
                    Y = count,
                    Z = count
                }
            });
        }
    }

    [Benchmark]
    public void Record()
    {
        var classList = new List<RecordObject>(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            classList.Add(new()
            {
                Value = count,
                Nested = new()
                {
                    X = count,
                    Y = count,
                    Z = count
                }
            });
        }
    }

    [Benchmark]
    public void RecordStruct()
    {
        var classList = new List<RecordStructObject>(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            classList.Add(new()
            {
                Value = count,
                Nested = new()
                {
                    X = count,
                    Y = count,
                    Z = count
                }
            });
        }
    }

    [Benchmark]
    public void Struct()
    {
        var classList = new List<StructObject>(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            classList.Add(new()
            {
                Value = count,
                Nested = new()
                {
                    X = count,
                    Y = count,
                    Z = count
                }
            });
        }
    }
}
