using System.Collections.Generic;
using Tests.Benchmarks.Models.Comparation;

namespace Tests.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ComparationBenchmarks
{
    [Params(10, 100, 1000, 10_000_000)]
    public int TotalItems;


    [GlobalSetup]
    public void GlobalSetup()
    {
        _prepareClasses();
        _prepareRecords();

        _prepareStructBase();
        _prepareStructWithBoxing();
        _prepareStructWithutBoxing();

        _prepareClassRecords();
        _prepareRecordStructs();

        _prepareRecordStructsIEquatable();
    }


    /* ***** CLASSES ***** */
    public List<ClassObject> ClassList;
    public ClassObject ClassObject;

    [Benchmark(Baseline = true)] public void SearchClass() => ClassList.Contains(ClassObject);

    private void _prepareClasses()
    {
        ClassList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            ClassList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        ClassObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }



    /* ***** RECORDS ***** */
    public List<RecordObject> RecordList;
    public RecordObject RecordObject;

    [Benchmark] public void SearchRecord() => RecordList.Contains(RecordObject);

    private void _prepareRecords()
    {
        RecordList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            RecordList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        RecordObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }



    /* ***** STRUCTS ***** */
    public List<StructObjectBase> StructBaseList;
    public StructObjectBase StructBaseObject;

    [Benchmark] public void SearchStructBase() => StructBaseList.Contains(StructBaseObject);

    private void _prepareStructBase()
    {
        StructBaseList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            StructBaseList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        StructBaseObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }



    /* ***** STRUCTS WITH BOXING ***** */
    public List<StructObjectWithBoxing> StructWithBoxingList;
    public StructObjectWithBoxing StructWithBoxingObject;

    [Benchmark] public void SearchStructWithBoxing() => StructWithBoxingList.Contains(StructWithBoxingObject);

    private void _prepareStructWithBoxing()
    {
        StructWithBoxingList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            StructWithBoxingList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        StructWithBoxingObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }



    /* ***** STRUCTS WITHOUT BOXING ***** */
    public List<StructObjectWithoutBoxing> StructWithoutBoxingList;
    public StructObjectWithoutBoxing StructWithutBoxingObject;

    [Benchmark] public void SearchStructWithutBoxing() => StructWithoutBoxingList.Contains(StructWithutBoxingObject);

    private void _prepareStructWithutBoxing()
    {
        StructWithoutBoxingList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            StructWithoutBoxingList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        StructWithutBoxingObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }

    /* ***** CLASS RECORDS ***** */
    public List<RecordClassObject> ClassRecordList;
    public RecordClassObject ClassRecordObject;

    [Benchmark] public void SearchClassRecord() => ClassRecordList.Contains(ClassRecordObject);

    private void _prepareClassRecords()
    {
        ClassRecordList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            ClassRecordList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        ClassRecordObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }

    /* ***** RECORD STRUCTS ***** */
    public List<RecordStructObjectBase> RecordStructBaseList;
    public RecordStructObjectBase RecordStructObject;

    [Benchmark] public void SearchRecordStruct() => RecordStructBaseList.Contains(RecordStructObject);

    private void _prepareRecordStructs()
    {
        RecordStructBaseList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            RecordStructBaseList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        RecordStructObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }

    /* ***** RECORD STRUCTS ***** */
    public List<RecordStructObjectIEquatable> RecordStructIEquatableList;
    public RecordStructObjectIEquatable RecordStructIEquatableObject;

    [Benchmark] public void SearchRecordStructIEquatable() => RecordStructIEquatableList.Contains(RecordStructIEquatableObject);

    private void _prepareRecordStructsIEquatable()
    {
        RecordStructIEquatableList = new(TotalItems);
        for(var count = 0; count < TotalItems; count++)
        {
            RecordStructIEquatableList.Add(new()
            {
                X = count,
                Y = count,
                Z = count
            });
        }
        RecordStructIEquatableObject = new()
        {
            X = -1,
            Y = -1,
            Z = -1
        };
    }
}
